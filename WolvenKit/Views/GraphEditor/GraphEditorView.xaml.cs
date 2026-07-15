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
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
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
using WolvenKit.App.ViewModels.GraphEditor.Nodes;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Behavior;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest.Internal;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.GraphEditor;

#nullable enable
public record NodeCreationParams(Type Type, RedTypeTemplateSelectionOption? RedTypeTemplateSelectionOption = null);
#nullable disable
/// <summary>
/// Interaktionslogik für GraphEditorView.xaml
/// </summary>
public partial class GraphEditorView : UserControl
{
    private readonly RedTypeTemplateService _redTypeTemplateService = Locator.Current.GetService<RedTypeTemplateService>();

    private static readonly (string Name, string Color)[] s_commentColorPresets =
    [
        ("Yellow", "#FFFFD400"),
        ("Green", "#FF5BB85B"),
        ("Blue", "#FF3FA7FF"),
        ("Purple", "#FFB77AFF"),
        ("Pink", "#FFFF80C8"),
        ("Red", "#FFFF5C5C"),
        ("Gray", "#FFAAAAAA"),
        ("Orange", "#FFFF9F1C")
    ];

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
            //view.Source?.ArrangeNodes();
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

    private object _selectedItem;

    public object SelectedItem
    {
        get => _selectedItem;
        set
        {
            if (SetField(ref _selectedItem, value))
            {
                SelectedNode = value as NodeViewModel;
            }
        }
    }

    private NodeViewModel _selectedNode;

    public NodeViewModel SelectedNode
    {
        get => _selectedNode;
        set
        {
            var previousNode = _selectedNode;
            if (!SetField(ref _selectedNode, value))
            {
                return;
            }

            if (value is not null || ReferenceEquals(NodeSelectionService.Instance.SelectedNode, previousNode))
            {
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

    internal void PrepareForClose()
    {
        var graph = Source;

        SelectedNode = null;
        SelectedNodes.Clear();

        if (graph?.Editor == Editor)
        {
            graph.GraphStateSave();
            graph.Editor = null;
        }

        SetCurrentValue(SourceProperty, null);
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
        Source.GraphCommentStateSave();
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

        if (Source.GraphType is RedGraphType.Quest or RedGraphType.Scene)
        {
            nodifyEditor.ContextMenu.Items.Add(CreateNodeMenu(mousePosition));
        }

        if (Source.GraphType == RedGraphType.Behavior && Source.CanCreateBehaviorRoot())
        {
            var addMenu = CreateAddMenuItem();
            AddBehaviorNodeCreationItems(addMenu, type =>
            {
                var nodeId = Source.CreateBehaviorRoot(type.Type, mousePosition, type.RedTypeTemplateSelectionOption);
                SelectNodeById(nodeId);
            });

            nodifyEditor.ContextMenu.Items.Add(addMenu);
        }

        if (Source.GraphType is RedGraphType.Quest or RedGraphType.Scene)
        {
            var hasNodeSelection = SelectedNodes.OfType<NodeViewModel>().Any();
            nodifyEditor.ContextMenu.Items.Add(CreateMenuItem(
                hasNodeSelection ? "Add Comment Around Selection" : "Add Comment",
                "CommentTextOutline",
                () => Source.AddComment(mousePosition, SelectedNodes)));
        }

        nodifyEditor.ContextMenu.Items.Add(CreateMenuItem("Arrange Items", "ViewDashboard", ArrangeNodes));

        nodifyEditor.ContextMenu.Items.Add(CreateMenuItem("Hide/unhide sockets", "Eye", ToggleAllSockets));

        // Add paste option if clipboard has compatible data
        if (GraphClipboardManager.CanPaste(Source.GraphType))
        {
            nodifyEditor.ContextMenu.Items.Add(new Separator());
            nodifyEditor.ContextMenu.Items.Add(CreateMenuItem("Paste Node", "ContentPaste", "WolvenKitGreen", () =>
            {
                var copiedData = GraphClipboardManager.GetCopiedData();
                if (copiedData != null)
                {
                    Source.PasteNode(copiedData, mousePosition);
                }
            }));
        }

        nodifyEditor.ContextMenu.SetCurrentValue(ContextMenu.IsOpenProperty, true);

        e.Handled = true;
    }

    private void ToggleAllSockets()
    {
        if (Source?.Nodes == null)
        {
            return;
        }

        // Determine the new state based on the first node
        var firstNode = Source.Nodes.FirstOrDefault();
        if (firstNode == null)
        {
            return;
        }
        var newState = !firstNode.ShowUnusedSockets;

        // Apply the new state to all nodes
        foreach (var node in Source.Nodes)
        {
            node.ShowUnusedSockets = newState;
        }

        Source.GraphStateSave();
    }

    private void Node_ContextMenuOpening(object sender, ContextMenuEventArgs e)
    {
        if (sender is not Node { DataContext: NodeViewModel nvm } node || Source == null)
        {
            return;
        }

        node.ContextMenu ??= new ContextMenu();

        node.ContextMenu.Items.Clear();

        if (Source.GraphType == RedGraphType.Behavior)
        {
            if (nvm is BehaviorNodeViewModel behaviorNode && Source.CanAddBehaviorChild(behaviorNode))
            {
                var addChildMenu = CreateCategoryMenuItem("Add Child");
                AddBehaviorNodeCreationItems(addChildMenu, type =>
                {
                    var nodeId = Source.AddBehaviorChild(behaviorNode, type.Type, type.RedTypeTemplateSelectionOption);
                    SelectNodeById(nodeId);
                });

                node.ContextMenu.Items.Add(addChildMenu);
                node.ContextMenu.Items.Add(new Separator());
            }

            var toggleBehaviorSlotsText = nvm.ShowUnusedSockets ? "Hide Structural Slots" : "Show Structural Slots";
            node.ContextMenu.Items.Add(CreateMenuItem(toggleBehaviorSlotsText, "Eye", "WolvenKitYellow", () =>
            {
                nvm.ShowUnusedSockets = !nvm.ShowUnusedSockets;
                Source.GraphStateSave();
            }));

            node.ContextMenu.SetCurrentValue(ContextMenu.IsOpenProperty, true);
            e.Handled = true;
            return;
        }

        var selectedGraphNodes = SelectedNodes.OfType<NodeViewModel>().Cast<object>().ToList();
        if (selectedGraphNodes.Count > 1)
        {
            node.ContextMenu.Items.Add(CreateMenuItem("Destroy Nodes", "CloseBoxOutline", "WolvenKitRed", () => Source.RemoveNodes(selectedGraphNodes)));
            if (Source.GraphType == RedGraphType.Quest)
            {
                node.ContextMenu.Items.Add(CreateMenuItem("Convert to Phase", "FolderOutline", "WolvenKitRed", () => Source.CreatePhaseFromSelection(selectedGraphNodes)));
            }
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

        if (node.DataContext is questSwitchNodeDefinitionWrapper switchNode)
        {
            node.ContextMenu.Items.Add(CreateMenuItem("Add Case", "PlusCircle", () => switchNode.AddCondition()));
            node.ContextMenu.Items.Add(new Separator());
        }

        if (node.DataContext is IGraphProvider graphProvider)
        {
            node.ContextMenu.Items.Add(CreateMenuItem("Recalculate sockets", "Play", "WolvenKitGreen", () => Source.RecalculateSockets(graphProvider)));
            node.ContextMenu.Items.Add(new Separator());
        }

        if (node.DataContext is questPhaseNodeDefinitionWrapper phaseNode)
        {
            node.ContextMenu.Items.Add(CreateMenuItem("Unpack phase", "PackageUp", "WolvenKitRed", () => Source.UnpackPhase(phaseNode)));
            node.ContextMenu.Items.Add(new Separator());
        }

        var toggleSocketsText = nvm.ShowUnusedSockets ? "Hide Unused Sockets" : "Show Unused Sockets";
        node.ContextMenu.Items.Add(CreateMenuItem(toggleSocketsText, "Eye", "WolvenKitYellow",() =>
        {
            nvm.ShowUnusedSockets = !nvm.ShowUnusedSockets;
            Source.GraphStateSave();
        }));

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
        node.ContextMenu.Items.Add(CreateMenuItem("Copy Node", "ContentCopy", "WolvenKitYellow", () => GraphClipboardManager.CopyNode(nvm, Source.GraphType)));

        if (Source.GraphType == RedGraphType.Scene && node.DataContext is BaseSceneViewModel sceneViewModel)
        {
            node.ContextMenu.Items.Add(CreateMenuItem(
                "Detach Node",
                "LinkOff",
                "WolvenKitYellow",
                () => DetachNode(sceneViewModel)));

            if (!(sceneViewModel is scnStartNodeWrapper || sceneViewModel is scnEndNodeWrapper))
            {
                // Check if this node type should use a deletion marker
                bool shouldUseDeletionMarker = ShouldSceneNodeUseDeletionMarker(sceneViewModel);

                if (sceneViewModel is scnDeletionMarkerNodeWrapper)
                {
                    // Deletion markers can always be destroyed
                    node.ContextMenu.Items.Add(CreateMenuItem(
                        "Destroy Deletion Marker",
                        "CloseBoxOutline",
                        "WolvenKitRed",
                        () => Source.RemoveNode(sceneViewModel)));
                }
                else if (shouldUseDeletionMarker)
                {
                    // Critical scene nodes: show both Delete (soft) and Destroy (hard)
                    node.ContextMenu.Items.Add(CreateMenuItem(
                        "Delete Node",
                        "Delete",
                        "WolvenKitRed",
                        () => Source.ReplaceNodeWithDeletionMarker(sceneViewModel)));

                    node.ContextMenu.Items.Add(CreateMenuItem(
                        "Destroy Node",
                        "CloseBoxOutline",
                        "WolvenKitRed",
                        () => Source.RemoveNode(sceneViewModel)));
                }
                else
                {
                    // Non-critical scene nodes: only show Destroy
                    node.ContextMenu.Items.Add(CreateMenuItem(
                        "Destroy Node",
                        "CloseBoxOutline",
                        "WolvenKitRed",
                        () => Source.RemoveNode(sceneViewModel)));
                }
            }

            node.ContextMenu.Items.Add(new Separator());
        }

        if (Source.GraphType == RedGraphType.Quest && node.DataContext is BaseQuestViewModel questViewModel)
        {
            node.ContextMenu.Items.Add(CreateMenuItem(
                "Detach Node",
                "LinkOff",
                "WolvenKitYellow",
                () => DetachQuestNode(questViewModel)));

            if (!(questViewModel is questStartNodeDefinitionWrapper || questViewModel is questEndNodeDefinitionWrapper))
            {
                // Check if this node type should use a deletion marker
                bool shouldUseDeletionMarker = questViewModel.Data is questSignalStoppingNodeDefinition
                    || questViewModel.Data.GetType() == typeof(questSwitchNodeDefinition)
                    || questViewModel.Data.GetType() == typeof(questFlowControlNodeDefinition);

                if (questViewModel is questDeletionMarkerNodeDefinitionWrapper)
                {
                    // Deletion markers can always be destroyed
                    node.ContextMenu.Items.Add(CreateMenuItem(
                        "Destroy Deletion Marker",
                        "CloseBoxOutline",
                        "WolvenKitRed",
                        () => Source.RemoveNode(questViewModel)));
                }
                else if (shouldUseDeletionMarker)
                {
                    // Signal-stopping nodes: show both Delete (soft) and Destroy (hard)
                    node.ContextMenu.Items.Add(CreateMenuItem(
                        "Delete Node",
                        "Delete",
                        "WolvenKitRed",
                        () => Source.ReplaceNodeWithQuestDeletionMarker(questViewModel)));

                    node.ContextMenu.Items.Add(CreateMenuItem(
                        "Destroy Node",
                        "CloseBoxOutline",
                        "WolvenKitRed",
                        () => Source.RemoveNode(questViewModel)));
                }
                else
                {
                    // Non-signal-stopping nodes: only show Destroy
                    node.ContextMenu.Items.Add(CreateMenuItem(
                        "Destroy Node",
                        "CloseBoxOutline",
                        "WolvenKitRed",
                        () => Source.RemoveNode(questViewModel)));
                }
            }

            node.ContextMenu.Items.Add(new Separator());
        }

        // For other node types that aren't scene or quest specific, show destroy option
        if (!(Source.GraphType == RedGraphType.Scene && node.DataContext is BaseSceneViewModel) &&
            !(Source.GraphType == RedGraphType.Quest && node.DataContext is BaseQuestViewModel))
        {
            node.ContextMenu.Items.Add(CreateMenuItem("Destroy Node", "CloseBoxOutline", "WolvenKitRed", () => Source.RemoveNode(nvm)));
        }

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

    public bool AddCommentFromCurrentCursor()
    {
        if (Source?.GraphType is not (RedGraphType.Quest or RedGraphType.Scene))
        {
            return false;
        }

        Source.AddComment(GetMousePositionInGraph(Editor), SelectedNodes);
        return true;
    }

    private void Comment_OnResizeCompleted(object sender, Nodify.Events.ResizeEventArgs e)
    {
        if (sender is not GroupingNode { DataContext: GraphCommentViewModel comment })
        {
            return;
        }

        comment.Width = e.NewSize.Width;
        comment.Height = e.NewSize.Height;
        Source?.GraphCommentStateSave();
    }

    private void CommentText_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        if (e.ClickCount < 2)
        {
            return;
        }

        if (sender is not FrameworkElement { DataContext: GraphCommentViewModel comment })
        {
            return;
        }

        comment.IsEditing = true;
        e.Handled = true;
    }

    private void CommentEditTextBox_OnIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
    {
        if (sender is not TextBox { IsVisible: true } textBox)
        {
            return;
        }

        textBox.Dispatcher.BeginInvoke(new Action(() =>
        {
            textBox.Focus();
            textBox.SelectAll();
        }), DispatcherPriority.Input);
    }

    private void CommentEditTextBox_OnLostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
    {
        EndCommentTextEdit(sender);
    }

    private void CommentEditTextBox_OnPreviewKeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key is not (Key.Enter or Key.Escape))
        {
            return;
        }

        EndCommentTextEdit(sender);
        Keyboard.ClearFocus();
        e.Handled = true;
    }

    private static void EndCommentTextEdit(object sender)
    {
        if (sender is not TextBox { DataContext: GraphCommentViewModel comment } textBox)
        {
            return;
        }

        textBox.GetBindingExpression(TextBox.TextProperty)?.UpdateSource();
        comment.IsEditing = false;
    }

    private void Comment_ContextMenuOpening(object sender, ContextMenuEventArgs e)
    {
        if (sender is not GroupingNode { DataContext: GraphCommentViewModel comment } groupingNode || Source == null)
        {
            return;
        }

        groupingNode.ContextMenu ??= new ContextMenu();
        groupingNode.ContextMenu.Items.Clear();
        groupingNode.ContextMenu.Items.Add(CreateNodeMenu(GetMousePositionInGraph(Editor)));
        groupingNode.ContextMenu.Items.Add(new Separator());
        groupingNode.ContextMenu.Items.Add(CreateCommentColorMenu(comment));
        groupingNode.ContextMenu.Items.Add(CreateMenuItem(
            "Reset Comment Size",
            "Resize",
            "WolvenKitYellow",
            () =>
            {
                comment.ResetSize();
                Source.GraphCommentStateSave();
            }));
        groupingNode.ContextMenu.Items.Add(new Separator());
        groupingNode.ContextMenu.Items.Add(CreateMenuItem(
            "Delete Comment",
            "Delete",
            "WolvenKitRed",
            () => Source.RemoveCommentCommand.Execute(comment)));
        groupingNode.ContextMenu.SetCurrentValue(ContextMenu.IsOpenProperty, true);

        e.Handled = true;
    }

    private MenuItem CreateCommentColorMenu(GraphCommentViewModel comment)
    {
        var item = new MenuItem
        {
            Header = "Change Color",
            Padding = (Thickness)Application.Current.Resources["WolvenKitMarginTiny"]!,
            Icon = new IconBox
            {
                IconPack = IconPackType.Material,
                Kind = "Palette",
                Foreground = (Brush)Application.Current.Resources["WolvenKitYellow"]!,
                Margin = (Thickness)Application.Current.Resources["WolvenKitMarginTiny"]!,
                Size = (double)Application.Current.Resources["WolvenKitIconMicro"]!
            }
        };

        foreach (var (name, color) in s_commentColorPresets)
        {
            var colorItem = new MenuItem
            {
                Header = name,
                IsCheckable = true,
                IsChecked = string.Equals(comment.AccentColor, color, StringComparison.OrdinalIgnoreCase),
                Padding = (Thickness)Application.Current.Resources["WolvenKitMarginTiny"]!,
                Icon = new Rectangle
                {
                    Width = 12,
                    Height = 12,
                    Fill = CreateCommentSwatchBrush(color),
                    Stroke = Brushes.White,
                    StrokeThickness = 0.5,
                    Margin = (Thickness)Application.Current.Resources["WolvenKitMarginTiny"]!
                }
            };

            colorItem.Click += (_, _) => comment.AccentColor = color;
            item.Items.Add(colorItem);
        }

        return item;
    }

    private static Brush CreateCommentSwatchBrush(string colorValue)
    {
        try
        {
            if (ColorConverter.ConvertFromString(colorValue) is Color color)
            {
                var brush = new SolidColorBrush(color);
                brush.Freeze();
                return brush;
            }
        }
        catch (FormatException)
        {
        }

        return Brushes.Gold;
    }


    private static MenuItem CreateAddMenuItem() => new()
    {
        Header = "Add Node",
        Padding = (Thickness)Application.Current.Resources["WolvenKitMarginTiny"]!,
        Icon = new IconBox
        {
            IconPack = IconPackType.Material,
            Kind = "Plus",
            Margin = (Thickness)Application.Current.Resources["WolvenKitMarginTiny"]!,
            Size = (double)Application.Current.Resources["WolvenKitIconMicro"]!
        }
    };

    public Task OpenNodeSelectorAtViewportCenter() => OpenNodeSelector(GetViewportCenter());

    private MenuItem CreateNodeMenu(System.Windows.Point position)
    {
        var menu = CreateAddMenuItem();
        var availableTypes = GetNodeCreationTypes();
        var typeMap = availableTypes
            .Select(entry => entry.Type)
            .GroupBy(type => type.Name)
            .ToDictionary(group => group.Key, group => group.First());

        menu.Items.Add(CreateMenuItem("Search Node ...", "Magnify", "WolvenKitYellow", () =>
        {
            _ = OpenNodeSelector(position);
        }));
        menu.Items.Add(new Separator());

        var commonNodeCount = 0;
        foreach (var typeName in GraphNodeCreationCatalog.CommonTypeNames)
        {
            if (AddNodeToMenu(menu, typeName, typeMap, position, true))
            {
                commonNodeCount++;
            }
        }

        if (commonNodeCount > 0)
        {
            menu.Items.Add(new Separator());
        }

        foreach (var category in GraphNodeCreationCatalog.Categories)
        {
            var categoryMenu = CreateCategoryMenuItem(category.Name);

            if (category.Name == "Debug" && Source.GraphType == RedGraphType.Scene)
            {
                var title = "UIManager (Debug Warning)";
                var emoji = GraphNodeStyling.GetIconForNodeTitle(title);
                categoryMenu.Items.Add(CreateEmojiMenuItem($"{emoji}   {title}", () =>
                {
                    var nodeId = Source.CreateCompositeSceneNode("DebugWarning", typeof(questUIManagerNodeDefinition), position);
                    SelectNodeById(nodeId);
                }, -15));
            }

            AddCatalogNodeTypes(categoryMenu, category.TypeNames, typeMap, position);
            if (categoryMenu.Items.Count > 0)
            {
                menu.Items.Add(categoryMenu);
            }
        }

        return menu;
    }

    private List<(Type Type, string Category)> GetNodeCreationTypes()
    {
        if (Source.GraphType == RedGraphType.Quest)
        {
            return Source.GetQuestNodeTypes()
                .Select(type => (type, "Quest"))
                .ToList();
        }

        if (Source.GraphType == RedGraphType.Scene)
        {
            return Source.GetSceneNodeTypes()
                .Select(type => (type, "Scene"))
                .Concat(Source.GetQuestNodeTypesForScene().Select(type => (type, "Quest")))
                .ToList();
        }

        return [];
    }

    private async Task OpenNodeSelector(System.Windows.Point position)
    {
        if (Source?.GraphType is not (RedGraphType.Quest or RedGraphType.Scene))
        {
            return;
        }

        var graph = Source;
        var types = GetNodeCreationTypes()
            .Select(entry => new TypeEntry(GraphNodeStyling.GetTitleForNodeType(entry.Type), entry.Category, entry.Type))
            .OrderBy(entry => entry.Name)
            .ToList();

        await _appViewModel.SetActiveDialog(new TypeSelectorDialogViewModel(_redTypeTemplateService, types)
        {
            DialogHandler = model =>
            {
                _appViewModel.CloseDialogCommand.Execute(null);
                if (model is not TypeSelectorDialogViewModel { SelectedEntry.UserData: Type selectedType } selector)
                {
                    return;
                }

                var nodeId = CreateNode(graph, selectedType, position, selector.RedTypeTemplateDropdownViewModel.SelectedRedTypeTemplate);
                if (ReferenceEquals(Source, graph))
                {
                    SelectNodeById(nodeId);
                }
            }
        });
    }

    private uint CreateNode(RedGraph graph, Type type, System.Windows.Point position, RedTypeTemplateSelectionOption template = null) =>
        graph.GraphType switch
        {
            RedGraphType.Quest => graph.CreateQuestNode(type, position, template),
            RedGraphType.Scene => graph.CreateSceneNode(type, position, template),
            _ => throw new InvalidOperationException($"Cannot create a quest or scene node in a {graph.GraphType} graph.")
        };

    private int AddCatalogNodeTypes(
        MenuItem menu,
        IReadOnlyList<string> typeNames,
        Dictionary<string, Type> typeMap,
        System.Windows.Point position)
    {
        var addedCount = 0;
        var separatorPending = false;

        foreach (var typeName in typeNames)
        {
            if (typeName is null)
            {
                separatorPending = addedCount > 0;
                continue;
            }

            if (!typeMap.ContainsKey(typeName))
            {
                continue;
            }

            if (separatorPending)
            {
                menu.Items.Add(new Separator());
                separatorPending = false;
            }

            if (AddNodeToMenu(menu, typeName, typeMap, position))
            {
                addedCount++;
            }
        }

        return addedCount;
    }

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

    /// <summary>
    /// Create a menu item with emoji in the text and no additional icon
    /// </summary>
    private static MenuItem CreateEmojiMenuItem(string headerWithEmoji, Action click, double leftMargin = -30)
    {
        var item = new MenuItem
        {
            Header = headerWithEmoji,
            Padding = (Thickness)Application.Current.Resources["WolvenKitMarginSmall"]!,
            Icon = "", // Empty string to minimize icon space
            Margin = new Thickness(leftMargin, 0, 0, 0) // Adjustable left margin
        };
        item.Click += (_, _) => click();
        return item;
    }

    private static MenuItem CreateCategoryMenuItem(string categoryName)
    {
        return new MenuItem
        {
            Header = categoryName,
            Padding = (Thickness)Application.Current.Resources["WolvenKitMarginTiny"]!,
            Icon = new IconBox
            {
                IconPack = IconPackType.Material,
                Kind = "FolderOutline",
                Margin = (Thickness)Application.Current.Resources["WolvenKitMarginTiny"]!,
                Size = (double)Application.Current.Resources["WolvenKitIconMicro"]!
            }
        };
    }

    private static readonly string[] s_commonBehaviorNodeTypeNames =
    {
        nameof(AIbehaviorSelectorTreeNodeDefinition),
        nameof(AIbehaviorSequenceTreeNodeDefinition),
        nameof(AIbehaviorParallelNodeDefinition),
        nameof(AIbehaviorIfElseNodeDefinition),
        nameof(AIbehaviorRepeatNodeDefinition),
        nameof(AIbehaviorInstantTaskNodeDefinition),
        nameof(AIbehaviorMonitorTaskNodeDefinition),
        nameof(AIbehaviorInstantConditionNodeDefinition),
        nameof(AIbehaviorMonitorConditionNodeDefinition),
        nameof(AIbehaviorSubtreeDefinition),
        nameof(AIbehaviorIncludedTreeDefinition),
        nameof(AIbehaviorIdleTreeNodeDefinition),
        nameof(AIbehaviorSucceederNodeDefinition),
        nameof(AIbehaviorFailerNodeDefinition)
    };

    private void AddBehaviorNodeCreationItems(MenuItem parentMenu, Action<NodeCreationParams> createNode, IEnumerable<Type> nodeTypesOverride = null)
    {
        var nodeTypes = (nodeTypesOverride ?? Source.GetBehaviorNodeTypes()).ToList();
        var typeMap = nodeTypes.ToDictionary(type => type.Name, type => type);
        var types = nodeTypes
            .Select(type => new TypeEntry(GraphNodeStyling.GetTitleForNodeType(type), "", type))
            .OrderBy(entry => entry.Name)
            .ToList();

        parentMenu.Items.Add(CreateMenuItem("Search Node ...", "Magnify", "WolvenKitYellow", async () =>
        {
            await _appViewModel.SetActiveDialog(new TypeSelectorDialogViewModel(_redTypeTemplateService, types)
            {
                DialogHandler = model =>
                {
                    _appViewModel.CloseDialogCommand.Execute(null);
                    if (model is TypeSelectorDialogViewModel { SelectedEntry.UserData: Type selectedType } tsdvm)
                    {
                        createNode(new NodeCreationParams(selectedType, tsdvm.RedTypeTemplateDropdownViewModel.SelectedRedTypeTemplate));
                    }
                }
            });
        }));

        parentMenu.Items.Add(new Separator());

        foreach (var typeName in s_commonBehaviorNodeTypeNames)
        {
            AddBehaviorNodeToMenu(parentMenu, typeName, typeMap, createNode, true);
        }
    }

    private void AddBehaviorNodeToMenu(MenuItem parentMenu, string typeName, Dictionary<string, Type> typeMap, Action<NodeCreationParams> createNode, bool isRootItem = false)
    {
        if (!typeMap.TryGetValue(typeName, out var nodeType))
        {
            return;
        }

        var displayName = GraphNodeStyling.GetTitleForNodeType(nodeType);
        var emoji = GraphNodeStyling.GetIconForNodeTitle(displayName);
        var leftMargin = isRootItem ? -30 : -15;
        parentMenu.Items.Add(CreateEmojiMenuItem($"{emoji}   {displayName}", () => createNode(new NodeCreationParams(nodeType)), leftMargin));
    }

    private bool AddNodeToMenu(MenuItem parentMenu, string typeName, Dictionary<string, Type> typeMap, System.Windows.Point position, bool isRootItem = false)
    {
        if (!typeMap.TryGetValue(typeName, out var nodeType))
        {
            return false;
        }

        var displayName = GraphNodeStyling.GetTitleForNodeType(nodeType);
        var emoji = GraphNodeStyling.GetIconForNodeTitle(displayName);
        var leftMargin = isRootItem ? -30 : -15;
        parentMenu.Items.Add(CreateEmojiMenuItem($"{emoji}   {displayName}", () =>
        {
            var nodeId = CreateNode(Source, nodeType, position);
            SelectNodeById(nodeId);
        }, leftMargin));

        return true;
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
            if (Source.GraphType == RedGraphType.Behavior)
            {
                if (Source.CanEditBehaviorChildConnection(connectionViewModel))
                {
                    ShowBehaviorConnectionContextMenu(connection, connectionViewModel);
                }

                e.Handled = true;
                return;
            }

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

    private void ShowBehaviorConnectionContextMenu(Connection connection, ConnectionViewModel connectionViewModel)
    {
        Editor.SelectedItems.Clear();
        Editor.SelectedItems.Add(connectionViewModel);
        connectionViewModel.IsSelected = true;

        var contextMenu = new ContextMenu();

        var canMoveUp = Source.CanMoveBehaviorChild(connectionViewModel, -1);
        var moveUpMenuItem = CreateMenuItem("Move Child Up", "ArrowUp", () =>
        {
            var nodeId = Source.MoveBehaviorChild(connectionViewModel, -1);
            connectionViewModel.IsSelected = false;
            SelectNodeById(nodeId);
        });
        moveUpMenuItem.IsEnabled = canMoveUp;
        contextMenu.Items.Add(moveUpMenuItem);

        var canMoveDown = Source.CanMoveBehaviorChild(connectionViewModel, 1);
        var moveDownMenuItem = CreateMenuItem("Move Child Down", "ArrowDown", () =>
        {
            var nodeId = Source.MoveBehaviorChild(connectionViewModel, 1);
            connectionViewModel.IsSelected = false;
            SelectNodeById(nodeId);
        });
        moveDownMenuItem.IsEnabled = canMoveDown;
        contextMenu.Items.Add(moveDownMenuItem);
        contextMenu.Items.Add(new Separator());

        var replaceMenu = CreateCategoryMenuItem("Replace Child");
        AddBehaviorNodeCreationItems(replaceMenu, type =>
        {
            var nodeId = Source.ReplaceBehaviorChild(connectionViewModel, type.Type, type.RedTypeTemplateSelectionOption);
            connectionViewModel.IsSelected = false;
            SelectNodeById(nodeId);
        });
        contextMenu.Items.Add(replaceMenu);

        var wrapMenu = CreateCategoryMenuItem("Wrap Child With");
        AddBehaviorNodeCreationItems(wrapMenu, type =>
        {
            var nodeId = Source.WrapBehaviorChild(connectionViewModel, type.Type, type.RedTypeTemplateSelectionOption);
            connectionViewModel.IsSelected = false;
            SelectNodeById(nodeId);
        }, Source.GetBehaviorWrapperNodeTypes());
        contextMenu.Items.Add(wrapMenu);
        contextMenu.Items.Add(new Separator());

        contextMenu.Items.Add(CreateMenuItem("Delete Child Branch", "Delete", "WolvenKitRed", () =>
        {
            var nodeId = Source.DeleteBehaviorChild(connectionViewModel);
            connectionViewModel.IsSelected = false;
            SelectNodeById(nodeId);
        }));

        connection.SetCurrentValue(ContextMenuProperty, contextMenu);
        contextMenu.SetCurrentValue(ContextMenu.IsOpenProperty, true);
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
    /// Determines if a scene node should use a deletion marker when deleted
    /// </summary>
    private static bool ShouldSceneNodeUseDeletionMarker(BaseSceneViewModel node)
    {
        // For scnQuestNode, check the contained quest node using the same logic as quest nodes
        if (node.Data is scnQuestNode scnQuestNode && scnQuestNode.QuestNode?.Chunk != null)
        {
            var questNode = scnQuestNode.QuestNode.Chunk;

            // Check if the contained quest node is signal-stopping
            if (questNode is questSignalStoppingNodeDefinition)
            {
                return true;
            }

            // Additional quest node types that should use deletion markers for safety
            var criticalQuestTypes = new[]
            {
                typeof(questSwitchNodeDefinition),
                typeof(questFlowControlNodeDefinition)
            };

            if (criticalQuestTypes.Contains(questNode.GetType()))
            {
                return true;
            }
        }

        // For pure scene nodes, manually list which ones should use deletion markers since scene nodes dont have a nice inheritance structure to check compred to quest nodes
        var criticalSceneTypes = new[]
        {
            typeof(scnAndNode),
            typeof(scnSectionNode),
            typeof(scnChoiceNode),
            typeof(scnHubNode),
            typeof(scnXorNode),
            typeof(scnRewindableSectionNode),
            typeof(scnInterruptManagerNode),
            typeof(scnFlowControlNode)
        };

        return criticalSceneTypes.Contains(node.Data.GetType());
    }

    /// <summary>
    /// Detaches a quest node by removing all of its input and output connections
    /// </summary>
    private void DetachQuestNode(BaseQuestViewModel node)
    {
        if (Source == null) return;

        // Create a list to store all connections that need to be removed
        var connectionsToRemove = new List<QuestConnectionViewModel>();

        // Find all connections where this node is the source (output connections)
        foreach (var connection in Source.Connections.OfType<QuestConnectionViewModel>())
        {
            if (connection.Source.OwnerId == node.UniqueId)
            {
                connectionsToRemove.Add(connection);
            }
        }

        // Find all connections where this node is the target (input connections)
        foreach (var connection in Source.Connections.OfType<QuestConnectionViewModel>())
        {
            if (connection.Target.OwnerId == node.UniqueId)
            {
                connectionsToRemove.Add(connection);
            }
        }

        // Remove all the connections in the list
        foreach (var connection in connectionsToRemove)
        {
            Source.RemoveQuestConnectionPublic(connection);
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
    /// Get the center of the visible graph viewport for keyboard-driven node creation.
    /// </summary>
    private System.Windows.Point GetViewportCenter()
    {
        var viewport = Editor.ViewportLocation;
        var size = Editor.ViewportSize;
        return new System.Windows.Point(
            viewport.X + (size.Width / 2),
            viewport.Y + (size.Height / 2));
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
