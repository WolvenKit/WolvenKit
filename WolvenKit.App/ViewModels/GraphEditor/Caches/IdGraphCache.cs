using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Nodify;
using WolvenKit.RED4.Types;
using Point = System.Windows.Point;

namespace WolvenKit.App.ViewModels.GraphEditor;

public class IdGraphCache(GraphData data) : IGraphViewCache
{
    public bool AllowGraphSave { get; set; }

    private GraphContext Context => data.Context;
    private NodifyEditor? Editor => data.Editor;
    private IEnumerable<NodeViewModel> Nodes => data.Nodes;
    private IEnumerable<ConnectionViewModel> Connections => data.Connections;
    private string StateParents => data.StateParents;

    public bool Load()
    {
        var docVM = Context.DocumentViewModel;
        var proj = docVM.GetActiveProject();

        if (proj == null)
        {
            AllowGraphSave = true;
            return false;
        }

        var statePath = Path.Combine(proj.ProjectDirectory, "GraphEditorStates",
            docVM.RelativePath + StateParents + ".json");

        if (!File.Exists(statePath))
        {
            AllowGraphSave = true;
            return false;
        }

        Dictionary<uint, Point> nodesLocs = new();

        var jsonData = JObject.Parse(File.ReadAllText(statePath));
        var nodesArray = jsonData.SelectTokens("Nodes.[*]");
        foreach (var node in nodesArray)
        {
            var nodeID = node.SelectToken("NodeID") as JValue;
            var nodeX = node.SelectToken("X") as JValue;
            var nodeY = node.SelectToken("Y") as JValue;

            if (nodeID != null && nodeX != null && nodeY != null)
            {
                nodesLocs.TryAdd(
                    nodeID.ToObject<uint>(),
                    new Point(
                        nodeX.ToObject<double>(),
                        nodeY.ToObject<double>()
                    )
                );
            }
        }

        foreach (var node in Nodes)
        {
            // TODO ldlework - these should be part of the strategy
            uint nodeID = 0;
            if (node.Data is scnSceneGraphNode n)
            {
                nodeID = n.NodeId.Id;
            }

            if (node.Data is questNodeDefinition q)
            {
                nodeID = q.Id;
            }

            if (nodesLocs.ContainsKey(nodeID))
            {
                node.Location = nodesLocs[nodeID];
            }
        }

        if (Editor != null)
        {
            var editorX = jsonData.SelectToken("EditorX") as JValue;
            var editorY = jsonData.SelectToken("EditorY") as JValue;
            var editorZ = jsonData.SelectToken("EditorZ") as JValue;
            if (editorX != null && editorY != null && editorZ != null)
            {
                Editor.ViewportZoom = editorZ.ToObject<double>();
                Editor.ViewportLocation =
                    new Point(editorX.ToObject<double>(), editorY.ToObject<double>());
            }
        }

        AllowGraphSave = true;
        return true;
    }

    public void Save()
    {
        if (!AllowGraphSave)
        {
            return;
        }

        var docVM = Context.DocumentViewModel;

        var proj = docVM.GetActiveProject();

        if (proj == null)
        {
            return;
        }

        var statePath = Path.Combine(proj.ProjectDirectory, "GraphEditorStates",
            docVM.RelativePath + StateParents + ".json");
        var parentFolder = Path.GetDirectoryName(statePath);

        if (parentFolder != null && !Directory.Exists(parentFolder))
        {
            Directory.CreateDirectory(parentFolder);
        }

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

            JObject newPerfSet = new(
                new JProperty("NodeID", nodeID),
                new JProperty("X", node.Location.X),
                new JProperty("Y", node.Location.Y)
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