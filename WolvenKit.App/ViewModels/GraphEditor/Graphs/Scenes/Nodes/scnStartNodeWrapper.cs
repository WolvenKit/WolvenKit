using WolvenKit.App.ViewModels.GraphEditor.Scenes.Nodes.Internal;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Scenes.Nodes;

public class scnStartNodeWrapper : BaseSceneViewModel<scnStartNode>
{
    private readonly scnEntryPoint _scnEntryPoint;

    public string Name
    {
        get => _scnEntryPoint.Name.GetResolvedText()!;
        set => _scnEntryPoint.Name = value;
    }

    public scnStartNodeWrapper(scnStartNode scnSceneGraphNode, scnEntryPoint entryPoint) : base(scnSceneGraphNode)
    {
        _scnEntryPoint = entryPoint;
    }

    internal override void GenerateSockets()
    {
        for (var i = 0; i < _castedData.OutputSockets.Count; i++)
        {
            Output.Add(new SceneOutputConnectorViewModel($"Out{i}", $"Out{i}", UniqueId, _castedData.OutputSockets[i]));
        }
    }
}