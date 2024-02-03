using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;

public class scnXorNodeWrapper : BaseSceneViewModel<scnXorNode>
{
    public scnXorNodeWrapper(scnXorNode scnXorNode) : base(scnXorNode)
    {
        InputSocketNames.Add(0, "In");
        InputSocketNames.Add(1, "Cancel");
        
        OutputSocketNames.Add(0, "Out");
    }
}