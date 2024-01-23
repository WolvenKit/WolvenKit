using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using Nodify;
using Splat;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.GraphEditor;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;
using WolvenKit.App.ViewModels.Shell;

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

    public static readonly RoutedEvent NodeDoubleClickEvent = EventManager.RegisterRoutedEvent(nameof(NodeDoubleClick), RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(GraphEditorView));

    public event RoutedEventHandler NodeDoubleClick
    {
        add => AddHandler(NodeDoubleClickEvent, value);
        remove => RemoveHandler(NodeDoubleClickEvent, value);
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

    private readonly AppViewModel _appViewModel;

    public GraphEditorView()
    {
        InitializeComponent();

        _appViewModel = Locator.Current.GetService<AppViewModel>();
    }

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
            var nodeTypes = Source.GetSceneNodeTypes();
            var types = nodeTypes
                .Select(x => new TypeEntry(GetCleanTypeName(x.Name), "", x))
                .OrderBy(x => x.Name)
                .ToList();

            var addMenu = new MenuItem { Header = "Add ..." };

            addMenu.Items.Add(CreateMenuItem("Open Dialog ...", async () =>
            {
                await _appViewModel.SetActiveDialog(new TypeSelectorDialogViewModel(types)
                {
                    DialogHandler = model =>
                    {
                        _appViewModel.CloseDialogCommand.Execute(null);
                        if (model is TypeSelectorDialogViewModel { SelectedEntry.UserData: Type selectedType })
                        {
                            Source.CreateSceneNode(selectedType, ViewportLocation);
                        }
                    }
                });
            }));

            addMenu.Items.Add(new Separator());

            foreach (var nodeType in nodeTypes)
            {
                addMenu.Items.Add(CreateMenuItem(GetCleanTypeName(nodeType.Name), () => Source.CreateSceneNode(nodeType, ViewportLocation)));
            }

            nodifyEditor.ContextMenu.Items.Add(addMenu);
        }

        if (Source.GraphType == RedGraphType.Quest)
        {
            var nodeTypes = Source.GetQuestNodeTypes();
            var types = nodeTypes
                .Select(x => new TypeEntry(GetCleanTypeName(x.Name), "", x))
                .OrderBy(x => x.Name)
                .ToList();

            var addMenu = new MenuItem { Header = "Add..." };

            addMenu.Items.Add(CreateMenuItem("Open Dialog ...", async () =>
            {
                await _appViewModel.SetActiveDialog(new TypeSelectorDialogViewModel(types)
                {
                    DialogHandler = model =>
                    {
                        _appViewModel.CloseDialogCommand.Execute(null);
                        if (model is TypeSelectorDialogViewModel { SelectedEntry.UserData: Type selectedType })
                        {
                            Source.CreateQuestNode(selectedType, ViewportLocation);
                        }
                    }
                });
            }));

            addMenu.Items.Add(new Separator());

            foreach (var nodeType in nodeTypes)
            {
                addMenu.Items.Add(CreateMenuItem(GetCleanTypeName(nodeType.Name), () => Source.CreateQuestNode(nodeType, ViewportLocation)));
            }

            nodifyEditor.ContextMenu.Items.Add(addMenu);
        }

        nodifyEditor.ContextMenu.Items.Add(CreateMenuItem("Arrange Items", ArrangeNodes));

        nodifyEditor.ContextMenu.SetCurrentValue(ContextMenu.IsOpenProperty, true);

        e.Handled = true;
    }

    private string GetCleanTypeName(string typeName)
    {
        if (typeName.StartsWith("quest"))
        {
            typeName = typeName[5..];
        }
        else if (typeName.StartsWith("scn"))
        {
            typeName = typeName[3..];
        }

        if (typeName.EndsWith("NodeDefinition"))
        {
            typeName = typeName[..^14];
        }
        else if (typeName.EndsWith("Node"))
        {
            typeName = typeName[..^4];
        }

        return typeName;
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

        if (node.DataContext is IGraphProvider graphProvider)
        {
            node.ContextMenu.Items.Add(CreateMenuItem("Recalculate sockets", () => Source.RecalculateSockets(graphProvider)));
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

    private void Node_OnMouseDoubleClick(object sender, MouseButtonEventArgs e) => RaiseEvent(new RoutedEventArgs(NodeDoubleClickEvent));
}
