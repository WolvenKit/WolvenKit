using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.GraphEditor;
using WolvenKit.App.ViewModels.GraphEditor.Nodes;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.App.Models;
using WolvenKit.App.Interaction;
using Splat;
using WolvenKit.Views.Dialogs;
using AdonisUI.Controls;

namespace WolvenKit.Views.Documents
{
    /// <summary>
    /// Interaktionslogik für SceneGraphView.xaml
    /// </summary>
    public partial class SceneGraphView : UserControl
    {
        // Navigation memory: tracks which child was last visited from each node in each direction
        private readonly Dictionary<(uint nodeId, Key direction), uint> _navigationMemory = new();
        private readonly List<uint> _navigationHistory = new();

        public SceneGraphView()
        {
            InitializeComponent();
            DataContextChanged += OnDataContextChanged;
        }

        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue is not SceneGraphViewModel viewModel) return;

            viewModel.MainGraph.Connections.CollectionChanged += (_, _) => UpdateConnectionPathTypes(viewModel.MainGraph);
            viewModel.MainGraph.Nodes.CollectionChanged += (_, _) => UpdateConnectionPathTypes(viewModel.MainGraph);

            Dispatcher.BeginInvoke(new Action(() =>
            {
                SetupConnectionTemplate();
                UpdateConnectionPathTypes(viewModel.MainGraph);
                
                // Add a small delay to ensure smooth loading experience
                Dispatcher.BeginInvoke(new Action(() =>
                {
                    viewModel.SetGraphLoaded();
                }), System.Windows.Threading.DispatcherPriority.Background);
            }), System.Windows.Threading.DispatcherPriority.Loaded);
        }

        private void SetupConnectionTemplate()
        {
            if (SceneGraphEditor?.Editor == null) return;

            var sceneConnectionTemplate = Resources["SceneConnectionTemplate"] as DataTemplate;
            if (sceneConnectionTemplate != null)
            {
                SceneGraphEditor.Editor.SetCurrentValue(Nodify.NodifyEditor.ConnectionTemplateProperty, sceneConnectionTemplate);
            }


        }

        private void UpdateConnectionPathTypes(RedGraph graph)
        {
            if (graph?.Nodes == null || graph.Connections == null)
                return;

            var pathTypes = CalculateConnectionPathTypes(graph);

            foreach (var connection in graph.Connections.OfType<SceneConnectionViewModel>())
            {
                connection.PathType = pathTypes.GetValueOrDefault(connection, 2); // Default to live path
            }
        }

        private Dictionary<SceneConnectionViewModel, int> CalculateConnectionPathTypes(RedGraph graph)
        {
            var connectionTypeMap = new Dictionary<SceneConnectionViewModel, int>();
            if (graph?.Connections == null) return connectionTypeMap;

            const int deadEndNodeThreshold = 4;
            const int deadEndPathType = 1;
            const int livePathType = 2;

            var adjacencyMap = BuildAdjacencyMap(graph);
            var endNodeIds = graph.Nodes.OfType<scnEndNodeWrapper>().Select(n => n.UniqueId).ToList();

            foreach (var connection in graph.Connections.OfType<SceneConnectionViewModel>())
            {
                var (containsEndNode, downstreamNodeCount) = CheckPath(
                    connection.Target.OwnerId,
                    adjacencyMap,
                    endNodeIds,
                    new HashSet<uint>()
                );

                if (downstreamNodeCount <= deadEndNodeThreshold && !containsEndNode)
                {
                    connectionTypeMap[connection] = deadEndPathType;
                }
                else
                {
                    connectionTypeMap[connection] = livePathType;
                }
            }

            return connectionTypeMap;
        }

        private (bool containsEndNode, int downstreamNodeCount) CheckPath(
            uint nodeId,
            Dictionary<uint, List<uint>> adjacencyMap,
            IReadOnlyCollection<uint> endNodeIds,
            HashSet<uint> visited)
        {
            if (!visited.Add(nodeId))
            {
                return (false, 0); // Cycle detected
            }

            var pathContainsEndNode = endNodeIds.Contains(nodeId);
            var count = 0;

            if (adjacencyMap.TryGetValue(nodeId, out var neighbors))
            {
                foreach (var neighborId in neighbors)
                {
                    var result = CheckPath(neighborId, adjacencyMap, endNodeIds, visited);
                    pathContainsEndNode |= result.containsEndNode;
                    count += 1 + result.downstreamNodeCount;
                }
            }

            return (pathContainsEndNode, count);
        }

        private Dictionary<uint, List<uint>> BuildAdjacencyMap(RedGraph graph)
        {
            var adjacencyMap = new Dictionary<uint, List<uint>>();

            foreach (var connection in graph.Connections.OfType<SceneConnectionViewModel>())
            {
                var sourceId = connection.Source.OwnerId;
                var targetId = connection.Target.OwnerId;

                if (!adjacencyMap.ContainsKey(sourceId))
                    adjacencyMap[sourceId] = new List<uint>();

                adjacencyMap[sourceId].Add(targetId);
            }

            return adjacencyMap;
        }

        /// <summary>
        /// Smart navigation with memory - cycles through multiple connections in the same direction
        /// </summary>
        private WolvenKit.App.ViewModels.GraphEditor.NodeViewModel FindNextNodeInDirection(
            RedGraph graph, 
            WolvenKit.App.ViewModels.GraphEditor.NodeViewModel currentNode, 
            Key direction)
        {
            if (graph?.Nodes == null) return null;

            // Get all connected nodes in the specified direction
            var connectedCandidates = GetConnectedNodesInDirection(graph, currentNode, direction);
            
            if (connectedCandidates.Count > 0)
            {
                // If we have multiple connected options, use memory to cycle through them
                if (connectedCandidates.Count > 1)
                {
                    return GetNextNodeWithMemory(currentNode.UniqueId, direction, connectedCandidates);
                }
                
                // Single connected option
                return connectedCandidates[0];
            }

            // No connected nodes, fallback to spatial navigation for any node in that direction
            return GetNearestNodeInDirection(graph, currentNode, direction);
        }

        /// <summary>
        /// Get connected nodes in the specified direction, sorted by spatial positioning
        /// </summary>
        private List<WolvenKit.App.ViewModels.GraphEditor.NodeViewModel> GetConnectedNodesInDirection(
            RedGraph graph, 
            WolvenKit.App.ViewModels.GraphEditor.NodeViewModel currentNode, 
            Key direction)
        {
            var candidates = new List<(WolvenKit.App.ViewModels.GraphEditor.NodeViewModel node, double distance)>();
            var currentX = currentNode.Location.X;
            var currentY = currentNode.Location.Y;

            // Get all connected nodes
            var connectedNodeIds = graph.Connections
                .OfType<WolvenKit.App.ViewModels.GraphEditor.ConnectionViewModel>()
                .Where(c => c.Source.OwnerId == currentNode.UniqueId || c.Target.OwnerId == currentNode.UniqueId)
                .Select(c => c.Source.OwnerId == currentNode.UniqueId ? c.Target.OwnerId : c.Source.OwnerId)
                .ToHashSet();

            foreach (var node in graph.Nodes.Where(n => connectedNodeIds.Contains(n.UniqueId)))
            {
                var deltaX = node.Location.X - currentX;
                var deltaY = node.Location.Y - currentY;
                var distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

                if (distance < 10) continue;

                bool isInDirection = direction switch
                {
                    Key.Right => deltaX > Math.Abs(deltaY) * 0.5,
                    Key.Left => deltaX < -Math.Abs(deltaY) * 0.5,
                    Key.Down => deltaY > Math.Abs(deltaX) * 0.5,
                    Key.Up => deltaY < -Math.Abs(deltaX) * 0.5,
                    _ => false
                };

                if (isInDirection)
                {
                    candidates.Add((node, distance));
                }
            }

            return candidates.OrderBy(c => c.distance).Select(c => c.node).ToList();
        }

        /// <summary>
        /// Use navigation memory to cycle through multiple connected options
        /// </summary>
        private WolvenKit.App.ViewModels.GraphEditor.NodeViewModel GetNextNodeWithMemory(
            uint currentNodeId, 
            Key direction, 
            List<WolvenKit.App.ViewModels.GraphEditor.NodeViewModel> candidates)
        {
            var memoryKey = (currentNodeId, direction);
            
            // Check if we have memory for this node/direction combination
            if (_navigationMemory.TryGetValue(memoryKey, out var lastVisitedId))
            {
                // Find the index of the last visited node
                var lastIndex = candidates.FindIndex(n => n.UniqueId == lastVisitedId);
                if (lastIndex >= 0)
                {
                    // Return the next node in the cycle
                    var nextIndex = (lastIndex + 1) % candidates.Count;
                    return candidates[nextIndex];
                }
            }

            // No memory or last visited node not found, return first candidate
            return candidates[0];
        }

        /// <summary>
        /// Fallback spatial navigation for unconnected nodes
        /// </summary>
        private WolvenKit.App.ViewModels.GraphEditor.NodeViewModel GetNearestNodeInDirection(
            RedGraph graph, 
            WolvenKit.App.ViewModels.GraphEditor.NodeViewModel currentNode, 
            Key direction)
        {
            var candidates = new List<(WolvenKit.App.ViewModels.GraphEditor.NodeViewModel node, double distance)>();
            var currentX = currentNode.Location.X;
            var currentY = currentNode.Location.Y;

            foreach (var node in graph.Nodes)
            {
                if (node.UniqueId == currentNode.UniqueId) continue;

                var deltaX = node.Location.X - currentX;
                var deltaY = node.Location.Y - currentY;
                var distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

                if (distance < 10) continue;

                bool isInDirection = direction switch
                {
                    Key.Right => deltaX > Math.Abs(deltaY) * 0.5,
                    Key.Left => deltaX < -Math.Abs(deltaY) * 0.5,
                    Key.Down => deltaY > Math.Abs(deltaX) * 0.5,
                    Key.Up => deltaY < -Math.Abs(deltaX) * 0.5,
                    _ => false
                };

                if (isInDirection)
                {
                    candidates.Add((node, distance));
                }
            }

            return candidates.OrderBy(c => c.distance).FirstOrDefault().node;
        }

        /// <summary>
        /// Update navigation memory when moving between nodes
        /// </summary>
        private void UpdateNavigationMemory(uint fromNodeId, Key direction, uint toNodeId)
        {
            var memoryKey = (fromNodeId, direction);
            _navigationMemory[memoryKey] = toNodeId;
            
            // Also update navigation history for potential future features
            _navigationHistory.Add(toNodeId);
            
            // Keep history manageable (last 50 moves)
            if (_navigationHistory.Count > 50)
            {
                _navigationHistory.RemoveAt(0);
            }
        }

        /// <summary>
        /// Smoothly pan the graph view towards the selected node
        /// </summary>
        private void CenterViewOnSelectedNode(RedGraph graph, WolvenKit.App.ViewModels.GraphEditor.NodeViewModel targetNode)
        {
            if (SceneGraphEditor?.Editor == null || graph == null || targetNode == null)
                return;

            try 
            {
                var editor = SceneGraphEditor.Editor;
                var nodeLocation = targetNode.Location;
                var currentViewport = editor.ViewportLocation;
                var viewportSize = editor.ViewportSize;
                
                // Calculate if node is already reasonably visible
                var nodeViewportX = nodeLocation.X - currentViewport.X;
                var nodeViewportY = nodeLocation.Y - currentViewport.Y;
                
                var margin = 150; // Larger margin to trigger panning earlier
                var needsPanX = nodeViewportX < margin || nodeViewportX > viewportSize.Width - margin;
                var needsPanY = nodeViewportY < margin || nodeViewportY > viewportSize.Height - margin;
                
                if (!needsPanX && !needsPanY)
                    return; // Node is already well visible, no need to pan
                
                // Calculate target viewport location (center the node more nicely)
                var targetX = currentViewport.X;
                var targetY = currentViewport.Y;
                
                if (needsPanX)
                {
                    // Center horizontally with slight offset to avoid perfect centering (less jarring)
                    targetX = nodeLocation.X - (viewportSize.Width * 0.4); // 40% from left edge
                }
                
                if (needsPanY)
                {
                    // Center vertically with slight offset
                    targetY = nodeLocation.Y - (viewportSize.Height * 0.4); // 40% from top edge
                }
                
                // Smooth animated pan
                AnimateViewportTo(new Point(targetX, targetY), TimeSpan.FromMilliseconds(300));
            }
            catch (Exception)
            {
                // Silently handle any viewport manipulation errors
            }
        }

        /// <summary>
        /// Animate viewport to target location with smooth easing
        /// </summary>
        private void AnimateViewportTo(Point targetLocation, TimeSpan duration)
        {
            if (SceneGraphEditor?.Editor == null) return;
            
            var editor = SceneGraphEditor.Editor;
            var startLocation = editor.ViewportLocation;
            var startTime = DateTime.Now;
            
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(16)
            };
            
            timer.Tick += (sender, e) =>
            {
                var elapsed = DateTime.Now - startTime;
                var progress = Math.Min(elapsed.TotalMilliseconds / duration.TotalMilliseconds, 1.0);
                
                if (progress >= 1.0)
                {
                    editor.ViewportLocation = targetLocation;
                    timer.Stop();
                    return;
                }
                
                // Smooth easing function (ease-out)
                var easedProgress = 1 - Math.Pow(1 - progress, 3);
                
                var currentX = startLocation.X + (targetLocation.X - startLocation.X) * easedProgress;
                var currentY = startLocation.Y + (targetLocation.Y - startLocation.Y) * easedProgress;
                
                editor.ViewportLocation = new Point(currentX, currentY);
            };
            
            timer.Start();
        }

        /// <summary>
        /// Search for a node by its ID and navigate to it
        /// </summary>
        public bool SearchAndNavigateToNode(uint nodeId)
        {
            var viewModel = DataContext as SceneGraphViewModel;
            if (viewModel?.MainGraph?.Nodes == null)
                return false;

            // Find the node with the specified ID
            var targetNode = viewModel.MainGraph.Nodes.FirstOrDefault(n => n.UniqueId == nodeId);
            if (targetNode == null)
                return false;

            // Select the node
            SceneGraphEditor?.Editor?.SelectedItems.Clear();
            SceneGraphEditor?.Editor?.SelectedItems.Add(targetNode);
            NodeSelectionService.Instance.SelectedNode = targetNode;

            // Center view on the node
            CenterViewOnSelectedNode(viewModel.MainGraph, targetNode);

            return true;
        }

        /// <summary>
        /// Shows a dialog to go directly to a node by its ID
        /// </summary>
        public void ShowGoToNodeDialog()
        {
            var dialog = new InputDialogView("Go to Node", "");

            if (dialog.ViewModel is not InputDialogViewModel vm ||
                dialog.ShowDialog(Application.Current.MainWindow) != true)
            {
                return;
            }

            if (uint.TryParse(vm.Text?.Trim(), out var nodeId))
            {
                if (!SearchAndNavigateToNode(nodeId))
                {
                    MessageBoxModel messageBox = new()
                    {
                        Text = $"Node with ID {nodeId} not found.",
                        Caption = "Go to Node",
                        Icon = AdonisUI.Controls.MessageBoxImage.Information,
                        Buttons = new[] { MessageBoxButtons.Ok() }
                    };
                    AdonisUI.Controls.MessageBox.Show(Application.Current.MainWindow, messageBox);
                }
            }
            else
            {
                MessageBoxModel messageBox = new()
                {
                    Text = "Please enter a valid numeric Node ID.",
                    Caption = "Invalid Input",
                    Icon = AdonisUI.Controls.MessageBoxImage.Warning,
                    Buttons = new[] { MessageBoxButtons.Ok() }
                };
                AdonisUI.Controls.MessageBox.Show(Application.Current.MainWindow, messageBox);
            }
        }

        /// <summary>
        /// Handles keyboard shortcuts for node deletion and navigation
        /// </summary>
        private void SceneGraphView_OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
            var viewModel = DataContext as SceneGraphViewModel;
            if (viewModel?.MainGraph == null)
                return;

            // Shortcut: Delete key to soft delete, Shift+Delete for hard delete
            if (e.Key == Key.Delete)
            {
                // Use SelectedNodes from underlying GraphEditor
                var selectedNodes = SceneGraphEditor?.Editor?.SelectedItems?
                    .OfType<BaseSceneViewModel>()
                    .Where(node => !(node is scnStartNodeWrapper || node is scnEndNodeWrapper)) // Can't delete start/end nodes
                    .ToList();

                if (selectedNodes != null && selectedNodes.Count > 0)
                {
                    if (Keyboard.Modifiers.HasFlag(ModifierKeys.Shift))
                    {
                        // Shift+Del: Hard delete (permanent removal)
                        var nodeViewModels = selectedNodes.Cast<object>().ToList();
                        viewModel.MainGraph.RemoveNodes(nodeViewModels);
                    }
                    else
                    {
                        // Del: Smart delete - soft delete normal nodes, hard delete deletion markers
                        foreach (var node in selectedNodes)
                        {
                            // If it's already a deletion marker, destroy it completely
                            if (node is scnDeletionMarkerNodeWrapper)
                            {
                                var nodeAsObject = (object)node;
                                viewModel.MainGraph.RemoveNodes(new List<object> { nodeAsObject });
                            }
                            else
                            {
                                // Normal node: replace with deletion marker (soft delete)
                                viewModel.MainGraph.ReplaceNodeWithDeletionMarker(node);
                            }
                        }
                    }
                    e.Handled = true;
                }
            }

            // Shortcut: Ctrl+D to duplicate currently selected node
            if (e.Key == Key.D && Keyboard.Modifiers.HasFlag(ModifierKeys.Control))
            {
                var selectedNode = NodeSelectionService.Instance.SelectedNode;
                if (selectedNode != null)
                {
                    viewModel.MainGraph.DuplicateNode(selectedNode);
                    e.Handled = true;
                }
            }

            // Shortcut: Ctrl+N to open new node dialog
            if (e.Key == Key.N && Keyboard.Modifiers.HasFlag(ModifierKeys.Control))
            {
                OpenNewNodeDialog(viewModel.MainGraph);
                e.Handled = true;
            }

            // Shortcut: Ctrl+G to open "go to node" dialog
            if (e.Key == Key.G && Keyboard.Modifiers.HasFlag(ModifierKeys.Control))
            {
                ShowGoToNodeDialog();
                e.Handled = true;
                return;
            }

            // Shortcut: Arrow keys for smart graph walk based on spatial positioning
            if (e.Key is Key.Left or Key.Right or Key.Up or Key.Down)
            {
                var currentNode = NodeSelectionService.Instance.SelectedNode;
                if (currentNode == null)
                    return;

                var next = FindNextNodeInDirection(viewModel.MainGraph, currentNode, e.Key);

                if (next != null)
                {
                    // Update navigation memory
                    UpdateNavigationMemory(currentNode.UniqueId, e.Key, next.UniqueId);
                    
                    // Update selection in editor
                    SceneGraphEditor?.Editor?.SelectedItems.Clear();
                    SceneGraphEditor?.Editor?.SelectedItems.Add(next);
                    NodeSelectionService.Instance.SelectedNode = next;
                    
                    // Auto-scroll graph view to keep selected node visible
                    CenterViewOnSelectedNode(viewModel.MainGraph, next);
                    
                    e.Handled = true;
                }
            }
        }

        /// <summary>
        /// Open the new node type selector dialog
        /// </summary>
        private async void OpenNewNodeDialog(RedGraph graph)
        {
            if (graph?.GraphType != RedGraphType.Scene) return;

            try
            {
                var appViewModel = Locator.Current.GetService<AppViewModel>();
                if (appViewModel == null) return;

                // Get scene node types
                var sceneNodeTypes = graph.GetSceneNodeTypes();
                
                // Separate DynamicSceneGraph from regular scene types (move to end)
                var regularSceneTypes = sceneNodeTypes.Where(x => x.Name != "DynamicSceneGraphNode").ToList();
                var dynamicSceneTypes = sceneNodeTypes.Where(x => x.Name == "DynamicSceneGraphNode").ToList();
                
                var sceneTypes = regularSceneTypes
                    .Select(x => new TypeEntry(GraphNodeStyling.GetTitleForNodeType(x), "Scene", x))
                    .OrderBy(x => x.Name)
                    .ToList();

                // Get quest node types that can be embedded in scene graphs
                var questNodeTypes = graph.GetQuestNodeTypesForScene();
                var questTypes = questNodeTypes
                    .Select(x => new TypeEntry(GraphNodeStyling.GetTitleForNodeType(x), "Quest", x))
                    .OrderBy(x => x.Name)
                    .ToList();

                // Combine both types
                var allTypes = new List<TypeEntry>();
                allTypes.AddRange(sceneTypes);
                allTypes.AddRange(questTypes);
                
                // Add DynamicSceneGraph at the end
                allTypes.AddRange(dynamicSceneTypes
                    .Select(x => new TypeEntry(GraphNodeStyling.GetTitleForNodeType(x), "Scene", x)));

                // Create and show the type selector dialog
                await appViewModel.SetActiveDialog(new TypeSelectorDialogViewModel(allTypes)
                {
                    DialogHandler = model =>
                    {
                        appViewModel.CloseDialogCommand.Execute(null);
                        if (model is TypeSelectorDialogViewModel { SelectedEntry.UserData: Type selectedType })
                        {
                            // Create new node at current viewport center
                            var viewportCenter = GetViewportCenter();
                            var nodeId = graph.CreateSceneNode(selectedType, viewportCenter);
                            SelectNodeById(nodeId);
                        }
                    }
                });
            }
            catch (Exception)
            {
                // Silently handle any dialog creation errors
            }
        }



        /// <summary>
        /// Get the center point of the current viewport for placing new nodes
        /// </summary>
        private Point GetViewportCenter()
        {
            if (SceneGraphEditor?.Editor == null)
                return new Point(0, 0);

            var viewport = SceneGraphEditor.Editor.ViewportLocation;
            var size = SceneGraphEditor.Editor.ViewportSize;
            
            return new Point(
                viewport.X + size.Width / 2,
                viewport.Y + size.Height / 2
            );
        }

        /// <summary>
        /// Forward connection right-click events to the underlying GraphEditorView
        /// </summary>
        private void Connection_OnRightClick(object sender, MouseButtonEventArgs e)
        {
            // Forward the event to the underlying GraphEditorView's Connection_OnRightClick method
            SceneGraphEditor?.Connection_OnRightClick(sender, e);
        }

        /// <summary>
        /// Selects a node by its ID
        /// </summary>
        private void SelectNodeById(uint nodeId)
        {
            var viewModel = DataContext as SceneGraphViewModel;
            if (viewModel?.MainGraph?.Nodes == null || SceneGraphEditor?.Editor == null) return;

            // Find the node with the specified ID
            var targetNode = viewModel.MainGraph.Nodes.FirstOrDefault(n => n.UniqueId == nodeId);

            if (targetNode != null)
            {
                // Clear current selection
                SceneGraphEditor.Editor.SelectedItems.Clear();
                
                // Select the target node
                SceneGraphEditor.Editor.SelectedItems.Add(targetNode);
                
                // Update the NodeSelectionService
                NodeSelectionService.Instance.SelectedNode = targetNode;
            }
        }
    }
} 