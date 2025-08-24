using System.ComponentModel;
using System.Linq;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;

public class scnStartNodeWrapper : BaseSceneViewModel<scnStartNode>
{
    private readonly scnEntryPoint _scnEntryPoint;

    public string Name
    {
        get => _scnEntryPoint.Name.GetResolvedText()!;
        set 
        {
            if (_scnEntryPoint.Name.GetResolvedText() != value)
            {
                _scnEntryPoint.Name = value;
                OnPropertyChanged(nameof(Name));
                
                // Mark document as dirty when name changes
                if (!IsInitialLoad)
                {
                    DocumentViewModel?.SetIsDirty(true);
                }
                
                // Trigger property panel refresh for entry points since the name changed
                TriggerEntryPointRefresh();
            }
        }
    }
    
    private void TriggerEntryPointRefresh()
    {
        // Find the main graph and trigger a selective refresh
        if (DocumentViewModel != null)
        {
            var sceneGraphTab = DocumentViewModel.TabItemViewModels
                .OfType<SceneGraphViewModel>()
                .FirstOrDefault();
                
            if (sceneGraphTab?.MainGraph is RedGraph mainGraph)
            {
                mainGraph.RefreshSpecificProperties("entryPoints");
            }
        }
    }

    public scnStartNodeWrapper(scnStartNode scnSceneGraphNode, scnEntryPoint entryPoint) : base(scnSceneGraphNode)
    {
        OutputSocketNames.Add(0, "Out");

        _scnEntryPoint = entryPoint;
    }
}
