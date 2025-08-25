using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;

public class scnEndNodeWrapper : BaseSceneViewModel<scnEndNode>
{
    private readonly scnExitPoint _scnExitPoint;

    public string Name
    {
        get => _scnExitPoint.Name.GetResolvedText()!;
        set 
        {
            if (_scnExitPoint.Name.GetResolvedText() != value)
            {
                _scnExitPoint.Name = value;
                OnPropertyChanged(nameof(Name));
                
                // Mark document as dirty when name changes
                if (!IsInitialLoad)
                {
                    DocumentViewModel?.SetIsDirty(true);
                }
                
                // Trigger property panel refresh for exit points since the name changed
                TriggerExitPointRefresh();
            }
        }
    }
    
    private void TriggerExitPointRefresh()
    {
        // Find the main graph and trigger a selective refresh
        if (DocumentViewModel != null)
        {
            var sceneGraphTab = DocumentViewModel.TabItemViewModels
                .OfType<SceneGraphViewModel>()
                .FirstOrDefault();
                
            if (sceneGraphTab?.MainGraph is RedGraph mainGraph)
            {
                mainGraph.RefreshSpecificProperties("exitPoints");
            }
        }
    }

    public Enums.scnEndNodeNsType Type
    {
        get => _castedData.Type;
        set => _castedData.Type = value;
    }

    public IEnumerable<Enums.scnEndNodeNsType> Types => Enum.GetValues(typeof(Enums.scnEndNodeNsType)).Cast<Enums.scnEndNodeNsType>();

    public scnEndNodeWrapper(scnEndNode scnEndNode, scnExitPoint exitPoint) : base(scnEndNode)
    {
        InputSocketNames.Add(0, "In");

        _scnExitPoint = exitPoint;
    }
}
