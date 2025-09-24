using WolvenKit.RED4.Types;
using System.Collections.Generic;
using System.IO;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questUseWorkspotNodeDefinitionWrapper : questAICommandNodeBaseWrapper<questUseWorkspotNodeDefinition>
{
    public questUseWorkspotNodeDefinitionWrapper(questUseWorkspotNodeDefinition questAICommandNodeBase) : base(questAICommandNodeBase)
    {
        PopulateWorkspotDetails();
    }
    public override void RefreshDetails()
    {
        PopulateWorkspotDetails();
        UpdateTitle();
        OnPropertyChanged(nameof(Title));
    }

    private void PopulateWorkspotDetails()
    {
        var tempDetails = new Dictionary<string, string>();
        PopulateWorkspotDetailsInto(_castedData, tempDetails);
        Details = tempDetails;
    }
    private static void PopulateWorkspotDetailsInto(questUseWorkspotNodeDefinition workspotNode, Dictionary<string, string> details, string? resolvedWorkspotInfo = null)
    {
        var paramsV1 = workspotNode.ParamsV1?.GetValue() as questUseWorkspotParamsV1;
        if (paramsV1 != null)
        {
            var function = (Enums.questUseWorkspotNodeFunctions)paramsV1.Function;
            
            if (workspotNode.EntityReference != null)
            {
                string entityStr = NodeProperties.ParseGameEntityReference(workspotNode.EntityReference);
                if (entityStr != "-")
                {
                    details["Entity"] = entityStr;
                }
            }
            
            if (function == Enums.questUseWorkspotNodeFunctions.StopWorkspot)
            {
                details["Action"] = "Stop Workspot";
            }
            else if (function == Enums.questUseWorkspotNodeFunctions.UseWorkspot)
            {
                details["Action"] = "Use Workspot";
            }
            else
            {
                details["Action"] = function.ToString();
            }
            
            if (function == Enums.questUseWorkspotNodeFunctions.UseWorkspot)
            {
                string workspotInfo = "";
                
                if (!string.IsNullOrEmpty(resolvedWorkspotInfo))
                {
                    workspotInfo = resolvedWorkspotInfo;
                }
                else
                {
                    // Fallback to local resolution
                    if (paramsV1.GetType() == typeof(scnUseSceneWorkspotParamsV1))
                    {
                        var sceneParams = (scnUseSceneWorkspotParamsV1)paramsV1;
                        if (sceneParams.WorkspotInstanceId != null && 
                            sceneParams.WorkspotInstanceId.Id != uint.MaxValue &&
                            sceneParams.WorkspotInstanceId.Id != 0)
                        {
                            // Show instance ID for scene workspots
                            workspotInfo = $"Instance [{sceneParams.WorkspotInstanceId.Id}]";
                        }
                    }
                    else if (paramsV1.WorkspotNode != NodeRef.Empty && paramsV1.WorkspotNode != 0)
                    {
                        string nodeRefText = paramsV1.WorkspotNode.GetResolvedText() ?? "[Unresolved]";
                        // Extract just the filename if it's a path
                        if (nodeRefText.Contains("\\") || nodeRefText.Contains("/"))
                        {
                            workspotInfo = Path.GetFileName(nodeRefText);
                        }
                        else
                        {
                            workspotInfo = nodeRefText;
                        }
                    }
                }
                
                if (!string.IsNullOrEmpty(workspotInfo))
                {
                    details["Workspot"] = workspotInfo;
                }
            }
            
            if (paramsV1.EnableIdleMode)
            {
                details["Idle Mode"] = "Enabled";
            }
                
            if (function == Enums.questUseWorkspotNodeFunctions.UseWorkspot)
            {
                if (paramsV1.GetType() == typeof(scnUseSceneWorkspotParamsV1))
                {
                    var sceneWorkspotParams = (scnUseSceneWorkspotParamsV1)paramsV1;
                    
                    if (sceneWorkspotParams.PlayAtActorLocation)
                    {
                        details["Play At Actor Location"] = "Yes";
                    }
                }

                if (paramsV1.EntryId != null && paramsV1.EntryId.Id != uint.MaxValue)
                {
                    details["Entry ID"] = paramsV1.EntryId.Id.ToString();
                }
                
                if (paramsV1.ExitEntryId != null && paramsV1.ExitEntryId.Id != uint.MaxValue)
                {
                    details["Exit Entry ID"] = paramsV1.ExitEntryId.Id.ToString();
                }
            }
            
            details["Teleport"] = paramsV1.Teleport ? "Yes" : "No";
            details["Player"] = paramsV1.IsPlayer ? "Yes" : "No";
            details["Infinite"] = paramsV1.IsWorkspotInfinite ? "Yes" : "No";
            details["Movement Type"] = paramsV1.MovementType.ToString(); 
            
        }
    }
    public static void PopulateWorkspotDetailsWithSceneContext(questUseWorkspotNodeDefinition workspotNode, Dictionary<string, string> details, scnSceneResource? sceneResource = null)
    {
        string? resolvedWorkspotInfo = null;
        
        // Try to resolve scene workspot info if we have scene context
        if (sceneResource != null)
        {
            var paramsV1 = workspotNode.ParamsV1?.GetValue() as questUseWorkspotParamsV1;
            if (paramsV1?.GetType() == typeof(scnUseSceneWorkspotParamsV1))
            {
                var sceneParams = (scnUseSceneWorkspotParamsV1)paramsV1;
                if (sceneParams.WorkspotInstanceId != null && 
                    sceneParams.WorkspotInstanceId.Id != uint.MaxValue &&
                    sceneParams.WorkspotInstanceId.Id != 0)
                {
                    // Try to resolve instance ID to actual workspot file path
                    string workspotPath = NodeProperties.GetWorkspotPath(sceneParams.WorkspotInstanceId.Id, sceneResource);
                    if (!string.IsNullOrEmpty(workspotPath))
                    {
                        resolvedWorkspotInfo = $"[Instance: {sceneParams.WorkspotInstanceId.Id}] {workspotPath}";
                    }
                }
            }
        }
        
        PopulateWorkspotDetailsInto(workspotNode, details, resolvedWorkspotInfo);
    }


    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Success", Enums.questSocketType.Output);
        //CreateSocket("Work Started", Enums.questSocketType.Output); TODO[Graph]
    }
}