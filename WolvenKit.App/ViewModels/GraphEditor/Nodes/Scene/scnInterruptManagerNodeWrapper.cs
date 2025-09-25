using System.Collections.Generic;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;

public class scnInterruptManagerNodeWrapper : BaseSceneViewModel<scnInterruptManagerNode>
{
    public scnInterruptManagerNodeWrapper(scnInterruptManagerNode scnSceneGraphNode) : base(scnSceneGraphNode)
    {
        InputSocketNames.Add(0, "In");

        OutputSocketNames.Add(0, "Out");

        RefreshDetails();
    }

    public override void RefreshDetails()
    {
        var newDetails = new Dictionary<string, string>();

        var operationsCount = _castedData.InterruptionOperations?.Count ?? 0;
        newDetails["Operations Count"] = operationsCount.ToString();

        if (_castedData.InterruptionOperations != null && _castedData.InterruptionOperations.Count > 0)
        {
            var counter = 1;
            foreach (var operation in _castedData.InterruptionOperations)
            {
                if (counter > 3) break;
                
                var operationChunk = operation?.Chunk;
                if (operationChunk != null)
                {
                    var operationType = GetOperationTypeName(operationChunk);
                    
                    if (operationsCount == 1)
                    {
                        newDetails["Operation Type"] = operationType;
                        
                        switch (operationChunk)
                        {
                            case scnToggleInterruption_InterruptionOperation toggleOp:
                                newDetails["Enable"] = toggleOp.Enable ? "True" : "False";
                                break;
                                
                            case scnOverrideInterruptionScenario_InterruptionOperation overrideOp:
                                newDetails["Scenario ID"] = overrideOp.ScenarioId?.Id.ToString() ?? "0";
                                var scenarioOpsCount = overrideOp.ScenarioOperations?.Count ?? 0;
                                if (scenarioOpsCount > 0)
                                {
                                    newDetails["Sub-Operations"] = scenarioOpsCount.ToString();
                                }
                                break;
                        }
                    }
                    else
                    {
                        newDetails[$"Operation #{counter}"] = operationType;
                        
                        switch (operationChunk)
                        {
                            case scnToggleInterruption_InterruptionOperation toggleOp:
                                newDetails[$"Op #{counter} Enable"] = toggleOp.Enable ? "True" : "False";
                                break;
                                
                            case scnOverrideInterruptionScenario_InterruptionOperation overrideOp:
                                newDetails[$"Op #{counter} Scenario ID"] = overrideOp.ScenarioId?.Id.ToString() ?? "0";
                                var scenarioOpsCount = overrideOp.ScenarioOperations?.Count ?? 0;
                                if (scenarioOpsCount > 0)
                                {
                                    newDetails[$"Op #{counter} Sub-Operations"] = scenarioOpsCount.ToString();
                                }
                                break;
                        }
                    }
                }
                else
                {
                    if (operationsCount == 1)
                    {
                        newDetails["Operation Type"] = "Empty";
                    }
                    else
                    {
                        newDetails[$"Operation #{counter}"] = "Empty";
                    }
                }
                
                counter++;
            }
        }
        else
        {
            newDetails["Status"] = "No Operations";
        }

        Details = newDetails;
        UpdateTitle();
        OnPropertyChanged(nameof(Title));
    }

    private static string GetOperationTypeName(scnIInterruptionOperation operation)
    {
        return operation.GetType().Name switch
        {
            "scnToggleInterruption_InterruptionOperation" => "Toggle Interruption",
            "scnOverrideInterruptionScenario_InterruptionOperation" => "Override Scenario",
            _ => operation.GetType().Name.Replace("scn", "").Replace("_InterruptionOperation", "")
        };
    }
}