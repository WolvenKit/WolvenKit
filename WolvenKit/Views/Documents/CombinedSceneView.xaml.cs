using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.GraphEditor;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;

namespace WolvenKit.Views.Documents
{
    /// <summary>
    /// Converter to map a path type to connection thickness.
    /// </summary>
    public sealed class PathTypeToThicknessConverter : IValueConverter
    {
        public double ThinThickness { get; set; } = 1.5;
        public double ThickThickness { get; set; } = 3.0;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // PathType 1 is Dead End, 2 is Live Path
            return (value is int pathType && pathType == 1) ? ThinThickness : ThickThickness;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Interaktionslogik für CombinedSceneView.xaml
    /// </summary>
    public partial class CombinedSceneView : UserControl
    {
        public CombinedSceneView()
        {
            InitializeComponent();
            DataContextChanged += OnDataContextChanged;
        }

        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue is not CombinedSceneViewModel viewModel) return;

            viewModel.MainGraph.Connections.CollectionChanged += (_, _) => UpdateConnectionPathTypes(viewModel.MainGraph);
            viewModel.MainGraph.Nodes.CollectionChanged += (_, _) => UpdateConnectionPathTypes(viewModel.MainGraph);

            Dispatcher.BeginInvoke(new Action(() =>
            {
                SetupConnectionTemplate();
                UpdateConnectionPathTypes(viewModel.MainGraph);
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
    }
} 