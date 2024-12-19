

using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ReactiveUI;
using Splat;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.GraphEditor;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;
using WolvenKit.Views.GraphEditor;

namespace WolvenKit.Views.Documents;
/// <summary>
/// Interaktionslogik für RDTGraphView2.xaml
/// </summary>
public partial class RDTGraphView2 : ReactiveUserControl<RDTGraphViewModel2>
{
    public RDTGraphView2()
    {
        InitializeComponent();

        this.WhenActivated(disposables =>
        {
            Disposable.Create(BuildBreadcrumb).DisposeWith(disposables);
            

            //Observable.FromEventPattern<KeyEventHandler, KeyEventArgs>(
            //    handler => KeyDown += handler,
            //    handler => KeyDown -= handler)
            //    .Subscribe(e => OnKeyDown(e.Sender, e.EventArgs))
            //    .DisposeWith(disposables);
        });
    }

    private void Editor_OnNodeDoubleClick(object sender, RoutedEventArgs e) => HandleSubGraph();

    private void OnKeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Tab)
        {
            HandleSubGraph();
        }
    }

    private void HandleSubGraph()
    {
        if (Editor.SelectedNode is IGraphProvider provider)
        {
            var subGraph = provider.Graph;
            if (subGraph == null)
            {
                Locator.Current.GetService<ILoggerService>().Error("SubGraph is not defined!");
                return;
            }

            if (Editor.SelectedNode.Data is questPhaseNodeDefinition ph)
            {
                if (!ph.PhaseResource.IsSet)
                {
                    subGraph.StateParents = Editor.Source.StateParents + "." + ph.Id;
                    subGraph.DocumentViewModel = Editor.Source.DocumentViewModel;
                }
            }

            ViewModel!.History.Add(subGraph);
            Editor.SetCurrentValue(GraphEditorView.SourceProperty, subGraph);

            BuildBreadcrumb();
        }

        if (Editor.SelectedNode is questInputNodeDefinitionWrapper or questOutputNodeDefinitionWrapper)
        {
            if (ViewModel!.History.Count > 1)
            {
                ViewModel.History.Remove(ViewModel.History[^1]);
                Editor.SetCurrentValue(GraphEditorView.SourceProperty, ViewModel.History[^1]);

                BuildBreadcrumb();
            }
        }

        if (Editor.SelectedNode is scnStartNodeWrapper or scnEndNodeWrapper)
        {
            if (ViewModel!.History.Count > 1)
            {
                ViewModel.History.Remove(ViewModel.History[^1]);
                Editor.SetCurrentValue(GraphEditorView.SourceProperty, ViewModel.History[^1]);

                BuildBreadcrumb();
            }
        }
    }

    private void BuildBreadcrumb()
    {
        Breadcrumb.Children.Clear();

        for (var i = 0; i < ViewModel!.History.Count; i++)
        {
            AddNewElement(ViewModel.History[i].Title, ViewModel.History[i]);

            if (i < ViewModel.History.Count - 1)
            {
                AddNewElement(">", null);
            }
        }

        void AddNewElement(string text, RedGraph graph)
        {
            if (Breadcrumb.Children.Count > 0)
            {
                text = " " + text;
            }

            var tmp = new TextBlock { Text = text, Tag = graph };
            //TODO MB tmp.PreviewMouseDown += BreadcrumbElement_OnPreviewMouseDown;

            Breadcrumb.Children.Add(tmp);
        }
    }

    private void BreadcrumbElement_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
    {
        if (sender is not TextBlock { Tag: RedGraph graph } block)
        {
            return;
        }

        if (ViewModel!.History.Count == 1)
        {
            return;
        }

        if (block.Text.Trim() == ">")
        {
            return;
        }

        Editor.SetCurrentValue(GraphEditorView.SourceProperty, graph);

        for (var i = ViewModel.History.Count - 1; i >= 0; i--)
        {
            if (ReferenceEquals(ViewModel.History[i], graph))
            {
                break;
            }
            ViewModel.History.RemoveAt(i);
        }

        BuildBreadcrumb();
    }
}
