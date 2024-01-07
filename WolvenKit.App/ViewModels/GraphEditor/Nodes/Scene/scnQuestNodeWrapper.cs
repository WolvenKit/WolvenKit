using System.ComponentModel;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;

public class scnQuestNodeWrapper : BaseSceneViewModel<scnQuestNode>
{
    public scnQuestNodeWrapper(scnQuestNode scnSceneGraphNode) : base(scnSceneGraphNode)
    {
        if (_castedData.QuestNode != null)
        {
            //_castedData.QuestNode.PropertyChanged += QuestNodeOnPropertyChanged;
        }
    }

    internal override void GenerateSockets()
    {
        /*var inSockets = new[] { "CutDestination", "In" };
        for (ushort i = 0; i < inSockets.Length; i++)
        {
            var name = inSockets[i];
            if (_castedData.IsockMappings.Count > i)
            {
                name = _castedData.IsockMappings[i].GetResolvedText()!;
            }

            Input.Add(new SceneInputConnectorViewModel(name, name, UniqueId, i));
        }*/

        for (ushort i = 0; i < _castedData.IsockMappings.Count; i++)
        {
            var name = _castedData.IsockMappings[i].GetResolvedText()!;
            Input.Add(new SceneInputConnectorViewModel(name, name, UniqueId, i));
        }

        for (var i = 0; i < _castedData.OutputSockets.Count; i++)
        {
            var name = $"Out{i}";
            if (_castedData.OsockMappings.Count > i)
            {
                name = _castedData.OsockMappings[i].GetResolvedText()!;
            }

            Output.Add(new SceneOutputConnectorViewModel(name, name, UniqueId, _castedData.OutputSockets[i]));
        }
    }

    protected override void DataOnPropertyChanging(object? sender, PropertyChangingEventArgs e)
    {
        base.DataOnPropertyChanging(sender, e);

        if (e.PropertyName == nameof(scnQuestNode.QuestNode))
        {
            if (_castedData.QuestNode != null)
            {
                //_castedData.QuestNode.PropertyChanged -= QuestNodeOnPropertyChanged;
            }
        }
    }

    protected override void DataOnPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        base.DataOnPropertyChanged(sender, e);

        if (e.PropertyName == nameof(scnQuestNode.QuestNode))
        {
            if (_castedData.QuestNode != null)
            {
                //_castedData.QuestNode.PropertyChanged += QuestNodeOnPropertyChanged;
            }
        }
    }

    private void QuestNodeOnPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (_castedData.QuestNode.Chunk == null || _castedData.QuestNode.Chunk.Id == (ushort)_castedData.NodeId.Id)
        {
            return;
        }

        _castedData.QuestNode.Chunk.Id = (ushort)_castedData.NodeId.Id;
        _castedData.QuestNode.Chunk.Sockets ??= new CArray<CHandle<graphGraphSocketDefinition>>();
        _castedData.QuestNode.Chunk.Sockets.Add(new questSocketDefinition { Name = "CutDestination", Type = Enums.questSocketType.CutDestination });
        _castedData.QuestNode.Chunk.Sockets.Add(new questSocketDefinition { Name = "In", Type = Enums.questSocketType.Input });
        _castedData.QuestNode.Chunk.Sockets.Add(new questSocketDefinition { Name = "Out", Type = Enums.questSocketType.Output });
    }
}