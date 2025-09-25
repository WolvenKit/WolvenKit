using System.Collections.Generic;
using WolvenKit.App.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questTeleportPuppetNodeDefinitionWrapper : questAICommandNodeBaseWrapper<questTeleportPuppetNodeDefinition>
{
    public questTeleportPuppetNodeDefinitionWrapper(questTeleportPuppetNodeDefinition questAICommandNodeBase) : base(questAICommandNodeBase)
    {
        PopulateTeleportDetails();
    }

    public override void RefreshDetails()
    {
        PopulateTeleportDetails();
        UpdateTitle();
        OnPropertyChanged(nameof(Title));
        OnPropertyChanged(nameof(IsPlayerNode));
    }

    private void PopulateTeleportDetails()
    {
        var tempDetails = new Dictionary<string, string>();
        PopulateTeleportDetailsInto(_castedData, tempDetails);
        Details = tempDetails;
    }

    public static void PopulateTeleportDetailsInto(questTeleportPuppetNodeDefinition teleportNode, Dictionary<string, string> details)
    {
        string entity = "Entity";
        bool isPlayer = false;
        
        if (teleportNode?.EntityReference?.Chunk != null)
        {
            var entityRef = teleportNode.EntityReference.Chunk;
            if (entityRef.RefLocalPlayer == true)
            {
                entity = "Player";
                isPlayer = true;
            }
            else if (entityRef.EntityReference != null)
            {
                string parsedEntity = NodeProperties.ParseGameEntityReference(entityRef.EntityReference);
                if (parsedEntity != "-")
                {
                    entity = parsedEntity;
                }
            }
            else if (entityRef.MainPlayerObject == true)
            {
                entity = "Main Player Object";
                isPlayer = true;
            }
        }

        string destination = "Unknown";
        string offsetInfo = "";
        
        if (teleportNode?.Params?.Chunk != null)
        {
            var teleportParams = teleportNode.Params.Chunk;
            
            if (teleportParams.DestinationRef?.Chunk != null)
            {
                var destUniRef = teleportParams.DestinationRef.Chunk;
                string destRef = "";
                
                if (destUniRef.EntityReference != null)
                {
                    destRef = NodeProperties.ParseGameEntityReference(destUniRef.EntityReference);
                }
                
                if (destRef == "-" || string.IsNullOrEmpty(destRef))
                {
                    if (destUniRef.RefLocalPlayer == true)
                    {
                        destRef = "Player";
                    }
                    else if (destUniRef.MainPlayerObject == true)
                    {
                        destRef = "Main Player Object";
                    }
                }
                
                if (!string.IsNullOrEmpty(destRef) && destRef != "-")
                {
                    destination = destRef;
                }
            }
            
            if (teleportParams.DestinationOffset != null)
            {
                var offset = teleportParams.DestinationOffset;
                if (offset.X != 0 || offset.Y != 0 || offset.Z != 0)
                {
                    offsetInfo = $"Offset ({offset.X:F1}, {offset.Y:F1}, {offset.Z:F1})";
                    
                    if (destination == "Unknown")
                    {
                        destination = offsetInfo;
                        offsetInfo = "";
                    }
                }
            }
        }

        details["Command"] = $"Teleport {entity} to {destination}";
        details["Entity"] = entity;
        details["Destination"] = destination;
        
        if (!string.IsNullOrEmpty(offsetInfo))
        {
            details["Destination Offset"] = offsetInfo;
        }

        if (teleportNode?.Params?.Chunk != null)
        {
            var teleportParams = teleportNode.Params.Chunk;
            
            details["Heal At Teleport"] = teleportParams.HealAtTeleport ? "Yes" : "No";
            details["Fast Travel"] = teleportParams.UseFastTravelMechanism ? "Yes" : "No";
            details["Navigation Test"] = teleportParams.DoNavTest ? "Yes" : "No";
        }
        else
        {
            details["Heal At Teleport"] = "No";
            details["Fast Travel"] = "No";  
            details["Navigation Test"] = "No";
        }

        details["Look At Action"] = teleportNode?.LookAtAction.ToEnumString() ?? "Reset";

        if (isPlayer && teleportNode?.PlayerLookAt?.Chunk != null && details.Count < 8)
        {
            var playerLookAt = teleportNode.PlayerLookAt.Chunk;
            
            if (playerLookAt.LookAtTarget != null)
            {
                string lookAtTarget = NodeProperties.ParseGameEntityReference(playerLookAt.LookAtTarget);
                if (lookAtTarget != "-")
                {
                    details["Player Look At"] = lookAtTarget;
                }
            }
        }
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Out", Enums.questSocketType.Output);
    }
}