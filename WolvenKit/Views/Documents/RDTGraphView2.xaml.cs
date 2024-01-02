using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ReactiveUI;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;
using WolvenKit.App.ViewModels.GraphEditor;
using Syncfusion.Windows.PropertyGrid;
using WolvenKit.Views.GraphEditor;

namespace WolvenKit.Views.Documents;
/// <summary>
/// Interaktionslogik für RDTGraphView2.xaml
/// </summary>
public partial class RDTGraphView2
{
    public RDTGraphView2()
    {
        InitializeComponent();

        KeyDown += OnKeyDown;

        this.WhenActivated(disposables =>
        {
            BuildBreadcrumb();
        });
    }

    private void OnKeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Tab && Editor.SelectedNode != null)
        {
            if (Editor.SelectedNode is IGraphProvider provider)
            {
                ViewModel!.History.Add(provider.Graph);
                Editor.SetCurrentValue(GraphEditorView.SourceProperty, provider.Graph);

                BuildBreadcrumb();
            }

            if (Editor.SelectedNode is questInputNodeDefinitionWrapper input)
            {
                if (ViewModel!.History.Count > 1)
                {
                    ViewModel.History.Remove(ViewModel.History[^1]);
                    Editor.SetCurrentValue(GraphEditorView.SourceProperty, ViewModel.History[^1]);

                    BuildBreadcrumb();
                }
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
            tmp.PreviewMouseDown += BreadcrumbElement_OnPreviewMouseDown;

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
