using System.Windows.Controls;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.GraphEditor;

namespace WolvenKit.Views.Documents;

public partial class BehaviorGraphView : UserControl
{
    public BehaviorGraphView()
    {
        InitializeComponent();
        BehaviorGraphEditor.CanvasRealized += OnEditorCanvasRealized;
    }

    /// <summary>
    /// Drops the loading overlay once the graph is finished building.
    /// </summary>
    /// <remarks>
    /// The overlay prevents the user clicking nodes mid-realization.
    /// </remarks>
    private void OnEditorCanvasRealized(object sender, RedGraph graph)
    {
        if (DataContext is BehaviorGraphViewModel viewModel)
        {
            viewModel.SetGraphLoaded();
        }
    }
}
