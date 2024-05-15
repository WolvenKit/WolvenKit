using System;
using WolvenKit.App.Extensions;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest.Internal;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;

public class questRandomizerNodeDefinitionWrapper : questDisableableNodeDefinitionWrapper<questRandomizerNodeDefinition>, IDynamicOutputNode
{
    public questRandomizerNodeDefinitionWrapper(questRandomizerNodeDefinition questRandomizerNodeDefinition) : base(questRandomizerNodeDefinition)
    {
        //Title = $"{Title} [{questRandomizerNodeDefinition.Id}]";
        //Details.Add("Type", questRandomizerNodeDefinition.Mode.ToEnumString());

        Details.AddRange(NodeProperties.GetPropertiesFor(questRandomizerNodeDefinition));
    }

    internal override void GenerateSockets()
    {
        var total = 0;
        foreach (var weight in _castedData.OutputWeights)
        {
            total += weight;
        }

        var index = 0;
        foreach (var socketHandle in _castedData.Sockets)
        {
            if (socketHandle.Chunk is questSocketDefinition socketDefinition)
            {
                var name = socketDefinition.Name.GetResolvedText()!;

                if (socketDefinition.Type == Enums.questSocketType.Input ||
                    socketDefinition.Type == Enums.questSocketType.CutDestination)
                {
                    Input.Add(new QuestInputConnectorViewModel(name, name, UniqueId, socketDefinition));
                }

                if (socketDefinition.Type == Enums.questSocketType.Output ||
                    socketDefinition.Type == Enums.questSocketType.CutSource)
                {
                    var chance = (float)_castedData.OutputWeights[index++] / total * 100;

                    Output.Add(new QuestOutputConnectorViewModel(name, $"[{chance:0.00}%] {name}", UniqueId, socketDefinition));
                }
            }
        }
    }

    internal override void CreateDefaultSockets()
    {
        CreateSocket("CutDestination", Enums.questSocketType.CutDestination);
        CreateSocket("In", Enums.questSocketType.Input);
        CreateSocket("Out1", Enums.questSocketType.Output);
        CreateSocket("Out2", Enums.questSocketType.Output);
    }

    public BaseConnectorViewModel AddOutput()
    {
        var cnt = 1;
        foreach (var handle in _castedData.Sockets)
        {
            if (handle.Chunk is not questSocketDefinition socketDefinition)
            {
                throw new Exception();
            }

            if (socketDefinition.Type == Enums.questSocketType.Output)
            {
                cnt++;
            }
        }

        var socket = CreateSocket($"Out{cnt}", Enums.questSocketType.Output);
        var connector = new QuestOutputConnectorViewModel($"Out{cnt}", $"Out{cnt}", UniqueId, socket);
        
        Output.Add(connector);
        _castedData.OutputWeights.Add(0);

        return connector;
    }

    public void RemoveOutput() => throw new System.NotImplementedException();
}