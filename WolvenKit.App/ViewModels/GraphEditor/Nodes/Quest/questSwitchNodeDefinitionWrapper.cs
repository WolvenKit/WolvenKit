using WolvenKit.App.Extensions;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest.Internal;
using WolvenKit.RED4.Types;
using System.Linq;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questSwitchNodeDefinitionWrapper : questDisableableNodeDefinitionWrapper<questSwitchNodeDefinition>
{
    public questSwitchNodeDefinitionWrapper(questSwitchNodeDefinition questSwitchNodeDefinition) : base(questSwitchNodeDefinition)
    {
        Details.AddRange(NodeProperties.GetPropertiesFor(questSwitchNodeDefinition));
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Otherwise", Enums.questSocketType.Output);

        // Create output sockets for existing conditions with Case + socketId naming
        foreach (var conditionItem in _castedData.Conditions)
        {
            var socketName = $"Case{conditionItem.SocketId}";
            CreateSocket(socketName, Enums.questSocketType.Output);
        }
    }

    /// <summary>
    /// Adds a new condition to the switch node and creates a corresponding output socket
    /// </summary>
    public void AddCondition()
    {
        // Find the next available socket ID (starting from 2, since "Otherwise" would be 1)
        var existingSocketIds = _castedData.Conditions.Select(c => c.SocketId).ToList();
        uint nextSocketId = 2;
        while (existingSocketIds.Contains(nextSocketId))
        {
            nextSocketId++;
        }

        // Create a new condition item with a default condition
        var newConditionItem = new questConditionItem
        {
            SocketId = nextSocketId,
            Condition = new CHandle<questIBaseCondition>() // Empty condition that can be configured later
        };

        // Add the condition to the switch node
        _castedData.Conditions.Add(newConditionItem);

        // Clear all existing sockets and recreate them to include the new condition socket
        _castedData.Sockets.Clear();
        CreateDefaultSockets();

        // Regenerate sockets to reflect the changes in the UI
        GenerateSockets();

        // Refresh details to show the new condition
        RefreshDetails();

        //  Update property panel and graph editor without regenerating connectors
        TriggerPropertyChanged(nameof(Output));
        OnPropertyChanged(nameof(Data));

        // Mark document as dirty
        DocumentViewModel?.SetIsDirty(true);
    }
}
