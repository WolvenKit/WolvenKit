using System.Windows;
using Microsoft.Msagl.Core.Layout;
using WolvenKit.RED4.Types;

namespace WolvenKit.ViewModels.Documents
{
    public class PhaseNodeViewModel : NodeViewModel
    {
        public GeometryGraph GeoGraph { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }

        public PhaseNodeViewModel(RDTGraphViewModel graph, graphGraphNodeDefinition node, GeometryGraph geoGraph) : base(graph, node)
        {
            GeoGraph = geoGraph;

            if (node is questNodeDefinition qnd)
            {
                Header = $"Phase [{qnd.Id}]";
            }
        }

        public override Size GetSize() => new(Width, Height);
    }
}
