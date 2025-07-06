using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;

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
        OutputSocketNames.Add(0, "Out");

        _scnEntryPoint = entryPoint;
    }
}