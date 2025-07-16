using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using Pulumi;
using Pulumi.Honeycombio;

return await Deployment.RunAsync(() =>
{
    // Create a dataset for monitoring spans
    var dummyDataset = new Dataset("workaround-dataset", new DatasetArgs
    {
        Name = "workaround-dataset",
        Description = "Dummy to ensure triggers can be created"
    });

    // Create a column for duration_ms in the dataset
    var dummyDurationColumn = new Column("duration-column", new ColumnArgs
    {
        Name = "duration_ms",
        Type = "float",
        Description = "Duration of spans in milliseconds",
        Dataset = dummyDataset.Name
    });

    // create a column for trace.parent_id in the dataset
    var dummyParentIdColumn = new Column("parent-id-column", new ColumnArgs
    {
        Name = "trace.parent_id",
        Type = "string",
        Description = "Parent ID of spans",
        Dataset = dummyDataset.Name
    });

    // Create an email recipient for notifications
    var emailRecipient = new EmailRecipient("alert-email-recipient", new EmailRecipientArgs
    {
        Address = "martinthwaites@honeycomb.io"
    });

    // Create a query specification for root spans with duration over 1 second
    var rootSpanDurationQuery = new
    {
        calculations = new[]
        {
            new
            {
                op = "MAX",
                column = "duration_ms"
            }
        },
        filters = new[]
        {
            new
            {
                column = "trace.parent_id",
                op = "does-not-exist",
                value = (string?)null
            },
            new
            {
                column = "duration_ms",
                op = ">",
                value = (string?)"1000"
            }
        },
        time_range = 300 // 5 minutes
    };

    // Create a trigger that fires when any root span exceeds 1 second
    var durationTrigger = new Trigger("root-span-duration-trigger", new TriggerArgs
    {
        Name = "Root Span Duration Alert",
        Description = "Alert when any root span from any service exceeds 1 second",
        QueryJson = JsonSerializer.Serialize(rootSpanDurationQuery),
        AlertType = "on_change",
        Frequency = 300, // Check every 5 minutes
        Thresholds = new[]
        {
            new Pulumi.Honeycombio.Inputs.TriggerThresholdArgs
            {
                Op = ">",
                Value = 1000, // Alert when max duration exceeds 1000ms (1 second)
                ExceededLimit = 1
            }
        },
        Recipients = new[]
        {
            new Pulumi.Honeycombio.Inputs.TriggerRecipientArgs
            {
                Type = "email",
                Target = emailRecipient.Address
            }
        }
    }, new ()
    {
        DependsOn = { dummyDataset, dummyDurationColumn, dummyParentIdColumn }
    });

    // Create a query for the board to show root span duration
    var rootSpanDurationBoardQuery = new Query("root-span-duration-query", new QueryArgs
    {
        Dataset = "__all__",
        QueryJson = JsonSerializer.Serialize(new
        {
            calculations = new[]
            {
                new
                {
                    op = "MAX",
                    column = "duration_ms"
                },
                new
                {
                    op = "AVG",
                    column = "duration_ms"
                },
                new
                {
                    op = "P95",
                    column = "duration_ms"
                }
            },
            filters = new[]
            {
                new
                {
                    column = "trace.parent_id",
                    op = "does-not-exist",
                    value = (string?)null
                }
            },
            time_range = 3600, // 1 hour
            granularity = 300 // 5 minute buckets
        })
    });

    // Create a query annotation for the board query
    var rootSpanAnnotation = new QueryAnnotation("root-span-annotation", new QueryAnnotationArgs
    {
        Name = "Root Span Duration Analysis",
        Description = "This query shows the maximum, average, and 95th percentile duration of root spans over time. Root spans are identified by the absence of a trace.parent_id field, indicating they are the entry points to distributed traces.",
        Dataset = "__all__",
        QueryId = rootSpanDurationBoardQuery.Id
    });

    // Create a flexible board to visualize root span duration
    var durationBoard = new FlexibleBoard("root-span-duration-flexible-board", new FlexibleBoardArgs
    {
        Name = "Root Span Duration Dashboard",
        Description = "Dashboard showing duration metrics for root spans",
        Panels = new[]
        {
            new Pulumi.Honeycombio.Inputs.FlexibleBoardPanelArgs
            {
                Type = "query",
                QueryPanels = new[]
                {
                    new Pulumi.Honeycombio.Inputs.FlexibleBoardPanelQueryPanelArgs
                    {
                        QueryId = rootSpanDurationBoardQuery.Id,
                        QueryAnnotationId = rootSpanAnnotation.Id,
                        QueryStyle = "graph",
                        VisualizationSettings = new[]
                        {
                            new Pulumi.Honeycombio.Inputs.FlexibleBoardPanelQueryPanelVisualizationSettingArgs
                            {
                                UseUtcXaxis = true,
                                HideMarkers = false,
                                PreferOverlaidCharts = false
                            }
                        }
                    }
                }
            }
        }
    });

    return new Dictionary<string, object?>
    {
        ["emailRecipient"] = emailRecipient.Address,
        ["triggerName"] = durationTrigger.Name,
        ["triggerDescription"] = durationTrigger.Description,
        ["datasetName"] = dummyDataset.Name,
        ["boardName"] = durationBoard.Name,
        ["queryId"] = rootSpanDurationBoardQuery.Id,
        ["annotationName"] = rootSpanAnnotation.Name,
        ["annotationId"] = rootSpanAnnotation.Id
    };
});
