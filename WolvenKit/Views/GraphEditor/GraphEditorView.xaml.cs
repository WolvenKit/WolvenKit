using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using System.Windows.Threading;
using Nodify;
using WolvenKit.App.ViewModels.GraphEditor;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;

namespace WolvenKit.Views.GraphEditor;
/// <summary>
/// Interaktionslogik für GraphEditorView.xaml
/// </summary>
public partial class GraphEditorView : UserControl
{
    public static readonly DependencyProperty SourceProperty = DependencyProperty.Register(
        nameof(Source), typeof(RedGraph), typeof(GraphEditorView), new PropertyMetadata(null, OnSourceChanged));

    private static void OnSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is not GraphEditorView { Source: not null } view)
        {
            return;
        }

        view.Dispatcher.BeginInvoke(new Action(() => UpdateView(view)), DispatcherPriority.ContextIdle);
    }

    private static void UpdateView(GraphEditorView view)
    {
        view.Source.ArrangeNodes();
        view.Editor.FitToScreen();
    }

    public RedGraph Source
    {
        get => (RedGraph)GetValue(SourceProperty);
        set => SetValue(SourceProperty, value);
    }

    private NodeViewModel _selectedNode;

    public NodeViewModel SelectedNode
    {
        get => _selectedNode;
        set => SetField(ref _selectedNode, value);
    }

    private ObservableCollection<object> _selectedNodes = new();

    public ObservableCollection<object> SelectedNodes
    {
        get => _selectedNodes;
        set => SetField(ref _selectedNodes, value);
    }

    public Point ViewportLocation { get; set; }

    public GraphEditorView()
    {
        InitializeComponent();
    }

    private void MenuItem_OnClick(object sender, RoutedEventArgs e) => ArrangeNodes();

    private void ArrangeNodes()
    {
        if (Source == null)
        {
            return;
        }

        UpdateLayout();
        Source.ArrangeNodes();
    }

    private void Editor_OnContextMenuOpening(object sender, ContextMenuEventArgs e)
    {
        if (sender is not NodifyEditor nodifyEditor || Source == null)
        {
            return;
        }

        nodifyEditor.ContextMenu ??= new ContextMenu();
        nodifyEditor.ContextMenu.Items.Clear();

        if (Source.GraphType == RedGraphType.Scene)
        {
            var addMenu = new MenuItem { Header = "Add..." };

            var nodeTypes = Source.GetSceneNodeTypes();
            foreach (var nodeType in nodeTypes)
            {
                addMenu.Items.Add(CreateMenuItem(nodeType.Name[3..^4], () => Source.CreateSceneNode(nodeType, ViewportLocation)));
            }

            nodifyEditor.ContextMenu.Items.Add(addMenu);
        }

        if (Source.GraphType == RedGraphType.Quest)
        {
            var addMenu = new MenuItem { Header = "Add..." };

            var nodeTypes = Source.GetQuestNodeTypes();
            foreach (var nodeType in nodeTypes)
            {
                addMenu.Items.Add(CreateMenuItem(nodeType.Name[5..^14], () => Source.CreateQuestNode(nodeType, ViewportLocation)));
            }

            nodifyEditor.ContextMenu.Items.Add(addMenu);
        }

        nodifyEditor.ContextMenu.Items.Add(CreateMenuItem("Arrange Items", ArrangeNodes));

        nodifyEditor.ContextMenu.SetCurrentValue(ContextMenu.IsOpenProperty, true);

        e.Handled = true;
    }

    private void Node_ContextMenuOpening(object sender, ContextMenuEventArgs e)
    {
        if (sender is not Node { DataContext: NodeViewModel nvm } node || Source == null)
        {
            return;
        }

        node.ContextMenu ??= new ContextMenu();

        node.ContextMenu.Items.Clear();

        if (SelectedNodes.Count > 1)
        {
            node.ContextMenu.Items.Add(CreateMenuItem("Remove Nodes", () => Source.RemoveNodes(SelectedNodes)));
            node.ContextMenu.SetCurrentValue(ContextMenu.IsOpenProperty, true);

            e.Handled = true;
            return;
        }

        if (node.DataContext is IDynamicInputNode dynamicInputNode)
        {
            node.ContextMenu.Items.Add(CreateMenuItem("Add Input", () => dynamicInputNode.AddInput()));
            node.ContextMenu.Items.Add(new Separator());
        }

        if (node.DataContext is IDynamicOutputNode dynamicOutputNode)
        {
            node.ContextMenu.Items.Add(CreateMenuItem("Add Output", () => dynamicOutputNode.AddOutput()));
            node.ContextMenu.Items.Add(new Separator());
        }

        if (node.DataContext is scnChoiceNodeWrapper choice)
        {
            node.ContextMenu.Items.Add(CreateMenuItem("Add Choice", () => choice.AddChoice()));
            node.ContextMenu.Items.Add(new Separator());
        }

        if (node.DataContext is questPhaseNodeDefinitionWrapper questPhase)
        {
            node.ContextMenu.Items.Add(CreateMenuItem("Recalculate sockets", () => questPhase.RecalculateSockets()));
            node.ContextMenu.Items.Add(new Separator());
        }

        if (node.DataContext is questSceneNodeDefinitionWrapper sceneNode)
        {
            node.ContextMenu.Items.Add(CreateMenuItem("Add Scene To Project", () => sceneNode.AddSceneToProject()));
            node.ContextMenu.Items.Add(new Separator());
        }

        node.ContextMenu.Items.Add(CreateMenuItem("Remove Node", () => Source.RemoveNode(nvm)));

        node.ContextMenu.SetCurrentValue(ContextMenu.IsOpenProperty, true);

        e.Handled = true;
    }

    private MenuItem CreateMenuItem(string header, Action click)
    {
        var item = new MenuItem { Header = header };
        item.Click += (_, _) => click();
        return item;
    }

    #region INotifyPropertyChanged

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value))
        {
            return false;
        }

        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }

    #endregion
}
