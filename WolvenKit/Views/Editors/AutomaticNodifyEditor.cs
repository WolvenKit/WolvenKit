using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Nodify;
using Microsoft.Msagl.Core.Geometry.Curves;
using Microsoft.Msagl.Core.Layout;
using Microsoft.Msagl.Core.Routing;
using Microsoft.Msagl.Layout.Layered;
using WolvenKit.Functionality.Interfaces;
using System.Windows.Input;
using Microsoft.Msagl.Layout.MDS;

namespace WolvenKit.Views.Editors
{
    public class AutomaticNodifyEditor : NodifyEditor
    {
        public AutomaticNodifyEditor() : base()
        {

        }


        protected override void OnMouseMove(MouseEventArgs e)
        {
            CurrentMousePosition = e.GetPosition(this);

            if (CurrentMousePosition != PreviousMousePosition)
            {
                MouseLocation = TransformPosition(CurrentMousePosition);

                if (IsMouseCaptured)
                {
                    // Panning
                    if (e.MiddleButton == MouseButtonState.Pressed)
                    {
                        Offset -= CurrentMousePosition - PreviousMousePosition;
                        IsPanning = true;
                        e.Handled = true;
                    }
                    else if (IsSelecting)
                    {
                        Selection.Update(MouseLocation);
                    }
                    else
                    {
                        // Should not reach this
                        ReleaseMouseCapture();
                    }
                }

                PreviousMousePosition = CurrentMousePosition;
            }
        }

        protected override void OnMouseRightButtonDown(MouseButtonEventArgs e)
        {

        }

        protected override void OnMouseRightButtonUp(MouseButtonEventArgs e)
        {

        }

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Middle)
            {
                if (Mouse.Captured == null)
                {
                    Focus();
                    CaptureMouse();

                    InitialMousePosition = e.GetPosition(this);
                }
            }
            else
            {
                base.OnMouseDown(e);
            }
        }

        protected override void OnMouseUp(MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Middle)
            {
                // If right clicking without panning or selecting allow context menu
                if (IsMouseCaptured && !IsPanning && !IsSelecting)
                {
                    Focus();
                    ReleaseMouseCapture();
                }
                // If is selecting but not panning, end selection and show context menu
                else if (IsSelecting && !IsPanning)
                {
                    Selection.End();
                }
                else if (IsPanning)
                {
                    IsPanning = false;

                    // Allow selecting and panning at the same time and disable context menu
                    if (IsSelecting)
                    {
                        e.Handled = true;
                    }
                    // If is panning but not selecting, release mouse capture and show context menu if necessary
                    else
                    {
                        // Handle right click if is panning and moved the mouse more than threshold so context menus don't open
                        if ((CurrentMousePosition - InitialMousePosition).LengthSquared > HandleRightClickAfterPanningThreshold * HandleRightClickAfterPanningThreshold)
                        {
                            e.Handled = true;
                        }

                        if (IsMouseCaptured)
                        {
                            ReleaseMouseCapture();
                        }
                    }
                }
            }
            else
            {
                base.OnMouseUp(e);
            }
        }

        /// <summary>
        /// Uses <see cref="Microsoft.Msagl.Core"/> to automatically lay out nodes, ignoring socket positions.
        /// </summary>
        /// <returns>If the lay out was successful</returns>
        public bool LayoutNodes()
        {
            UpdateLayout();
            var graph = new GeometryGraph();
            var nodes = new Dictionary<int, Microsoft.Msagl.Core.Layout.Node>();
            var socketNodeLookup = new Dictionary<int, int>();
            foreach (var item in ItemsHost.Children)
            {
                if (item is ItemContainer ic)
                {
                    if (ic.DataContext is INode nvm)
                    {
                        // without UpdateLayout(), these were 0, so backups were needed
                        var width = ic.ActualWidth != 0 ? ic.ActualWidth : 300;
                        var height = ic.ActualHeight != 0 ? ic.ActualHeight : 40;
                        var msaglNode = new Microsoft.Msagl.Core.Layout.Node(
                            CurveFactory.CreateRectangle(width, height, new Microsoft.Msagl.Core.Geometry.Point()), nvm.GetHashCode());
                        nodes.Add(nvm.GetHashCode(), msaglNode);
                        graph.Nodes.Add(msaglNode);

                        // create a lookup between the inputs/outputs & the node itself
                        foreach (var input in nvm.Inputs)
                        {
                            socketNodeLookup[input.GetHashCode()] = nvm.GetHashCode();
                        }
                        foreach (var output in nvm.Outputs)
                        {
                            socketNodeLookup[output.GetHashCode()] = nvm.GetHashCode();
                        }
                    }
                }
            }

            foreach (INodeConnection connection in Connections)
            {
                if (socketNodeLookup.ContainsKey(connection.Source.GetHashCode()) &&
                    socketNodeLookup.ContainsKey(connection.Destination.GetHashCode()))
                {
                    var source = socketNodeLookup[connection.Source.GetHashCode()];
                    var dest = socketNodeLookup[connection.Destination.GetHashCode()];
                    var edge = new Edge(nodes[source], nodes[dest]);
                    edge.TargetPort = new FloatingPort(
                        edge.Target.BoundaryCurve,
                        new Microsoft.Msagl.Core.Geometry.Point(-200, 0));
                    edge.SourcePort = new FloatingPort(
                        edge.Source.BoundaryCurve,
                        new Microsoft.Msagl.Core.Geometry.Point(200, 0));
                    graph.Edges.Add(edge);
                }
            }

            var settings = new SugiyamaLayoutSettings
            {
                Transformation = PlaneTransformation.Rotation(Math.PI / 2),
                NodeSeparation = 30
                //EdgeRoutingSettings = { EdgeRoutingMode = EdgeRoutingMode.Spline }
            };
            var layout = new LayeredLayout(graph, settings);
            //var settings = new MdsLayoutSettings()
            //{

            //};
            //var layout = new MdsGraphLayout(settings, graph);
            try
            {
                layout.Run();

                foreach (var item in ItemsHost.Children)
                {
                    if (item is ItemContainer ic)
                    {
                        if (ic.DataContext is INode nvm && nodes.ContainsKey(nvm.GetHashCode()))
                        {
                            var node = nodes[nvm.GetHashCode()];
                            nvm.Location = new Point(
                                node.Center.X - graph.BoundingBox.Center.X - ic.ActualWidth / 2,
                                node.Center.Y - graph.BoundingBox.Center.Y - ic.ActualHeight / 2);
                        }
                    }
                }

                // center to 0,0 since we're subtracting the graph's center from each location
                BringIntoView(new Point(0, 0));
                return true;
            }
            catch (InvalidOperationException)
            {
                // shouldn't happen with the backup sizes
                return false;
            }
        }

    }
}
