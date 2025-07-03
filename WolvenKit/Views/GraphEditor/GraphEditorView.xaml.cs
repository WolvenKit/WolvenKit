using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using Nodify;
using ReactiveUI;
using Splat;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.GraphEditor;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Views.Templates;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest.Internal;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;

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

        view.Dispatcher.BeginInvoke(new Action(() =>
        {
            UpdateView(view);
            view.Source?.ArrangeNodes();
        }), DispatcherPriority.ContextIdle);
    }

    private static void UpdateView(GraphEditorView view)
    {
        if (view.Source is null) // graph editor hasn't been initialized yet
        {
            return;
        }
        view.Source.Editor = view.Editor;
        view.Source.GraphStateLoad();
        //view.Editor.FitToScreen();
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
        set 
        { 
            if (SetField(ref _selectedNode, value))
            {
                // Update the global selection service
                NodeSelectionService.Instance.SelectedNode = value;
            }
        }
    }

    private ObservableCollection<object> _selectedNodes = new();

    public ObservableCollection<object> SelectedNodes
    {
        get => _selectedNodes;
        set => SetField(ref _selectedNodes, value);
    }

    public System.Windows.Point ViewportLocation { get; set; }

    private readonly AppViewModel _appViewModel;

    public GraphEditorView()
    {
        InitializeComponent();

        _appViewModel = Locator.Current.GetService<AppViewModel>();

        Observable.FromEventPattern<RoutedEventHandler, RoutedEventArgs>(
            handler => Editor.ViewportUpdated += handler,
            handler => Editor.ViewportUpdated -= handler)
            .Throttle(TimeSpan.FromSeconds(1))
            .ObserveOn(RxApp.MainThreadScheduler)
            .Subscribe(x =>
            {
                ViewportUpdated();
            });
    }

    private void ViewportUpdated()
    {
        if (Source == null)
        {
            return;
        }

        Source.GraphStateSave();
    }

    private void ArrangeNodes()
    {
        if (Source == null)
        {
            return;
        }

        UpdateLayout();
        Source.ArrangeNodes();
        Source.GraphStateSave();
        Source.CenterOnSelectedNodes(SelectedNodes);
    }

    private void Editor_OnContextMenuOpening(object sender, ContextMenuEventArgs e)
    {
        if (sender is not NodifyEditor nodifyEditor || Source == null)
        {
            return;
        }

        nodifyEditor.ContextMenu ??= new ContextMenu();
        nodifyEditor.ContextMenu.Items.Clear();

        // Get the mouse position in graph coordinates for placing new nodes at cursor location
        var mousePosition = GetMousePositionInGraph(nodifyEditor);

        if (Source.GraphType == RedGraphType.Scene)
        {
            var nodeTypes = Source.GetSceneNodeTypes();
            var types = nodeTypes
                .Select(x => new TypeEntry(GetCleanTypeName(x.Name), "", x))
                .OrderBy(x => x.Name)
                .ToList();

            var addMenu = CreateAddMenuItem();

            addMenu.Items.Add(CreateMenuItem("Open Dialog ...", "FolderOpen", "WolvenKitYellow", async () =>
            {
                await _appViewModel.SetActiveDialog(new TypeSelectorDialogViewModel(types)
                {
                    DialogHandler = model =>
                    {
                        _appViewModel.CloseDialogCommand.Execute(null);
                        if (model is TypeSelectorDialogViewModel { SelectedEntry.UserData: Type selectedType })
                        {
                            var nodeId = Source.CreateSceneNode(selectedType, mousePosition);
                            SelectNodeById(nodeId);
                        }
                    }
                });
            }));

            addMenu.Items.Add(new Separator());

            foreach (var nodeType in nodeTypes)
            {
                addMenu.Items.Add(CreateMenuItem(GetCleanTypeName(nodeType.Name), () => 
                {
                    var nodeId = Source.CreateSceneNode(nodeType, mousePosition);
                    SelectNodeById(nodeId);
                }));
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

            var addMenu = CreateAddMenuItem();

            addMenu.Items.Add(CreateMenuItem("Open Dialog ...", "FolderOpen", "WolvenKitYellow", async () =>
            {
                await _appViewModel.SetActiveDialog(new TypeSelectorDialogViewModel(types)
                {
                    DialogHandler = model =>
                    {
                        _appViewModel.CloseDialogCommand.Execute(null);
                        if (model is TypeSelectorDialogViewModel { SelectedEntry.UserData: Type selectedType })
                        {
                            Source.CreateQuestNode(selectedType, mousePosition);
                        }
                    }
                });
            }));

            addMenu.Items.Add(new Separator());

            foreach (var nodeType in nodeTypes)
            {
                addMenu.Items.Add(CreateMenuItem(GetCleanTypeName(nodeType.Name), () => Source.CreateQuestNode(nodeType, mousePosition)));
            }

            nodifyEditor.ContextMenu.Items.Add(addMenu);
        }

        nodifyEditor.ContextMenu.Items.Add(CreateMenuItem("Arrange Items", "ViewDashboard", ArrangeNodes));

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
            node.ContextMenu.Items.Add(CreateMenuItem("Remove Nodes", "Delete", "WolvenKitRed", () => Source.RemoveNodes(SelectedNodes)));
            node.ContextMenu.SetCurrentValue(ContextMenu.IsOpenProperty, true);

            e.Handled = true;
            return;
        }

        if (node.DataContext is IDynamicInputNode dynamicInputNode)
        {
            node.ContextMenu.Items.Add(CreateMenuItem("Add Input", "PlusCircle", () => dynamicInputNode.AddInput()));
            node.ContextMenu.Items.Add(new Separator());
        }

        if (node.DataContext is IDynamicOutputNode dynamicOutputNode)
        {
            // Check if it's a section node for specific labeling
            string addLabel = dynamicOutputNode is scnSectionNodeWrapper ? "Add Event Socket" : "Add Output";
            
            node.ContextMenu.Items.Add(CreateMenuItem(addLabel, "PlusCircle", () => dynamicOutputNode.AddOutput()));
            node.ContextMenu.Items.Add(new Separator());
        }

        if (node.DataContext is scnChoiceNodeWrapper choice)
        {
            node.ContextMenu.Items.Add(CreateMenuItem("Add Choice", "PlusCircle", () => choice.AddChoice()));
            node.ContextMenu.Items.Add(new Separator());
        }

        if (node.DataContext is IGraphProvider graphProvider)
        {
            node.ContextMenu.Items.Add(CreateMenuItem("Recalculate sockets", "Play", "WolvenKitGreen", () => Source.RecalculateSockets(graphProvider)));
            node.ContextMenu.Items.Add(new Separator());
        }

        if (node.DataContext is questSceneNodeDefinitionWrapper sceneNode)
        {
            node.ContextMenu.Items.Add(CreateMenuItem(
                "Add Scene To Project",
                "ArrowLeftCircle",
                "WolvenKitYellow",
                () => sceneNode.AddSceneToProject()));
            node.ContextMenu.Items.Add(new Separator());
        }
        
        node.ContextMenu.Items.Add(CreateMenuItem("Duplicate Node", "ContentDuplicate", "WolvenKitYellow", () => Source.DuplicateNode(nvm)));

        if (Source.GraphType == RedGraphType.Scene && node.DataContext is BaseSceneViewModel sceneViewModel)
        {
            node.ContextMenu.Items.Add(CreateMenuItem(
                "Detach Node",
                "LinkOff",
                "WolvenKitYellow",
                () => DetachNode(sceneViewModel)));
            
            if (!(sceneViewModel is scnStartNodeWrapper || sceneViewModel is scnEndNodeWrapper))
            {
                // Smart delete: if it's already a deletion marker, offer to destroy it completely
                string deleteLabel = sceneViewModel is scnDeletionMarkerNodeWrapper ? "Destroy Deletion Marker" : "Delete Node";
                string deleteIcon = sceneViewModel is scnDeletionMarkerNodeWrapper ? "CloseBoxOutline" : "Delete";
                
                node.ContextMenu.Items.Add(CreateMenuItem(
                    deleteLabel,
                    deleteIcon,
                    "WolvenKitRed",
                    () => {
                        if (sceneViewModel is scnDeletionMarkerNodeWrapper)
                        {
                            // Hard delete for deletion markers
                            Source.RemoveNode(sceneViewModel);
                        }
                        else
                        {
                            // Soft delete for normal nodes
                            Source.ReplaceNodeWithDeletionMarker(sceneViewModel);
                        }
                    }));
            }
            
            node.ContextMenu.Items.Add(new Separator());
        }

                node.ContextMenu.Items.Add(CreateMenuItem("Destroy Node", "CloseBoxOutline", "WolvenKitRed", () => Source.RemoveNode(nvm)));

        // Add deletion markers info for scene graphs for now
        if (Source.GraphType == RedGraphType.Scene)
        {
            node.ContextMenu.Items.Add(new Separator());
            
            // Create help item using XAML-defined style
            var infoItem = new MenuItem
            {
                Header = "What do these mean?",
                Style = (Style)Resources["HelpMenuItemStyle"]
            };
            
            infoItem.Click += (_, _) => {
                try
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("https://wiki.redmodding.org/wolvenkit/wolvenkit-app/editor/scene-editor") { UseShellExecute = true });
                }
                catch (Exception)
                {
                    // Silently handle any exceptions when opening the link
                }
            };
            
            node.ContextMenu.Items.Add(infoItem);
        }

        node.ContextMenu.SetCurrentValue(ContextMenu.IsOpenProperty, true);

        e.Handled = true;
    }
    

    private static MenuItem CreateAddMenuItem() => new()
    {
        Header = "Add ...",
        Padding = (Thickness)Application.Current.Resources["WolvenKitMarginTiny"]!,
        Icon = new IconBox
        {
            IconPack = IconPackType.Material,
            Kind = "Plus",
            Margin = (Thickness)Application.Current.Resources["WolvenKitMarginTiny"]!,
            Size = (double)Application.Current.Resources["WolvenKitIconMicro"]!
        }
    };

    private static MenuItem CreateMenuItem(string header, Action click) => CreateMenuItem(header, "Empty", null, click);

    private static MenuItem CreateMenuItem(string header, string iconKind, Action click) => CreateMenuItem(header, iconKind, "", click);

    private static MenuItem CreateMenuItem(string header, string iconKind, string iconColor, Action click)
    {
        var item = new MenuItem
        {
            Header = header,
            Padding = (Thickness)Application.Current.Resources["WolvenKitMarginTiny"]!,
        };

        if (iconKind != null)
        {
            var icon = new IconBox
            {
                IconPack = (iconKind == "Empty") ? IconPackType.Empty : IconPackType.Material,
                Kind = (iconKind == "Empty") ? "" : iconKind,
                Margin = (Thickness)Application.Current.Resources["WolvenKitMarginTiny"]!,
                Size = (double)Application.Current.Resources["WolvenKitIconMicro"]!
            };

            if (iconColor != null)
            {
                icon.Foreground = (Brush)Application.Current.Resources[iconColor] ?? Brushes.White;
            }
            item.Icon = icon;
        }
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

    // Removed ShowSectionOutputPreview - no longer using dialog for add output

    public void Connection_OnRightClick(object sender, MouseButtonEventArgs e)
    {
        if (sender is Connection connection && connection.DataContext is ConnectionViewModel connectionViewModel && Source != null)
        {
            // Clear other selections and select this connection to highlight it
            Editor.SelectedItems.Clear();
            Editor.SelectedItems.Add(connectionViewModel);
            
            // Also set the IsSelected property on the view model for binding
            connectionViewModel.IsSelected = true;
            
            var contextMenu = new ContextMenu();
            
            var deleteMenuItem = CreateMenuItem("Delete Connection", "Delete", "WolvenKitRed", () =>
            {
                if (Source.GraphType == RedGraphType.Quest)
                {
                    if (connectionViewModel is QuestConnectionViewModel questConnection)
                    {
                        Source.RemoveQuestConnectionPublic(questConnection);
                    }
                }
                else if (Source.GraphType == RedGraphType.Scene)
                {
                    if (connectionViewModel is SceneConnectionViewModel sceneConnection)
                    {
                        Source.RemoveSceneConnectionPublic(sceneConnection);
                    }
                }
                
                Editor.SelectedItems.Clear();
                connectionViewModel.IsSelected = false;
            });
            
            contextMenu.Items.Add(deleteMenuItem);
            
            connection.ContextMenu = contextMenu;
            contextMenu.SetCurrentValue(ContextMenu.IsOpenProperty, true);
            
            e.Handled = true;
        }
    }



    /// <summary>
    /// Detaches a node by removing all of its input and output connections
    /// </summary>
    private void DetachNode(BaseSceneViewModel node)
    {
        if (Source == null) return;
        
        // Create a list to store all connections that need to be removed
        var connectionsToRemove = new List<SceneConnectionViewModel>();
        
        // Find all connections where this node is the source (output connections)
        foreach (var connection in Source.Connections.OfType<SceneConnectionViewModel>())
        {
            if (connection.Source.OwnerId == node.UniqueId)
            {
                connectionsToRemove.Add(connection);
            }
        }
        
        // Find all connections where this node is the target (input connections)
        foreach (var connection in Source.Connections.OfType<SceneConnectionViewModel>())
        {
            if (connection.Target.OwnerId == node.UniqueId)
            {
                connectionsToRemove.Add(connection);
            }
        }
        
        // Remove all the connections in the list
        foreach (var connection in connectionsToRemove)
        {
            Source.RemoveSceneConnectionPublic(connection);
        }
    }

    /// <summary>
    /// Selects a node by its ID
    /// </summary>
    private void SelectNodeById(uint nodeId)
    {
        if (Source?.Nodes == null || Editor == null) return;

        // Find the node with the specified ID
        var targetNode = Source.Nodes.FirstOrDefault(n => n.UniqueId == nodeId);

        if (targetNode != null)
        {
            // Clear current selection
            Editor.SelectedItems.Clear();
            
            // Select the target node
            Editor.SelectedItems.Add(targetNode);
            
            // Update the NodeSelectionService
            NodeSelectionService.Instance.SelectedNode = targetNode;
        }
    }

    /// <summary>
    /// Get the mouse position in graph coordinates for placing new nodes
    /// </summary>
    private System.Windows.Point GetMousePositionInGraph(NodifyEditor editor)
    {
        try
        {
            // Get mouse position relative to the editor
            var mousePos = Mouse.GetPosition(editor);
            
            // Convert to graph coordinates by accounting for viewport offset and zoom
            var graphX = (mousePos.X / editor.ViewportZoom) + editor.ViewportLocation.X;
            var graphY = (mousePos.Y / editor.ViewportZoom) + editor.ViewportLocation.Y;
            
            return new System.Windows.Point(graphX, graphY);
        }
        catch
        {
            // Fallback to viewport center if mouse position can't be determined
            var viewport = editor.ViewportLocation;
            var size = editor.ViewportSize;
            return new System.Windows.Point(
                viewport.X + size.Width / 2,
                viewport.Y + size.Height / 2
            );
        }
    }
}
