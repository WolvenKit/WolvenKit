using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Msagl.Core.Geometry.Curves;
using Microsoft.Msagl.Core.Layout;
using Microsoft.Msagl.Core.Routing;
using Microsoft.Msagl.Layout.Layered;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Splat;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.GraphEditor.Nodes;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest.Internal;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;
using WolvenKit.App.Services;

namespace WolvenKit.App.ViewModels.GraphEditor;

public enum RedGraphType
{
    Invalid,
    Quest,
    Scene,
    Behavior
}

public partial class RedGraph : IDisposable
{
    private IRedType _data;

    private uint _currentSceneNodeId;
    private ushort _currentQuestNodeId;

    private bool _allowGraphSave = false;

    public RedGraphType GraphType { get; } = RedGraphType.Invalid;

    public string Title { get; }
    public ObservableCollection<object> CanvasItems { get; } = new();
    public ObservableCollection<NodeViewModel> Nodes { get; } = new();
    public ObservableCollection<ConnectionViewModel> Connections { get; } = new();
    public ObservableCollection<GraphCommentViewModel> Comments { get; } = new();
    public PendingConnectionViewModel PendingConnection { get; }

    public ICommand ConnectCommand { get; }
    public ICommand DisconnectCommand { get; }
    public ICommand ItemsDragCompletedCommand { get; }
    public ICommand RemoveCommentCommand { get; }

    public Nodify.NodifyEditor? Editor { get; set; }

    public RedDocumentViewModel? DocumentViewModel { get; set; }

    public string StateParents { get; set; } = "";

    private static ILoggerService? _loggerService;

    static RedGraph()
    {
        GenerateQuestWrapperMap();
    }

    public RedGraph(string title, IRedType data)
    {
        _data = data;
        if (_data is graphGraphDefinition)
        {
            GraphType = RedGraphType.Quest;
        }
        else if (_data is scnSceneResource)
        {
            GraphType = RedGraphType.Scene;
        }
        else if (_data is AIbehaviorResource)
        {
            GraphType = RedGraphType.Behavior;
        }

        Title = title;
        PendingConnection = new PendingConnectionViewModel();

        ConnectCommand = new RelayCommand(Connect);
        DisconnectCommand = new RelayCommand<BaseConnectorViewModel>(Disconnect);
        ItemsDragCompletedCommand = new RelayCommand(ItemsDragCompleted);
        RemoveCommentCommand = new RelayCommand<GraphCommentViewModel>(RemoveComment);

        _loggerService = Locator.Current.GetService<ILoggerService>();

        Comments.CollectionChanged += CommentsOnCollectionChanged;
        Nodes.CollectionChanged += NodesOnCollectionChanged;
    }

    public void Connect()
    {
        // When dragging TO a node (Target), only create dynamic INPUT if the node supports it
        if (PendingConnection.Target is IDynamicInputNode dynIn)
        {
            PendingConnection.Target = dynIn.AddInput();
        }
        // If target is a node that doesn't support dynamic inputs, don't proceed with connection
        else if (PendingConnection.Target is IGraphProvider targetNode && PendingConnection.Source is BaseConnectorViewModel)
        {
            return;
        }

        if (PendingConnection is { Source: OutputConnectorViewModel output1, Target: InputConnectorViewModel input1 })
        {
            if (GraphType == RedGraphType.Quest)
            {
                ConnectQuest((QuestOutputConnectorViewModel)output1, (QuestInputConnectorViewModel)input1);
            }

            if (GraphType == RedGraphType.Scene)
            {
                ConnectScene((SceneOutputConnectorViewModel)output1, (SceneInputConnectorViewModel)input1);
            }

            var sourceNode = Nodes.FirstOrDefault(n => n.UniqueId == output1.OwnerId);
            sourceNode?.UpdateSocketVisibility();
            var targetNode = Nodes.FirstOrDefault(n => n.UniqueId == input1.OwnerId);
            targetNode?.UpdateSocketVisibility();
        }

        if (PendingConnection is { Source: InputConnectorViewModel input2, Target: OutputConnectorViewModel output2 })
        {
            if (GraphType == RedGraphType.Quest)
            {
                ConnectQuest((QuestOutputConnectorViewModel)output2, (QuestInputConnectorViewModel)input2);
            }

            if (GraphType == RedGraphType.Scene)
            {
                ConnectScene((SceneOutputConnectorViewModel)output2, (SceneInputConnectorViewModel)input2);
            }

            var sourceNode = Nodes.FirstOrDefault(n => n.UniqueId == output2.OwnerId);
            sourceNode?.UpdateSocketVisibility();
            var targetNode = Nodes.FirstOrDefault(n => n.UniqueId == input2.OwnerId);
            targetNode?.UpdateSocketVisibility();
        }
    }

    private void Disconnect(BaseConnectorViewModel? baseConnectorViewModel)
    {
        if (baseConnectorViewModel is OutputConnectorViewModel outputConnector)
        {
            for (var i = Connections.Count - 1; i >= 0; i--)
            {
                if (Connections[i].Source == outputConnector)
                {
                    if (GraphType == RedGraphType.Quest)
                    {
                        RemoveQuestConnection((QuestConnectionViewModel)Connections[i]);
                    }

                    if (GraphType == RedGraphType.Scene)
                    {
                        RemoveSceneConnection((SceneConnectionViewModel)Connections[i]);
                    }
                }
            }
            var sourceNode = Nodes.FirstOrDefault(n => n.UniqueId == outputConnector.OwnerId);
            sourceNode?.UpdateSocketVisibility();
        }

        if (baseConnectorViewModel is InputConnectorViewModel inputConnector)
        {
            for (var i = Connections.Count - 1; i >= 0; i--)
            {
                if (Connections[i].Target == inputConnector)
                {
                    if (GraphType == RedGraphType.Quest)
                    {
                        RemoveQuestConnection((QuestConnectionViewModel)Connections[i]);
                    }

                    if (GraphType == RedGraphType.Scene)
                    {
                        RemoveSceneConnection((SceneConnectionViewModel)Connections[i]);
                    }
                }
            }
            var targetNode = Nodes.FirstOrDefault(n => n.UniqueId == inputConnector.OwnerId);
            targetNode?.UpdateSocketVisibility();
        }
    }

    public void RemoveNode(NodeViewModel node)
    {
        if (!Nodes.Contains(node))
        {
            return;
        }

        if (GraphType == RedGraphType.Scene && node is BaseSceneViewModel sceneNode)
        {
            RemoveSceneNode(sceneNode);
        }

        if (GraphType == RedGraphType.Quest && node is BaseQuestViewModel questNode)
        {
            RemoveQuestNode(questNode);
        }

        GraphStateSave();
        
        // Mark document as dirty since we modified the data
        DocumentViewModel?.SetIsDirty(true);
    }

    /// <summary>
    /// Replace a quest node with a deletion marker (soft delete) or hard delete based on node type
    /// </summary>
    /// <param name="node">The quest node to replace or remove</param>
    public void ReplaceNodeWithQuestDeletionMarker(BaseQuestViewModel node)
    {
        if (GraphType != RedGraphType.Quest)
        {
            throw new InvalidOperationException("Cannot replace with quest deletion marker on non-quest graph");
        }

        // Check if this node type should use a deletion marker
        if (!ShouldUseDeletionMarker(node))
        {
            // Non-signal-stopping nodes get hard deleted
            RemoveQuestNode(node);
            GraphStateSave();
            DocumentViewModel?.SetIsDirty(true);
            return;
        }

        // Call the quest-specific implementation from the partial class
        ReplaceNodeWithQuestDeletionMarkerInternal(node);
    }

    public void DuplicateNode(NodeViewModel node)
    {
        if (!Nodes.Contains(node))
        {
            return;
        }

        if (GraphType == RedGraphType.Scene && node is BaseSceneViewModel sceneNode)
        {
            DuplicateSceneNode(sceneNode);
        }

        if (GraphType == RedGraphType.Quest && node is BaseQuestViewModel questNode)
        {
            DuplicateQuestNode(questNode);
        }
        
        // Mark document as dirty since we modified the data
        DocumentViewModel?.SetIsDirty(true);
    }

    /// <summary>
    /// Pastes a node from clipboard data at the specified location
    /// </summary>
    public void PasteNode(IRedType copiedData, System.Windows.Point location)
    {
        if (GraphType == RedGraphType.Scene)
        {
            PasteSceneNode(copiedData, location);
        }
        else if (GraphType == RedGraphType.Quest)
        {
            PasteQuestNode(copiedData, location);
        }
        
        // Mark document as dirty since we modified the data
        DocumentViewModel?.SetIsDirty(true);
    }

    public void RemoveNodes(IEnumerable<object> nodes)
    {
        var removableNodes = new List<NodeViewModel>();
        foreach (var node in nodes)
        {
            if (node is not NodeViewModel nvm)
            {
                throw new Exception();
            }

            removableNodes.Add(nvm);
        }

        foreach (var node in removableNodes)
        {
            RemoveNode(node);
        }
    }

    public void CenterOnSelectedNodes(IList<object> nodes)
    {
        if (Editor == null)
        {
            return;
        }

        var nvm = nodes.OfType<NodeViewModel>().FirstOrDefault();
        if (nvm == null)
        {
            return;
        }

        Editor.ViewportZoom = 1;
        Editor.ViewportLocation = new System.Windows.Point(
            nvm.Location.X - (Editor.ViewportSize.Width / 2) + (nvm.Size.Width / 2),
            nvm.Location.Y - (Editor.ViewportSize.Height / 2) + (nvm.Size.Height / 2)
        );
    }

    public void RecalculateSockets(IGraphProvider nodeViewModel)
    {
        if (nodeViewModel is BaseQuestViewModel)
        {
            RecalculateQuestSockets(nodeViewModel);
        }
    }

    public System.Windows.Rect ArrangeNodes(double xOffset = 0, double yOffset = 0)
    {
        var graph = new GeometryGraph();
        var msaglNodes = new Dictionary<uint, Node>();

        // Extra height for external node ID (font + margin + padding)
        const double nodeIdExtraHeight = 35;

        foreach (var node in Nodes)
        {
            var layoutHeight = node.Size.Height + nodeIdExtraHeight;
            var msaglNode = new Node(CurveFactory.CreateRectangle(node.Size.Width, layoutHeight, new Microsoft.Msagl.Core.Geometry.Point()))
            {
                UserData = node
            };

            msaglNodes.Add(node.UniqueId, msaglNode);
            graph.Nodes.Add(msaglNode);
        }

        foreach (var connection in Connections.Reverse())
        {
            graph.Edges.Add(new Edge(msaglNodes[connection.Source.OwnerId], msaglNodes[connection.Target.OwnerId]));
        }

        var settings = new SugiyamaLayoutSettings
        {
            Transformation = PlaneTransformation.Rotation(Math.PI / 2),
            EdgeRoutingSettings = { EdgeRoutingMode = EdgeRoutingMode.Spline }
        };

        var layout = new LayeredLayout(graph, settings);
        layout.Run();

        double maxX = 0;
        double minX = 0;
        double maxY = 0;
        double minY = 0;

        foreach (var node in graph.Nodes)
        {
            var nvm = (NodeViewModel)node.UserData;
            // Offset the Y position to account for the extra height added for node ID spacing
            nvm.Location = new System.Windows.Point(
                node.Center.X - graph.BoundingBox.Center.X - (nvm.Size.Width / 2) + xOffset,
                node.Center.Y - graph.BoundingBox.Center.Y - (nvm.Size.Height / 2) + yOffset + (nodeIdExtraHeight / 2));

            // Calculate bounds including the node ID space
            maxX = Math.Max(maxX, nvm.Location.X + nvm.Size.Width);
            minX = Math.Min(minX, nvm.Location.X);
            maxY = Math.Max(maxY, nvm.Location.Y + nvm.Size.Height + nodeIdExtraHeight);
            minY = Math.Min(minY, nvm.Location.Y - nodeIdExtraHeight);
        }

        return new System.Windows.Rect(minX, minY, maxX - minX, maxY - minY);
    }

    public GraphCommentViewModel AddComment(System.Windows.Point location, IEnumerable<object>? selectedItems = null)
    {
        const double padding = 60;
        const double headerPadding = 90;

        var selectedNodes = selectedItems?
            .OfType<NodeViewModel>()
            .ToList() ?? [];

        GraphCommentViewModel comment;
        if (selectedNodes.Count > 0)
        {
            var minX = selectedNodes.Min(node => node.Location.X);
            var minY = selectedNodes.Min(node => node.Location.Y);
            var maxX = selectedNodes.Max(node => node.Location.X + Math.Max(node.Size.Width, 260));
            var maxY = selectedNodes.Max(node => node.Location.Y + Math.Max(node.Size.Height, 120));

            comment = new GraphCommentViewModel
            {
                Location = new System.Windows.Point(minX - padding, minY - headerPadding),
                Width = maxX - minX + (padding * 2),
                Height = maxY - minY + headerPadding + padding
            };
        }
        else
        {
            comment = new GraphCommentViewModel
            {
                Location = location
            };
        }

        AddComment(comment);
        GraphCommentStateSave();

        return comment;
    }

    private void AddComment(GraphCommentViewModel comment)
    {
        comment.PropertyChanged += CommentOnPropertyChanged;
        Comments.Add(comment);
    }

    private void RemoveComment(GraphCommentViewModel? comment)
    {
        if (comment == null)
        {
            return;
        }

        comment.PropertyChanged -= CommentOnPropertyChanged;
        Comments.Remove(comment);
        GraphCommentStateSave();
    }

    private void ClearComments()
    {
        if (Comments.Count == 0)
        {
            return;
        }

        foreach (var comment in Comments)
        {
            comment.PropertyChanged -= CommentOnPropertyChanged;
        }

        Comments.Clear();
    }

    private void CommentsOnCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e) => RebuildCanvasItems();

    private void NodesOnCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e) => RebuildCanvasItems();

    private void RebuildCanvasItems()
    {
        CanvasItems.Clear();

        foreach (var comment in Comments)
        {
            CanvasItems.Add(comment);
        }

        foreach (var node in Nodes)
        {
            CanvasItems.Add(node);
        }
    }

    private void CommentOnPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(GraphCommentViewModel.Text))
        {
            GraphCommentStateSave();
        }
        else if (e.PropertyName == nameof(GraphCommentViewModel.AccentColor))
        {
            GraphCommentStateSave();
        }
    }

    public void GraphStateLoad()
    {
        var loaded = false;
        _allowGraphSave = false;

        if (DocumentViewModel != null)
        {
            var proj = DocumentViewModel.GetActiveProject();
            if (proj != null)
            {
                var statePath = GetGraphEditorStatePath(".json");
                if (statePath != null && File.Exists(statePath))
                {
                    var jsonData = JObject.Parse(File.ReadAllText(statePath));
                    var nodesArray = jsonData.SelectTokens("Nodes.[*]");

                    foreach (var nodeToken in nodesArray)
                    {
                        var nodeIDValue = nodeToken.SelectToken("NodeID") as JValue;
                        if (nodeIDValue == null) continue;

                        var nodeId = nodeIDValue.ToObject<uint>();
                        var targetNode = Nodes.FirstOrDefault(n => n.UniqueId == nodeId);
                        if (targetNode == null) continue;

                        // Load Location
                        var nodeX = nodeToken.SelectToken("X") as JValue;
                        var nodeY = nodeToken.SelectToken("Y") as JValue;
                        if (nodeX != null && nodeY != null)
                        {
                            targetNode.Location = new System.Windows.Point(
                                nodeX.ToObject<double>(),
                                nodeY.ToObject<double>()
                            );
                        }

                        // Load ShowUnusedSockets state, defaulting to true if not present
                        var showUnusedSocketsValue = nodeToken.SelectToken("ShowUnusedSockets") as JValue;
                        targetNode.ShowUnusedSockets = showUnusedSocketsValue?.ToObject<bool>() ?? true;
                    }

                    // Update socket visibility after all nodes and connections are loaded
                    foreach (var node in Nodes)
                    {
                        node.UpdateSocketVisibility();
                    }

                    if (Editor != null)
                    {
                        var editorX = jsonData.SelectToken("EditorX") as JValue;
                        var editorY = jsonData.SelectToken("EditorY") as JValue;
                        var editorZ = jsonData.SelectToken("EditorZ") as JValue;
                        if (editorX != null && editorY != null && editorZ != null)
                        {
                            Editor.ViewportZoom = editorZ.ToObject<double>();
                            Editor.ViewportLocation = new System.Windows.Point(editorX.ToObject<double>(), editorY.ToObject<double>());
                        }
                    }

                    loaded = true;
                }
            }
        }

        if (!loaded)
        {
            var rect = ArrangeNodes();
            Editor?.FitToScreen(rect);
        }

        foreach (var node in Nodes)
        {
            node.IsInitialLoad = false;
        }

        ClearComments();
        GraphCommentStateLoad();
        _allowGraphSave = true;
    }

    private void ItemsDragCompleted()
    {
        GraphStateSave();
        GraphCommentStateSave();
    }

    public void GraphStateSave()
    {
        if (DocumentViewModel != null && _allowGraphSave)
        {
            var proj = DocumentViewModel.GetActiveProject();
            if (proj != null)
            {
                var statePath = GetGraphEditorStatePath(".json");
                if (statePath == null)
                {
                    return;
                }

                EnsureGraphEditorStateFolder(statePath);

                if (File.Exists(statePath))
                {
                    File.Delete(statePath);
                }

                var jNodes = new JArray();
                foreach (var node in Nodes)
                {
                    uint nodeID = 0;
                    if (node.Data is scnSceneGraphNode n)
                    {
                        nodeID = n.NodeId.Id;
                    }
                    if (node.Data is questNodeDefinition q)
                    {
                        nodeID = q.Id;
                    }
                    if (nodeID == 0)
                    {
                        nodeID = node.UniqueId;
                    }

                    JObject newPerfSet = new(
                        new JProperty("NodeID", nodeID),
                        new JProperty("X", node.Location.X),
                        new JProperty("Y", node.Location.Y),
                        new JProperty("ShowUnusedSockets", node.ShowUnusedSockets)
                    );

                    jNodes.Add(newPerfSet);
                }
                
                var jRoot = new JObject
                {
                    new JProperty("EditorX", Editor != null ? Editor.ViewportLocation.X : 0),
                    new JProperty("EditorY", Editor != null ? Editor.ViewportLocation.Y : 0),
                    new JProperty("EditorZ", Editor != null ? Editor.ViewportZoom : 0),
                    new JProperty("Nodes", jNodes)
                };

                File.WriteAllText(statePath, JsonConvert.SerializeObject(jRoot));
            }
        }
    }

    private void GraphCommentStateLoad()
    {
        if (DocumentViewModel == null)
        {
            return;
        }

        var statePath = GetGraphEditorStatePath(".comments.json");
        if (statePath == null)
        {
            return;
        }

        if (!File.Exists(statePath))
        {
            return;
        }

        var jsonData = JObject.Parse(File.ReadAllText(statePath));
        var commentsArray = jsonData.SelectTokens("Comments.[*]");
        foreach (var commentToken in commentsArray)
        {
            var id = commentToken.SelectToken("Id")?.ToObject<string>();
            var text = commentToken.SelectToken("Text")?.ToObject<string>();
            var x = commentToken.SelectToken("X")?.ToObject<double>();
            var y = commentToken.SelectToken("Y")?.ToObject<double>();
            var width = commentToken.SelectToken("Width")?.ToObject<double>();
            var height = commentToken.SelectToken("Height")?.ToObject<double>();
            var accentColor = commentToken.SelectToken("AccentColor")?.ToObject<string>();

            if (x is null || y is null || width is null || height is null)
            {
                continue;
            }

            AddComment(new GraphCommentViewModel
            {
                Id = string.IsNullOrWhiteSpace(id) ? Guid.NewGuid().ToString("N") : id,
                Text = string.IsNullOrWhiteSpace(text) ? "Comment" : text,
                AccentColor = string.IsNullOrWhiteSpace(accentColor) ? GraphCommentViewModel.DefaultAccentColor : accentColor,
                Location = new System.Windows.Point(x.Value, y.Value),
                Width = width.Value,
                Height = height.Value
            });
        }
    }

    public void GraphCommentStateSave()
    {
        if (DocumentViewModel == null || !_allowGraphSave)
        {
            return;
        }

        var statePath = GetGraphEditorStatePath(".comments.json");
        if (statePath == null)
        {
            return;
        }

        if (Comments.Count == 0)
        {
            if (File.Exists(statePath))
            {
                File.Delete(statePath);
            }

            return;
        }

        EnsureGraphEditorStateFolder(statePath);

        var jComments = new JArray();
        foreach (var comment in Comments)
        {
            jComments.Add(new JObject(
                new JProperty("Id", comment.Id),
                new JProperty("Text", comment.Text),
                new JProperty("AccentColor", comment.AccentColor),
                new JProperty("X", comment.Location.X),
                new JProperty("Y", comment.Location.Y),
                new JProperty("Width", comment.Width),
                new JProperty("Height", comment.Height)
            ));
        }

        var jRoot = new JObject
        {
            new JProperty("Comments", jComments)
        };

        File.WriteAllText(statePath, JsonConvert.SerializeObject(jRoot));
    }

    private string? GetGraphEditorStatePath(string extension)
    {
        var proj = DocumentViewModel?.GetActiveProject();

        return proj == null
            ? null
            : Path.Combine(proj.ProjectDirectory, "GraphEditorStates", DocumentViewModel!.RelativePath + StateParents + extension);
    }

    private static void EnsureGraphEditorStateFolder(string statePath)
    {
        var parentFolder = Path.GetDirectoryName(statePath);

        if (parentFolder != null && !Directory.Exists(parentFolder))
        {
            Directory.CreateDirectory(parentFolder);
        }
    }

    private void NotifyNodesUpdated(params uint[] nodeIds)
    {
        foreach (var nodeId in nodeIds)
        {
            var nodeVm = Nodes.FirstOrDefault(n => n.UniqueId == nodeId);
            if (nodeVm != null)
            {
                NodePropertyUpdateService.NotifyPropertyUpdated((RedBaseClass)nodeVm.Data);
            }
        }
    }

    #region IDisposable

    private bool _disposedValue;

    ~RedGraph() => Dispose(false);

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            if (disposing)
            {
                foreach (var node in Nodes)
                {
                    node.Dispose();
                }

                ClearComments();
            }

            _disposedValue = true;
        }
    }

    #endregion IDisposable
}
