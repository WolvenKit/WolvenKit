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
using WolvenKit.App.ViewModels.GraphEditor.Nodes;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest.Internal;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.RED4.Types;

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
            // Get all available node types
            var sceneNodeTypes = Source.GetSceneNodeTypes();
            var questNodeTypes = Source.GetQuestNodeTypesForScene();
            var allTypes = new List<TypeEntry>();
            allTypes.AddRange(sceneNodeTypes.Select(x => new TypeEntry(GraphNodeStyling.GetTitleForNodeType(x), "Scene", x)));
            allTypes.AddRange(questNodeTypes.Select(x => new TypeEntry(GraphNodeStyling.GetTitleForNodeType(x), "Quest", x)));

            var addMenu = CreateAddMenuItem();

            // Open Dialog option
            addMenu.Items.Add(CreateMenuItem("Search Node ...", "Magnify", "WolvenKitYellow", async () =>
            {
                await _appViewModel.SetActiveDialog(new TypeSelectorDialogViewModel(allTypes.OrderBy(x => x.Name).ToList())
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

            // Create type lookup for easy access
            var typeMap = new Dictionary<string, Type>();
            foreach (var nodeType in sceneNodeTypes.Concat(questNodeTypes))
            {
                typeMap[nodeType.Name] = nodeType;
            }

            // Common Nodes (directly at root)
            AddNodeToMenu(addMenu, "scnSectionNode", typeMap, mousePosition, true);
            AddNodeToMenu(addMenu, "scnChoiceNode", typeMap, mousePosition, true);
            AddNodeToMenu(addMenu, "questPauseConditionNodeDefinition", typeMap, mousePosition, true);
            AddNodeToMenu(addMenu, "questFactsDBManagerNodeDefinition", typeMap, mousePosition, true);
            AddNodeToMenu(addMenu, "questUseWorkspotNodeDefinition", typeMap, mousePosition, true);
            AddNodeToMenu(addMenu, "questUIManagerNodeDefinition", typeMap, mousePosition, true);
            AddNodeToMenu(addMenu, "questJournalNodeDefinition", typeMap, mousePosition, true);
            addMenu.Items.Add(new Separator());

            // Flow & Logic
            var flowMenu = CreateCategoryMenuItem("Flow & Logic");
            AddNodeToMenu(flowMenu, "scnStartNode", typeMap, mousePosition);
            AddNodeToMenu(flowMenu, "scnEndNode", typeMap, mousePosition);
            flowMenu.Items.Add(new Separator());
            AddNodeToMenu(flowMenu, "scnAndNode", typeMap, mousePosition);
            AddNodeToMenu(flowMenu, "scnHubNode", typeMap, mousePosition);
            AddNodeToMenu(flowMenu, "scnXorNode", typeMap, mousePosition);
            AddNodeToMenu(flowMenu, "scnFlowControlNode", typeMap, mousePosition);
            AddNodeToMenu(flowMenu, "scnCutControlNode", typeMap, mousePosition);
            AddNodeToMenu(flowMenu, "scnInterruptManagerNode", typeMap, mousePosition);
            flowMenu.Items.Add(new Separator());
            AddNodeToMenu(flowMenu, "questConditionNodeDefinition", typeMap, mousePosition);
            AddNodeToMenu(flowMenu, "scnRandomizerNode", typeMap, mousePosition);
            AddNodeToMenu(flowMenu, "questFactsDBManagerNodeDefinition", typeMap, mousePosition);
            AddNodeToMenu(flowMenu, "questCutControlNodeDefinition", typeMap, mousePosition);
            AddNodeToMenu(flowMenu, "questPauseConditionNodeDefinition", typeMap, mousePosition);
            flowMenu.Items.Add(new Separator());
            AddNodeToMenu(flowMenu, "questSwitchNodeDefinition", typeMap, mousePosition);

            addMenu.Items.Add(flowMenu);

            // Character & AI
            var characterMenu = CreateCategoryMenuItem("Character & AI");
            AddNodeToMenu(characterMenu, "questCharacterManagerNodeDefinition", typeMap, mousePosition);
            AddNodeToMenu(characterMenu, "questBehaviourManagerNodeDefinition", typeMap, mousePosition);
            AddNodeToMenu(characterMenu, "questPuppetAIManagerNodeDefinition", typeMap, mousePosition);
            AddNodeToMenu(characterMenu, "questPuppeteerNodeDefinition", typeMap, mousePosition);
            AddNodeToMenu(characterMenu, "questForcedBehaviourNodeDefinition", typeMap, mousePosition);
            AddNodeToMenu(characterMenu, "questUseWorkspotNodeDefinition", typeMap, mousePosition);
            characterMenu.Items.Add(new Separator());
            AddNodeToMenu(characterMenu, "questMovePuppetNodeDefinition", typeMap, mousePosition);
            AddNodeToMenu(characterMenu, "questTeleportPuppetNodeDefinition", typeMap, mousePosition);
            characterMenu.Items.Add(new Separator());
            AddNodeToMenu(characterMenu, "questMiscAICommandNode", typeMap, mousePosition);
            AddNodeToMenu(characterMenu, "questCombatNodeDefinition", typeMap, mousePosition);
            AddNodeToMenu(characterMenu, "questSendAICommandNodeDefinition", typeMap, mousePosition);
            addMenu.Items.Add(characterMenu);

            // Game & World
            var gameMenu = CreateCategoryMenuItem("Game & World");
            AddNodeToMenu(gameMenu, "questCheckpointNodeDefinition", typeMap, mousePosition);
            AddNodeToMenu(gameMenu, "questTimeManagerNodeDefinition", typeMap, mousePosition);
            AddNodeToMenu(gameMenu, "questEnvironmentManagerNodeDefinition", typeMap, mousePosition);
            AddNodeToMenu(gameMenu, "questWorldDataManagerNodeDefinition", typeMap, mousePosition);
            AddNodeToMenu(gameMenu, "questEntityManagerNodeDefinition", typeMap, mousePosition);
            AddNodeToMenu(gameMenu, "questEventManagerNodeDefinition", typeMap, mousePosition);
            AddNodeToMenu(gameMenu, "questInteractiveObjectManagerNodeDefinition", typeMap, mousePosition);
            AddNodeToMenu(gameMenu, "questTriggerManagerNodeDefinition", typeMap, mousePosition);
            gameMenu.Items.Add(new Separator());
            AddNodeToMenu(gameMenu, "questSpawnManagerNodeDefinition", typeMap, mousePosition);
            AddNodeToMenu(gameMenu, "questCrowdManagerNodeDefinition", typeMap, mousePosition);
            addMenu.Items.Add(gameMenu);

            // Journal & Mappins
            var journalMenu = CreateCategoryMenuItem("Journal & Mappins");
            AddNodeToMenu(journalMenu, "questJournalNodeDefinition", typeMap, mousePosition);
            AddNodeToMenu(journalMenu, "questMappinManagerNodeDefinition", typeMap, mousePosition);
            addMenu.Items.Add(journalMenu);

            // Vehicle
            var vehicleMenu = CreateCategoryMenuItem("Vehicle");
            AddNodeToMenu(vehicleMenu, "questVehicleNodeDefinition", typeMap, mousePosition);
            AddNodeToMenu(vehicleMenu, "questVehicleNodeCommandDefinition", typeMap, mousePosition);
            AddNodeToMenu(vehicleMenu, "questTeleportVehicleNodeDefinition", typeMap, mousePosition);
            addMenu.Items.Add(vehicleMenu);

            // Items & Inventory
            var itemsMenu = CreateCategoryMenuItem("Items & Inventory");
            AddNodeToMenu(itemsMenu, "questItemManagerNodeDefinition", typeMap, mousePosition);
            AddNodeToMenu(itemsMenu, "questEquipItemNodeDefinition", typeMap, mousePosition);
            AddNodeToMenu(itemsMenu, "questUnequipItemNodeDefinition", typeMap, mousePosition);
            addMenu.Items.Add(itemsMenu);

            // Audio, FX & Rendering
            var audioMenu = CreateCategoryMenuItem("Audio & FX");
            AddNodeToMenu(audioMenu, "questAudioNodeDefinition", typeMap, mousePosition);
            AddNodeToMenu(audioMenu, "questAudioCharacterManagerNodeDefinition", typeMap, mousePosition);
            AddNodeToMenu(audioMenu, "questVoicesetManagerNodeDefinition", typeMap, mousePosition);
            AddNodeToMenu(audioMenu, "questFXManagerNodeDefinition", typeMap, mousePosition);
            AddNodeToMenu(audioMenu, "questRenderFxManagerNodeDefinition", typeMap, mousePosition);
            AddNodeToMenu(audioMenu, "questVisionModesManagerNodeDefinition", typeMap, mousePosition);
            addMenu.Items.Add(audioMenu);

            // Debug
            var debugMenu = CreateCategoryMenuItem("Debug");
            // Add composite debug node with preset configuration
            var debugWarningTitle = "UIManager (Debug Warning)";
            var debugWarningEmoji = GraphNodeStyling.GetIconForNodeTitle(debugWarningTitle);
            var debugWarningMenuItem = CreateEmojiMenuItem($"{debugWarningEmoji}   {debugWarningTitle}", () =>
            {
                var nodeId = Source.CreateCompositeSceneNode("DebugWarning", typeof(questUIManagerNodeDefinition), mousePosition);
                SelectNodeById(nodeId);
            }, -15);
            debugMenu.Items.Add(debugWarningMenuItem);
            
            addMenu.Items.Add(debugMenu);
            AddNodeToMenu(debugMenu, "scnDeletionMarkerNode", typeMap, mousePosition);
            AddNodeToMenu(debugMenu, "questPlaceholderNodeDefinition", typeMap, mousePosition);
            

            nodifyEditor.ContextMenu.Items.Add(addMenu);
        }

        if (Source.GraphType == RedGraphType.Quest)
        {
            var nodeTypes = Source.GetQuestNodeTypes();
            var types = nodeTypes
                .Select(x => new TypeEntry(GraphNodeStyling.GetTitleForNodeType(x), "", x))
                .OrderBy(x => x.Name)
                .ToList();

            var addMenu = CreateAddMenuItem();

            addMenu.Items.Add(CreateMenuItem("Search Node ...", "Magnify", "WolvenKitYellow", async () =>
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

            // Create a debug submenu for quest graphs
            var questDebugMenu = CreateCategoryMenuItem("Debug");
            questDebugMenu.Items.Add(CreateMenuItem("Quest Deletion Marker", () => Source.CreateQuestNode(typeof(questDeletionMarkerNodeDefinition), mousePosition)));
            addMenu.Items.Add(questDebugMenu);
            addMenu.Items.Add(new Separator());

            foreach (var nodeType in nodeTypes)
            {
                var title = GraphNodeStyling.GetTitleForNodeType(nodeType);
                // Quest graph - use regular menu items without emojis
                addMenu.Items.Add(CreateMenuItem(title, () => Source.CreateQuestNode(nodeType, mousePosition)));
            }

            nodifyEditor.ContextMenu.Items.Add(addMenu);
        }

        nodifyEditor.ContextMenu.Items.Add(CreateMenuItem("Arrange Items", "ViewDashboard", ArrangeNodes));

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
            node.ContextMenu.Items.Add(CreateMenuItem("Destroy Nodes", "CloseBoxOutline", "WolvenKitRed", () => Source.RemoveNodes(SelectedNodes)));
            node.ContextMenu.Items.Add(CreateMenuItem("Create Phase", "FolderOutline", "WolvenKitRed", () => Source.CreatePhaseFromSelection(SelectedNodes)));
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

    private void AddNodeToMenu(MenuItem parentMenu, string typeName, Dictionary<string, Type> typeMap, System.Windows.Point mousePosition, bool isRootItem = false)
    {
        if (typeMap.TryGetValue(typeName, out var nodeType))
        {
            // Use the same title formatting logic as the actual nodes
            var displayName = GraphNodeStyling.GetTitleForNodeType(nodeType);
            var emoji = GraphNodeStyling.GetIconForNodeTitle(displayName);
            // Use -30 margin for root items in "Add Node" menu, -15 for nested submenu items
            var leftMargin = isRootItem ? -30 : -15;
            var menuItem = CreateEmojiMenuItem($"{emoji}   {displayName}", () =>
            {
                var nodeId = Source.CreateSceneNode(nodeType, mousePosition);
                SelectNodeById(nodeId);
            }, leftMargin);
            parentMenu.Items.Add(menuItem);
        }
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
