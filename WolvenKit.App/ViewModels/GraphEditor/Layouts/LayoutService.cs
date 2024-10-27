using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Microsoft.Msagl.Core.Geometry.Curves;
using Microsoft.Msagl.Core.Layout;
using Microsoft.Msagl.Core.Routing;
using Microsoft.Msagl.Layout.Layered;
using Nodify;
using Node = Microsoft.Msagl.Core.Layout.Node;

namespace WolvenKit.App.ViewModels.GraphEditor;

public class LayoutService(GraphData graphData) : ILayoutService
{
    private NodifyEditor? Editor => graphData.Editor;
    private IEnumerable<NodeViewModel> Nodes => graphData.Nodes;
    private IEnumerable<ConnectionViewModel> Connections => graphData.Connections;

    public void CenterOnSelectedNodes(IList<object> nodes)
    {
        if (nodes.Count == 0) return;

        if (Editor == null) return;

        if (nodes[0] is NodeViewModel nvm)
        {
            Editor.ViewportZoom = 1;
            Editor.ViewportLocation = new System.Windows.Point(
                nvm.Location.X - (Editor.ViewportSize.Width / 2) + (nvm.Size.Width / 2),
                nvm.Location.Y - (Editor.ViewportSize.Height / 2) + (nvm.Size.Height / 2)
            );
        }
    }

    public void FitToScreen(Rect rect) => Editor?.FitToScreen();

    public Rect ArrangeNodes(double xOffset = 0, double yOffset = 0)
    {
        var graph = new GeometryGraph();
        var msaglNodes = new Dictionary<uint, Node>();

        foreach (var node in Nodes)
        {
            var msaglNode = new Node(CurveFactory.CreateRectangle(node.Size.Width, node.Size.Height, new Microsoft.Msagl.Core.Geometry.Point()))
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
            nvm.Location = new System.Windows.Point(
                node.Center.X - graph.BoundingBox.Center.X - (nvm.Size.Width / 2) + xOffset,
                node.Center.Y - graph.BoundingBox.Center.Y - (nvm.Size.Height / 2) + yOffset);

            maxX = Math.Max(maxX, nvm.Location.X + nvm.Size.Width);
            minX = Math.Min(minX, nvm.Location.X);
            maxY = Math.Max(maxY, nvm.Location.Y + nvm.Size.Height);
            minY = Math.Min(minY, nvm.Location.Y);
        }

        return new Rect(minX, minY, maxX - minX, maxY - minY);
    }    
}