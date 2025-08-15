#nullable enable
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.GraphEditor;
using WolvenKit.App.ViewModels.GraphEditor.Nodes;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest.Internal;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.App.Interaction;
using Splat;
using WolvenKit.Views.Dialogs;
using WolvenKit.Views.GraphEditor;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Documents
{
    /// <summary>
    /// Interaction logic for QuestPhaseGraphView.xaml
    /// Handles quest phase graph visualization, node selection, automatic deselection
    /// when switching between quest phase and scene documents to avoid selection confusion,
    /// and selection restoration when returning to previously viewed documents.
    /// 
    /// Selection persistence:
    /// - Stores last selected node ID when switching away from quest phase documents
    /// - Restores selection when switching back to quest phase documents
    /// - Cleans up selection cache when documents are closed
    /// 
    /// Navigation:
    /// - Respects GraphEditorState system for viewport positioning
    /// - Auto-centers on phase node when navigating back to parent
    /// 
    /// Memory leak protection:
    /// - Document switching: CleanupEventSubscription() -> EstablishEventSubscription() 
    /// - Document closing: DockedViews.CollectionChanged -> Dispose() when document removed
    /// - App shutdown: Finalizer -> Dispose(false) -> Cleanup fallback
    /// </summary>
    public partial class QuestPhaseGraphView : UserControl, IDisposable
    {
        // Navigation memory: tracks which child was last visited from each node in each direction
        private readonly Dictionary<(uint nodeId, Key direction), uint> _navigationMemory = new();
        private readonly List<uint> _navigationHistory = new();
        
        // Zoom preservation: tracks zoom level when entering each phase
        private readonly Dictionary<RedGraph, double> _phaseEntryZoomLevels = new();


        // Document switching tracking for node deselection
        private AppViewModel? _appViewModel;
        private IDocumentViewModel? _lastActiveDocument;
        private bool _disposed = false;
        private IDocumentViewModel? _currentDocument; // Track current document for disposal detection
        
        // Node selection persistence across document switches
        private static readonly Dictionary<string, (uint nodeId, int graphLevel)> s_documentNodeSelections = new();

        public QuestPhaseGraphView()
        {
            InitializeComponent();
            DataContextChanged += OnDataContextChanged;
            
            // Add keyboard shortcut for subgraph navigation (Tab key)
            KeyDown += OnKeyDown;
        }

        /// <summary>
        /// Establish event subscription for document switching detection
        /// </summary>
        private void EstablishEventSubscription()
        {
            if (_disposed)
            {
                return; // Don't establish subscription if disposed
            }

            // Clean up any existing subscription first
            CleanupEventSubscription();
            
            _appViewModel = Locator.Current.GetService<AppViewModel>();
            if (_appViewModel != null)
            {
                _appViewModel.PropertyChanged += OnAppViewModelPropertyChanged;
                _lastActiveDocument = _appViewModel.ActiveDocument;
            }
        }

        /// <summary>
        /// Clean up event subscription
        /// </summary>
        private void CleanupEventSubscription()
        {
            if (_appViewModel != null)
            {
                _appViewModel.PropertyChanged -= OnAppViewModelPropertyChanged;
                _appViewModel.DockedViews.CollectionChanged -= OnDockedViewsCollectionChanged;
                _appViewModel = null;
            }
        }

        /// <summary>
        /// Monitor document closing by watching DockedViews collection changes
        /// </summary>
        private void MonitorDocumentClosing()
        {
            if (_appViewModel == null)
            {
                return;
            }

            // Get the current document from our DataContext
            var viewModel = DataContext as QuestPhaseGraphViewModel;
            _currentDocument = viewModel?.Parent;

            if (_currentDocument != null)
            {
                // Subscribe to DockedViews changes to detect document removal
                _appViewModel.DockedViews.CollectionChanged += OnDockedViewsCollectionChanged;
            }
        }

        /// <summary>
        /// Handle DockedViews collection changes to detect document closing
        /// </summary>
        private void OnDockedViewsCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            if (_disposed || e.Action != NotifyCollectionChangedAction.Remove)
            {
                return;
            }

            // Check if our current document was removed (closed)
            if (e.OldItems != null && _currentDocument != null)
            {
                foreach (var removedItem in e.OldItems)
                {
                    if (ReferenceEquals(removedItem, _currentDocument))
                    {
                        // Clean up selection cache for closed document
                        CleanupSelectionCache(_currentDocument);
                        
                        Dispose();
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Clean up selection cache for a specific document
        /// </summary>
        private void CleanupSelectionCache(IDocumentViewModel? document)
        {
            if (document == null)
            {
                return;
            }

            var documentKey = GetDocumentKey(document);
            if (documentKey != null)
            {
                s_documentNodeSelections.Remove(documentKey);
            }
        }



        /// <summary>
        /// Dispose pattern implementation
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Protected dispose method
        /// </summary>
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                // Clean up managed resources
                CleanupEventSubscription();
                
                // Clear zoom level tracking to prevent memory leaks
                _phaseEntryZoomLevels.Clear();
                
                // Clear document references
                _currentDocument = null;
                _lastActiveDocument = null;
                
                // Clean up event handlers (safe to unsubscribe even if not subscribed)
                DataContextChanged -= OnDataContextChanged;
                KeyDown -= OnKeyDown;
                
                _disposed = true;
                Locator.Current.GetService<ILoggerService>()?.Info("[QuestPhaseGraphView] View disposed successfully - all resources cleaned up");
            }
        }

        /// <summary>
        /// Finalizer - cleanup if Dispose wasn't called
        /// </summary>
        ~QuestPhaseGraphView() => Dispose(false);

        /// <summary>
        /// Handle keyboard shortcuts for nested graph navigation
        /// </summary>
        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Tab)
            {
                HandleSubGraph();
                e.Handled = true;
            }
        }
        
        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (_disposed)
            {
                return; // Don't process if disposed
            }

            // Clean up old subscription when switching contexts
            if (e.OldValue is QuestPhaseGraphViewModel)
            {
                CleanupEventSubscription();
            }

            if (e.NewValue is not QuestPhaseGraphViewModel viewModel)
            {
                return;
            }

            // Establish event subscription when we have a valid quest phase document
            EstablishEventSubscription();
            
            // Monitor document closing by watching DockedViews collection
            MonitorDocumentClosing();

            viewModel.MainGraph.Connections.CollectionChanged += (_, _) => UpdateConnectionPathTypes(viewModel.MainGraph);
            viewModel.MainGraph.Nodes.CollectionChanged += (_, _) => UpdateConnectionPathTypes(viewModel.MainGraph);

            Dispatcher.BeginInvoke(new Action(() =>
            {
                SetupConnectionTemplate();
                UpdateConnectionPathTypes(viewModel.MainGraph);
                BuildBreadcrumb(); // Initialize breadcrumb navigation
                
                // Add a small delay to ensure smooth loading experience
                Dispatcher.BeginInvoke(new Action(() =>
                {
                    viewModel.SetGraphLoaded();
                }), DispatcherPriority.Background);
            }), DispatcherPriority.Loaded);
        }



        /// <summary>
        /// Handle document switching to deselect nodes when switching between quest phase and scene documents
        /// </summary>
        private void OnAppViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (_disposed || e.PropertyName != nameof(AppViewModel.ActiveDocument) || _appViewModel == null)
            {
                return;
            }

            var currentDocument = _appViewModel.ActiveDocument;
            
            // Debug logging to see if method is being called
            var fromType = _lastActiveDocument != null ? 
                (IsQuestPhaseDocument(_lastActiveDocument) ? "QuestPhase" : 
                 IsSceneDocument(_lastActiveDocument) ? "Scene" : "Other") : "None";
            var toType = currentDocument != null ? 
                (IsQuestPhaseDocument(currentDocument) ? "QuestPhase" : 
                 IsSceneDocument(currentDocument) ? "Scene" : "Other") : "None";
            
            // Store current selection when switching away from quest phase documents
            if (IsQuestPhaseDocument(_lastActiveDocument))
            {
                StoreCurrentSelection(_lastActiveDocument);
            }
            
            // Check if we should deselect based on document switching
            if (ShouldDeselect(_lastActiveDocument, currentDocument))
            {
                // Clear node selection in editor
                if (QuestPhaseGraphEditor?.Editor?.SelectedItems != null)
                {
                    QuestPhaseGraphEditor.Editor.SelectedItems.Clear();
                }
                
                // Clear NodeSelectionService - this is crucial for property panel
                NodeSelectionService.Instance.SelectedNode = null;
            }



            // Restore selection when switching to quest phase documents FROM graph documents
            // (Only restore if we're coming from a graph document where selection was cleared)
            if (IsQuestPhaseDocument(currentDocument) && IsGraphDocument(_lastActiveDocument))
            {
                // Use a delay to ensure the view and graph are ready
                Dispatcher.BeginInvoke(new Action(() =>
                {
                    RestoreSelectionIfReady(currentDocument);
                }), DispatcherPriority.Background);
            }

            _lastActiveDocument = currentDocument;
        }

        /// <summary>
        /// Determine if we should deselect nodes based on document switching
        /// Clear selection when switching between any graph documents (quest phase or scene) to prevent property panel confusion
        /// </summary>
        private bool ShouldDeselect(IDocumentViewModel? fromDocument, IDocumentViewModel? toDocument)
        {
            // Don't deselect if staying in the same document
            if (fromDocument == toDocument)
            {
                return false;
            }

            // Check if we're switching away from a graph document (quest phase OR scene)
            var switchingAwayFromGraph = IsQuestPhaseDocument(fromDocument) || IsSceneDocument(fromDocument);
            
            // Check if we're switching to a graph document (quest phase OR scene)  
            var switchingToGraph = IsQuestPhaseDocument(toDocument) || IsSceneDocument(toDocument);

            // Deselect if switching between any graph documents to clear property panel
            return switchingAwayFromGraph && switchingToGraph;
        }

        /// <summary>
        /// Check if a document is a quest phase document
        /// </summary>
        private bool IsQuestPhaseDocument(IDocumentViewModel? document)
        {
            if (document is not RedDocumentViewModel redDoc)
            {
                return false;
            }

            return redDoc.TabItemViewModels.Any(tab => tab is QuestPhaseGraphViewModel);
        }

        /// <summary>
        /// Check if a document is a scene document
        /// </summary>
        private bool IsSceneDocument(IDocumentViewModel? document)
        {
            if (document is not RedDocumentViewModel redDoc)
            {
                return false;
            }

            return redDoc.TabItemViewModels.Any(tab => tab is SceneGraphViewModel);
        }

        /// <summary>
        /// Check if a document is any graph document (quest phase or scene)
        /// </summary>
        private bool IsGraphDocument(IDocumentViewModel? document) =>
            IsQuestPhaseDocument(document) || IsSceneDocument(document);

        /// <summary>
        /// Store the currently selected node for the given document
        /// </summary>
        private void StoreCurrentSelection(IDocumentViewModel? document)
        {
            if (document == null)
            {
                return;
            }

            var documentKey = GetDocumentKey(document);
            if (documentKey == null)
            {
                return;
            }

            var currentSelectedNode = NodeSelectionService.Instance.SelectedNode;
            if (currentSelectedNode != null)
            {
                // Get the current graph level from the document's quest phase view model
                var graphLevel = GetCurrentGraphLevel(document);
                
                // Store the selected node ID and graph level
                s_documentNodeSelections[documentKey] = (currentSelectedNode.UniqueId, graphLevel);
            }
            // If no selection, don't store anything - let previous selection remain if it exists
        }

        /// <summary>
        /// Restore selection only if the view is ready and this is the active document
        /// </summary>
        private void RestoreSelectionIfReady(IDocumentViewModel? activeDocument)
        {
            if (activeDocument == null || _disposed ||
                DataContext as QuestPhaseGraphViewModel is not QuestPhaseGraphViewModel viewModel)

            {
                return;
            }

            // Check if this view's document matches the active document
            if (viewModel.Parent != activeDocument)
            {
                return;
            }

            // Check if the graph is ready
            if (viewModel.MainGraph?.Nodes == null)
            {
                return;
            }

            RestoreSelection(activeDocument);
        }

        /// <summary>
        /// Restore the previously selected node for the given document
        /// </summary>
        private void RestoreSelection(IDocumentViewModel? document)
        {
            if (document == null || _disposed || GetDocumentKey(document) is not string documentKey ||
                string.IsNullOrEmpty(documentKey) ||
                !s_documentNodeSelections.TryGetValue(documentKey, out var selection))
            {
                return;
            }

            var (nodeId, graphLevel) = selection;

            // Navigate to the correct graph level first
            var navigated = NavigateToGraphLevel(document, graphLevel);
            if (!navigated)
            {
                // Fallback: Try to find the node in the root graph
                // This handles cases where subgraph context is lost during document switching
                var restored = SearchAndNavigateToNode(nodeId);
                if (!restored)
                {
                    // Node doesn't exist anywhere, remove from cache
                    s_documentNodeSelections.Remove(documentKey);
                }

                return;
            }

            // Now try to select the node at the correct graph level
            var restoredAtLevel = SearchAndNavigateToNode(nodeId);
            if (!restoredAtLevel)
            {
                // Fallback: Navigate back to root and try there
                NavigateToGraphLevel(document, 0);
                var restoredAtRoot = SearchAndNavigateToNode(nodeId);
                if (!restoredAtRoot)
                {
                    // Node no longer exists anywhere, remove from cache
                    s_documentNodeSelections.Remove(documentKey);
                }
            }
        }

        /// <summary>
        /// Get a unique key for a document (using file path)
        /// </summary>
        private string? GetDocumentKey(IDocumentViewModel? document) => document?.FilePath;

        /// <summary>
        /// Get the current graph level for the document (0 = root, 1+ = subgraph levels)
        /// </summary>
        private int GetCurrentGraphLevel(IDocumentViewModel? document)
        {
            if (document is not RedDocumentViewModel redDoc)
            {
                return 0;
            }

            // Find the quest phase view model for this document
            var questPhaseViewModel = redDoc.TabItemViewModels.OfType<QuestPhaseGraphViewModel>().FirstOrDefault();
            if (questPhaseViewModel?.History == null)
            {
                return 0;
            }

            // Return the current graph level (History count - 1, where 0 is root)
            return questPhaseViewModel.History.Count - 1;
        }

        /// <summary>
        /// Navigate to the specified graph level (0 = root, 1+ = subgraph levels)
        /// Note: Can only navigate to previous levels or stay at current level
        /// </summary>
        private bool NavigateToGraphLevel(IDocumentViewModel? document, int targetLevel)
        {
            if (document is not RedDocumentViewModel redDoc)
            {
                return false;
            }

            // Find the quest phase view model for this document
            var questPhaseViewModel = redDoc.TabItemViewModels.OfType<QuestPhaseGraphViewModel>().FirstOrDefault();
            if (questPhaseViewModel?.History == null)
            {
                return false;
            }

            var currentLevel = questPhaseViewModel.History.Count - 1;

            // If we're already at the target level, no navigation needed
            if (currentLevel == targetLevel)
            {
                return true;
            }

            // If target level is deeper than current, we can't navigate there without specific path
            if (targetLevel > currentLevel)
            {
                return false;
            }

            // Navigate back to the target level by removing history entries
            while (questPhaseViewModel.History.Count - 1 > targetLevel)
            {
                if (questPhaseViewModel.History.Count <= 1)
                {
                    break; // Don't remove the root graph
                }

                // Remove the last history entry and navigate to the previous level
                questPhaseViewModel.History.RemoveAt(questPhaseViewModel.History.Count - 1);
                var parentGraph = questPhaseViewModel.History[^1];
                
                // Update the current graph
                if (QuestPhaseGraphEditor != null)
                {
                    QuestPhaseGraphEditor.SetCurrentValue(GraphEditorView.SourceProperty, parentGraph);
                    
                    // Update breadcrumb
                    BuildBreadcrumb();
                }
            }

            return questPhaseViewModel.History.Count - 1 == targetLevel;
        }

        private void SetupConnectionTemplate()
        {
            if (QuestPhaseGraphEditor?.Editor == null ||
                Resources["QuestConnectionTemplate"] is not DataTemplate questConnectionTemplate)
            {
                return;
            }

            QuestPhaseGraphEditor.Editor.SetCurrentValue(Nodify.NodifyEditor.ConnectionTemplateProperty,
                questConnectionTemplate);
            
        }

        private void UpdateConnectionPathTypes(RedGraph? graph)
        {
            if (graph?.Nodes == null || graph?.Connections == null)
            {
                return;
            }

            var pathTypes = CalculateConnectionPathTypes(graph);

            foreach (var connection in graph.Connections.OfType<QuestConnectionViewModel>())
            {
                connection.PathType = pathTypes.GetValueOrDefault(connection, 2); // Default to live path
            }
        }

        private Dictionary<QuestConnectionViewModel, int> CalculateConnectionPathTypes(RedGraph? graph)
        {
            var connectionTypeMap = new Dictionary<QuestConnectionViewModel, int>();
            if (graph?.Connections == null)
            {
                return connectionTypeMap;
            }

            const int deadEndNodeThreshold = 4;
            const int deadEndPathType = 1;
            const int livePathType = 2;

            var adjacencyMap = BuildAdjacencyMap(graph);
            var endNodeIds = graph.Nodes.OfType<questEndNodeDefinitionWrapper>().Select(n => n.UniqueId).ToList();

            foreach (var connection in graph.Connections.OfType<QuestConnectionViewModel>())
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

            foreach (var connection in graph.Connections.OfType<QuestConnectionViewModel>())
            {
                var sourceId = connection.Source.OwnerId;
                var targetId = connection.Target.OwnerId;

                if (!adjacencyMap.ContainsKey(sourceId))
                {
                    adjacencyMap[sourceId] = new List<uint>();
                }

                adjacencyMap[sourceId].Add(targetId);
            }

            return adjacencyMap;
        }

        /// <summary>
        /// Smart navigation with memory - cycles through multiple connections in the same direction
        /// </summary>
        private WolvenKit.App.ViewModels.GraphEditor.NodeViewModel? FindNextNodeInDirection(
            RedGraph? graph, 
            WolvenKit.App.ViewModels.GraphEditor.NodeViewModel currentNode, 
            Key direction)
        {
            if (graph?.Nodes == null)
            {
                return null;
            }

            // Get all connected nodes in the specified direction
            var connectedCandidates = GetConnectedNodesInDirection(graph, currentNode, direction);

            return connectedCandidates.Count switch
            {
                // No connected nodes, fallback to spatial navigation for any node in that direction
                <= 0 => GetNearestNodeInDirection(graph, currentNode, direction),
                // If we have multiple connected options, use memory to cycle through them
                > 1 => GetNextNodeWithMemory(currentNode.UniqueId, direction, connectedCandidates),
                // Single connected option
                _ => connectedCandidates[0]
            };

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

                if (distance < 10)
                {
                    continue;
                }

                var isInDirection = direction switch
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
        private WolvenKit.App.ViewModels.GraphEditor.NodeViewModel? GetNearestNodeInDirection(
            RedGraph graph, 
            WolvenKit.App.ViewModels.GraphEditor.NodeViewModel currentNode, 
            Key direction)
        {
            var candidates = new List<(WolvenKit.App.ViewModels.GraphEditor.NodeViewModel node, double distance)>();
            var currentX = currentNode.Location.X;
            var currentY = currentNode.Location.Y;

            foreach (var node in graph.Nodes)
            {
                if (node.UniqueId == currentNode.UniqueId)
                {
                    continue;
                }

                var deltaX = node.Location.X - currentX;
                var deltaY = node.Location.Y - currentY;
                var distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

                if (distance < 10)
                {
                    continue;
                }

                var isInDirection = direction switch
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
        private void CenterViewOnSelectedNode(RedGraph? graph,
            WolvenKit.App.ViewModels.GraphEditor.NodeViewModel? targetNode)
        {
            if (QuestPhaseGraphEditor?.Editor == null || graph == null || targetNode == null)
            {
                return;
            }

            try 
            {
                var editor = QuestPhaseGraphEditor.Editor;
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
                {
                    return; // Node is already well visible, no need to pan
                }

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
                AnimateViewportTo(new System.Windows.Point(targetX, targetY), TimeSpan.FromMilliseconds(300));
            }
            catch (Exception)
            {
                // Silently handle any viewport manipulation errors
            }
        }

        /// <summary>
        /// Animate viewport to target location with smooth easing
        /// </summary>
        private void AnimateViewportTo(System.Windows.Point targetLocation, TimeSpan duration)
        {
            if (QuestPhaseGraphEditor?.Editor == null)
            {
                return;
            }

            var editor = QuestPhaseGraphEditor.Editor;
            var startLocation = editor.ViewportLocation;
            var startTime = DateTime.Now;
            
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(16)
            };

            timer.Tick += (_, _) =>
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
                
                editor.ViewportLocation = new System.Windows.Point(currentX, currentY);
            };
            
            timer.Start();
        }

        /// <summary>
        /// Search for a node by its ID and navigate to it
        /// </summary>
        public bool SearchAndNavigateToNode(uint nodeId)
        {
            if (_disposed || DataContext is not QuestPhaseGraphViewModel viewModel)
            {
                return false; // Don't operate on disposed view
            }

            if (viewModel.MainGraph?.Nodes == null)
            {
                return false;
            }

            // Get the currently active graph (might be root or subgraph)
            var currentGraph = QuestPhaseGraphEditor?.Source ?? viewModel.MainGraph;

            // Find the node with the specified ID in the current graph
            var targetNode = currentGraph.Nodes.FirstOrDefault(n => n.UniqueId == nodeId);
            if (targetNode == null)
            {
                return false;
            }

            // Select the node
            QuestPhaseGraphEditor?.Editor?.SelectedItems?.Clear();
            QuestPhaseGraphEditor?.Editor?.SelectedItems?.Add(targetNode);
            NodeSelectionService.Instance.SelectedNode = targetNode;

            // Center view on the node
            CenterViewOnSelectedNode(currentGraph, targetNode);

            return true;
        }

        /// <summary>
        /// Shows a dialog to go directly to a node by its ID
        /// </summary>
        public void ShowGoToNodeDialog()
        {
            if (_disposed)
            {
                return; // Don't operate on disposed view
            }

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
                    Interactions.ShowMessageBox(
                        $"Node with ID {nodeId} not found.",
                        "Go to Node",
                        WMessageBoxButtons.Ok,
                        WMessageBoxImage.Information);
                }
            }
            else
            {
                Interactions.ShowMessageBox(
                    "Please enter a valid numeric Node ID.",
                    "Invalid Input",
                    WMessageBoxButtons.Ok,
                    WMessageBoxImage.Warning);
            }
        }

        /// <summary>
        /// Handles keyboard shortcuts for node deletion and navigation
        /// </summary>
        private void QuestPhaseGraphView_OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
            var viewModel = DataContext as QuestPhaseGraphViewModel;
            if (viewModel?.MainGraph == null || QuestPhaseGraphEditor?.Source == null)
            {
                return;
            }

            // Get the currently displayed graph (could be main graph or a subgraph)
            var currentGraph = QuestPhaseGraphEditor.Source;

            // Shortcut: Delete key to soft delete, Shift+Delete for hard delete
            if (e.Key == Key.Delete)
            {
                // Use SelectedNodes from underlying GraphEditor
                var selectedNodes = QuestPhaseGraphEditor?.Editor?.SelectedItems?
                    .OfType<BaseQuestViewModel>()
                    .Where(node => !(node is questStartNodeDefinitionWrapper || node is questEndNodeDefinitionWrapper)) // Can't delete start/end nodes
                    .ToList();

                if (selectedNodes is { Count: > 0 })
                {
                    if (Keyboard.Modifiers.HasFlag(ModifierKeys.Shift))
                    {
                        // Shift+Del: Hard delete (permanent removal)
                        var nodeViewModels = selectedNodes.Cast<object>().ToList();
                        currentGraph.RemoveNodes(nodeViewModels);
                    }
                    else
                    {
                        // Del: Smart delete based on node type
                        foreach (var node in selectedNodes)
                        {
                            if (node is BaseQuestViewModel questNode)
                            {
                                // ReplaceNodeWithQuestDeletionMarker now handles the logic internally:
                                // - Signal-stopping nodes get replaced with deletion markers
                                // - Non-signal-stopping nodes get hard deleted
                                // - Deletion markers always get hard deleted
                                currentGraph.ReplaceNodeWithQuestDeletionMarker(questNode);
                            }
                            else
                            {
                                // Non-quest nodes get hard deleted
                                var nodeAsObject = (object)node;
                                currentGraph.RemoveNodes(new List<object> { nodeAsObject });
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
                    currentGraph.DuplicateNode(selectedNode);
                    e.Handled = true;
                }
            }

            // Shortcut: Ctrl+N to open new node dialog
            if (e.Key == Key.N && Keyboard.Modifiers.HasFlag(ModifierKeys.Control))
            {
                OpenNewNodeDialog(currentGraph);
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
                {
                    return;
                }

                var next = FindNextNodeInDirection(currentGraph, currentNode, e.Key);

                if (next != null)
                {
                    // Update navigation memory
                    UpdateNavigationMemory(currentNode.UniqueId, e.Key, next.UniqueId);
                    
                    // Update selection in editor
                    QuestPhaseGraphEditor?.Editor?.SelectedItems?.Clear();
                    QuestPhaseGraphEditor?.Editor?.SelectedItems?.Add(next);
                    NodeSelectionService.Instance.SelectedNode = next;
                    
                    // Auto-scroll graph view to keep selected node visible
                    CenterViewOnSelectedNode(currentGraph, next);
                    
                    e.Handled = true;
                }
            }
        }

        /// <summary>
        /// Open the new node type selector dialog
        /// </summary>
        private async void OpenNewNodeDialog(RedGraph? graph)
        {
            if (graph?.GraphType != RedGraphType.Quest)
            {
                return;
            }

            try
            {
                if (Locator.Current.GetService<AppViewModel>() is not { } appViewModel)
                {
                    return;
                }

                // Get quest node types
                var questNodeTypes = graph.GetQuestNodeTypes();
                
                var questTypes = questNodeTypes
                    .Select(x => new TypeEntry(GraphNodeStyling.GetTitleForNodeType(x), "Quest", x))
                    .OrderBy(x => x.Name)
                    .ToList();

                // Create and show the type selector dialog
                await appViewModel.SetActiveDialog(new TypeSelectorDialogViewModel(questTypes)
                {
                    DialogHandler = model =>
                    {
                        appViewModel.CloseDialogCommand.Execute(null);
                        if (model is TypeSelectorDialogViewModel { SelectedEntry.UserData: Type selectedType })
                        {
                            // Create new node at current viewport center
                            var viewportCenter = GetViewportCenter();
                            graph.CreateQuestNode(selectedType, viewportCenter);
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
        private System.Windows.Point GetViewportCenter()
        {
            if (QuestPhaseGraphEditor?.Editor == null)
            {
                return new System.Windows.Point(0, 0);
            }

            var viewport = QuestPhaseGraphEditor.Editor.ViewportLocation;
            var size = QuestPhaseGraphEditor.Editor.ViewportSize;
            
            return new System.Windows.Point(
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
            QuestPhaseGraphEditor?.Connection_OnRightClick(sender, e);
        }

        /// <summary>
        /// Selects a node by its ID
        /// </summary>
        private void SelectNodeById(uint nodeId)
        {
            if (DataContext is not QuestPhaseGraphViewModel viewModel ||
                viewModel.MainGraph?.Nodes == null ||
                QuestPhaseGraphEditor?.Editor == null ||
                QuestPhaseGraphEditor?.Source == null)
            {
                return;
            }

            // Use the currently displayed graph instead of always using main graph
            var currentGraph = QuestPhaseGraphEditor.Source;

            // Find the node with the specified ID in the current graph
            if (currentGraph.Nodes.FirstOrDefault(n => n.UniqueId == nodeId) is not { } targetNode)
            {
                return;
            }

            // Clear current selection
            QuestPhaseGraphEditor.Editor?.SelectedItems?.Clear();

            // Select the target node
            QuestPhaseGraphEditor.Editor?.SelectedItems?.Add(targetNode);

            // Update the NodeSelectionService
            NodeSelectionService.Instance.SelectedNode = targetNode;
        }

        /// <summary>
        /// Handle double-click on nodes for nested graph navigation
        /// </summary>
        private void Editor_OnNodeDoubleClick(object sender, RoutedEventArgs e) => HandleSubGraph();

        /// <summary>
        /// Handle navigation to sub-graphs (phase nodes) or back to parent graphs
        /// </summary>
        private void HandleSubGraph()
        {
            var viewModel = DataContext as QuestPhaseGraphViewModel;
            if (viewModel == null || QuestPhaseGraphEditor?.Editor == null)
            {
                return;
            }

            var selectedNode = QuestPhaseGraphEditor.SelectedNode;

            // Special handling for scene nodes - offer to open in Scene Editor
            if (selectedNode is questSceneNodeDefinitionWrapper sceneNode)
            {
                HandleSceneNodeRedirect(sceneNode);
                return;
            }

            // Navigation into phase subgraph
            if (selectedNode is IGraphProvider provider)
            {
                var subGraph = provider.Graph;
                if (subGraph == null)
                {
                    return;
                }

                // Store current zoom level before entering the phase
                if (QuestPhaseGraphEditor?.Editor != null)
                {
                    _phaseEntryZoomLevels[subGraph] = QuestPhaseGraphEditor.Editor.ViewportZoom;
                }

                // Set document reference for property sync
                subGraph.DocumentViewModel ??= QuestPhaseGraphEditor?.Source.DocumentViewModel;

                // Handle quest phase node state tracking
                if (selectedNode.Data is questPhaseNodeDefinition { PhaseResource.IsSet: false } ph)
                {
                    subGraph.StateParents = QuestPhaseGraphEditor?.Source.StateParents + "." + ph.Id;
                    subGraph.DocumentViewModel = QuestPhaseGraphEditor?.Source.DocumentViewModel;
                }

                // Show loading overlay for subgraph navigation
                viewModel.IsGraphLoading = true;

                // Add to navigation history and navigate to subgraph
                viewModel.History.Add(subGraph);
                QuestPhaseGraphEditor?.SetCurrentValue(GraphEditorView.SourceProperty, subGraph);

                BuildBreadcrumb();
                
                // Hide loading overlay - let GraphEditorState handle viewport positioning
                Dispatcher.BeginInvoke(new Action(() =>
                {
                    viewModel.SetGraphLoaded();
                }), DispatcherPriority.Background);
                
                return;
            }

            // Navigation back to parent graph (from input/output nodes)
            if (selectedNode is questInputNodeDefinitionWrapper or questOutputNodeDefinitionWrapper)
            {
                if (viewModel.History.Count > 1)
                {
                    // Show loading overlay for navigation back
                    viewModel.IsGraphLoading = true;

                    // Navigate back to parent
                    var currentSubGraph = viewModel.History[^1];
                    viewModel.History.Remove(viewModel.History[^1]);
                    var parentGraph = viewModel.History[^1];
                    QuestPhaseGraphEditor.SetCurrentValue(GraphEditorView.SourceProperty, parentGraph);

                    BuildBreadcrumb();
                    
                    // Hide loading overlay and auto-center on phase node we came from
                    Dispatcher.BeginInvoke(new Action(() =>
                    {
                        // Auto-center on the phase node in the parent graph
                        AutoCenterOnPhaseNodeInParent(parentGraph, currentSubGraph);
                        viewModel.SetGraphLoaded();
                    }), DispatcherPriority.Loaded);
                }
            }
        }

        /// <summary>
        /// Handle scene node redirect - ask user if they want to open in Scene Editor
        /// </summary>
        private void HandleSceneNodeRedirect(questSceneNodeDefinitionWrapper sceneNode)
        {
            if (sceneNode.Data is not questSceneNodeDefinition sceneData)
            {
                return;
            }

            if (sceneData.SceneFile.DepotPath == ResourcePath.Empty || !sceneData.SceneFile.DepotPath.IsResolvable)
            {
                return;
            }

            var scenePath = sceneData.SceneFile.DepotPath.GetResolvedText();
            var sceneFileName = System.IO.Path.GetFileName(scenePath);

            // Show dialog asking user if they want to open in Scene Editor
            var result = Interactions.ShowQuestionYesNo((
                $"This quest node references a scene file:\n\n{sceneFileName}\n\nWould you like to open this scene in the Scene Editor instead of viewing it within the quest graph? (Recommended)",
                "Open Scene in Scene Editor?"));

            if (result)
            {
                // Open the scene file in Scene Editor and automatically switch to it
                try
                {
                    var appViewModel = Locator.Current.GetService<AppViewModel>();
                    if (appViewModel != null)
                    {
                        // Open the file
                        appViewModel.OpenFileFromDepotPath(sceneData.SceneFile.DepotPath);
                        
                        // Ensure the tab is selected by finding and activating the newly opened document
                        // Add a small delay to allow the file to be fully loaded before switching
                        Dispatcher.BeginInvoke(new Action(() =>
                        {
                            try
                            {
                                var scenePathString = sceneData.SceneFile.DepotPath.GetResolvedText();
                                if (scenePathString != null)
                                {
                                    var targetDocument = appViewModel.DockedViews
                                        .OfType<RedDocumentViewModel>()
                                        .FirstOrDefault(doc => doc.RelativePath == scenePathString);
                                    
                                    if (targetDocument != null)
                                    {
                                        appViewModel.ActiveDocument = targetDocument;
                                    }
                                }
                            }
                            catch (Exception)
                            {
                                // Tab switching failed, but file was opened - not critical
                            }
                        }), DispatcherPriority.Background);
                    }
                }
                catch (Exception ex)
                {
                    // Fallback to showing error message
                    Interactions.ShowMessageBox(
                        $"Failed to open scene file:\n{ex.Message}",
                        "Error Opening Scene",
                        WMessageBoxButtons.Ok,
                        WMessageBoxImage.Error);
                }
            }
            // If user clicked No, do nothing (don't load the scene subgraph)
        }

        /// <summary>
        /// Build the breadcrumb navigation showing current graph level
        /// </summary>
        private void BuildBreadcrumb()
        {
            var viewModel = DataContext as QuestPhaseGraphViewModel;
            if (viewModel == null)
            {
                return;
            }

            Breadcrumb.Children.Clear();

            for (var i = 0; i < viewModel.History.Count; i++)
            {
                var breadcrumbText = GetBreadcrumbText(viewModel.History[i]);
                AddBreadcrumbElement(breadcrumbText, viewModel.History[i]);

                if (i < viewModel.History.Count - 1)
                {
                    AddBreadcrumbElement(">", null);
                }
            }

            void AddBreadcrumbElement(string text, RedGraph? graph)
            {
                if (Breadcrumb.Children.Count > 0)
                {
                    text = " " + text;
                }

                var textBlock = new TextBlock 
                { 
                    Text = text, 
                    Tag = graph,
                    Foreground = graph != null ? Brushes.White : Brushes.Gray,
                    FontWeight = graph != null ? FontWeights.Medium : FontWeights.Normal,
                    Cursor = graph != null ? Cursors.Hand : Cursors.Arrow,
                    VerticalAlignment = VerticalAlignment.Center
                };

                if (graph != null)
                {
                    textBlock.PreviewMouseDown += BreadcrumbElement_OnPreviewMouseDown;
                    
                    // Add hover effects
                    textBlock.MouseEnter += (_, _) =>
                        textBlock.Foreground =
                            new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF6B35"));
                    textBlock.MouseLeave += (_, _) => textBlock.Foreground = Brushes.White;
                }

                Breadcrumb.Children.Add(textBlock);
            }
        }

        /// <summary>
        /// Get the appropriate breadcrumb text for a graph level
        /// </summary>
        private string GetBreadcrumbText(RedGraph? graph)
        {
            if (graph == null)
            {
                return "";
            }

            var baseTitle = graph.Title;
            
            // Check if this is a phase node without a phaseResource file path
            if (graph.StateParents?.Contains('.') != true)
            {
                return baseTitle;
            }

            var parts = graph.StateParents.Split('.');
            if (parts.Length <= 1)
            {
                return baseTitle;
            }

            var nodeId = parts[^1]; // Get the last part (node ID)

            // Check if the graph has a phaseResource file path
            // If the baseTitle is just "Phase" or similar generic title, add the node ID
            if (baseTitle == "Phase" || string.IsNullOrEmpty(baseTitle) ||
                baseTitle.StartsWith("questPhaseNodeDefinition"))
            {
                return $"Phase [{nodeId}]";
            }

            return baseTitle;
        }



        /// <summary>
        /// Handle clicking on breadcrumb elements to navigate to that level
        /// </summary>
        private void BreadcrumbElement_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var viewModel = DataContext as QuestPhaseGraphViewModel;
            if (viewModel == null || QuestPhaseGraphEditor?.Editor == null)
            {
                return;
            }

            if (sender is not TextBlock { Tag: RedGraph graph } block)
            {
                return;
            }

            if (viewModel.History.Count == 1)
            {
                return;
            }

            if (block.Text.Trim() == ">")
            {
                return;
            }


            // Show loading overlay for breadcrumb navigation
            viewModel.IsGraphLoading = true;

            // Check if we're navigating "up" (to a parent level) and get the subgraph we're coming from
            var currentGraph = viewModel.History[^1]; // The current deepest level
            var isNavigatingUp = viewModel.History.IndexOf(graph) < viewModel.History.IndexOf(currentGraph);
            RedGraph? childGraph = null;
            
            if (isNavigatingUp)
            {
                // Find the immediate child of the target graph in the navigation path
                var targetIndex = viewModel.History.IndexOf(graph);
                if (targetIndex >= 0 && targetIndex + 1 < viewModel.History.Count)
                {
                    childGraph = viewModel.History[targetIndex + 1];
                }
            }

            // Navigate to the selected graph level
            QuestPhaseGraphEditor.SetCurrentValue(GraphEditorView.SourceProperty, graph);

            // Remove all history entries after the selected one
            for (var i = viewModel.History.Count - 1; i >= 0; i--)
            {
                if (ReferenceEquals(viewModel.History[i], graph))
                {
                    break;
                }

                viewModel.History.RemoveAt(i);
            }

            BuildBreadcrumb();
            
            // Hide loading overlay and auto-center if navigating up
            Dispatcher.BeginInvoke(new Action(() =>
            {
                if (isNavigatingUp && childGraph != null)
                {
                    AutoCenterOnPhaseNodeInParent(graph, childGraph);
                }
                viewModel.SetGraphLoaded();
            }), DispatcherPriority.Loaded);
        }

        /// <summary>
        /// Auto-center the viewport on the phase node that contains the subgraph we came from
        /// </summary>
        private void AutoCenterOnPhaseNodeInParent(RedGraph parentGraph, RedGraph subGraph)
        {
            if (parentGraph?.Nodes == null || QuestPhaseGraphEditor?.Editor == null)
            {
                return;
            }

            // Find the phase node that contains this subgraph
            var phaseNode = parentGraph.Nodes
                .OfType<questPhaseNodeDefinitionWrapper>()
                .FirstOrDefault(node => ReferenceEquals(node.Graph, subGraph));

            // If reference equality fails, try to find by StateParents
            if (phaseNode == null && !string.IsNullOrEmpty(subGraph.StateParents))
            {
                var stateParentParts = subGraph.StateParents.Split('.');
                if (stateParentParts.Length > 0)
                {
                    // Get the last part which should be the node ID
                    var nodeIdString = stateParentParts[^1];
                    if (uint.TryParse(nodeIdString, out var nodeId))
                    {
                        phaseNode = parentGraph.Nodes
                            .OfType<questPhaseNodeDefinitionWrapper>()
                            .FirstOrDefault(node => node.Data is questPhaseNodeDefinition phaseData && phaseData.Id == nodeId);
                    }
                }
            }
            if (phaseNode != null)
            {
                // Force center on the phase node with original zoom and select it - delay to ensure it runs after GraphEditorState
                Dispatcher.BeginInvoke(new Action(() =>
                {
                    ForceCenterOnNodeWithZoom(phaseNode, subGraph);
                    
                    // Auto-select the phase node to provide visual feedback
                    QuestPhaseGraphEditor?.Editor?.SelectedItems?.Clear();
                    QuestPhaseGraphEditor?.Editor?.SelectedItems?.Add(phaseNode);
                    NodeSelectionService.Instance.SelectedNode = phaseNode;
                }), DispatcherPriority.ApplicationIdle);
            }
        }

        /// <summary>
        /// Force center the viewport on a specific node (always centers, even if node is already visible)
        /// </summary>
        private void ForceCenterOnNode(WolvenKit.App.ViewModels.GraphEditor.NodeViewModel? targetNode)
        {
            if (QuestPhaseGraphEditor?.Editor == null || targetNode == null)
            {
                return;
            }

            try
            {
                var editor = QuestPhaseGraphEditor.Editor;
                var nodeLocation = targetNode.Location;
                var viewportSize = editor.ViewportSize;
                
                // Calculate target viewport location to center the node
                var targetX = nodeLocation.X - (viewportSize.Width / 2) + (targetNode.Size.Width / 2);
                var targetY = nodeLocation.Y - (viewportSize.Height / 2) + (targetNode.Size.Height / 2);
                
                // Directly set the viewport location (no animation for immediate effect)
                editor.ViewportLocation = new System.Windows.Point(targetX, targetY);
            }
            catch (Exception)
            {
                // Silently handle any viewport manipulation errors
            }
        }

        /// <summary>
        /// Force center and restore zoom for a phase node when navigating back from subgraph
        /// </summary>
        private void ForceCenterOnNodeWithZoom(WolvenKit.App.ViewModels.GraphEditor.NodeViewModel targetNode, RedGraph subGraph)
        {
            if (QuestPhaseGraphEditor?.Editor == null || targetNode == null)
            {
                return;
            }

            try
            {
                var editor = QuestPhaseGraphEditor.Editor;
                
                // Restore the zoom level from when we entered the phase
                if (_phaseEntryZoomLevels.TryGetValue(subGraph, out var originalZoom))
                {
                    editor.ViewportZoom = originalZoom;
                    // Clean up the stored zoom level
                    _phaseEntryZoomLevels.Remove(subGraph);
                }
                
                var nodeLocation = targetNode.Location;
                var viewportSize = editor.ViewportSize;
                
                // Calculate target viewport location to center the node
                var targetX = nodeLocation.X - (viewportSize.Width / 2) + (targetNode.Size.Width / 2);
                var targetY = nodeLocation.Y - (viewportSize.Height / 2) + (targetNode.Size.Height / 2);
                
                // Directly set the viewport location (no animation for immediate effect)
                editor.ViewportLocation = new System.Windows.Point(targetX, targetY);
            }
            catch (Exception)
            {
                // Silently handle any viewport manipulation errors
            }
        }
    }
} 