using System.Collections.Generic;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Documents
{
    public class RDTGraphViewModel : RedDocumentTabViewModel, IActivatableViewModel
    {
        public ViewModelActivator Activator { get; } = new();

        protected readonly IRedType _data;

        [Reactive] public RedDocumentViewModel File { get; set; }

        public RDTGraphViewModel(IRedType data, RedDocumentViewModel file)
        {
            File = file;
            _data = data;
            Header = "Graphviz Output";


            if (data is graphGraphResource ggr)
            {
                GraphText += @"digraph g {
fontname=""Helvetica,Arial,sans-serif""
node[fontname = ""Helvetica,Arial,sans-serif"" margin=""0.1,0"" width=0 height=0]
edge[fontname = ""Helvetica,Arial,sans-serif""]
graph [
    rankdir = LR
];
";
                RenderNodes(ggr.Graph.Chunk.Nodes);
                GraphText += "}";
            }

        }

        public void RenderNodes(CArray<CHandle<graphGraphNodeDefinition>> nodes)
        {
            var connections = new Dictionary<int, graphGraphConnectionDefinition>();
            foreach (var node in nodes)
            {
                GraphText += $"subgraph cluster_{node.GetHashCode()} {{\n";
                GraphText += $"    label = \" {node.Chunk.GetType().Name} [{nodes.IndexOf(node)}] \";\n";
                //if (node.Chunk is questPhaseNodeDefinition qpnd)
                //{
                //    GraphText += $"    label = \"{ qpnd.Id }\"\n";
                //}
                foreach (var socket in node.Chunk.Sockets)
                {
                    GraphText += $"    node [ shape = \"plaintext\", label=\"{socket.Chunk.Name}\" ]{socket.Chunk.GetHashCode()};\n";
                    foreach (var connection in socket.Chunk.Connections)
                    {
                        if (!connections.ContainsKey(connection.Chunk.GetHashCode()))
                        {
                            connections.Add(connection.Chunk.GetHashCode(), connection.Chunk);
                        }
                    }
                }
                if (node.Chunk is questPhaseNodeDefinition qpnd && qpnd.PhaseGraph != null)
                {
                    RenderNodes(qpnd.PhaseGraph.Chunk.Nodes);
                }
                GraphText += "};\n";
            }
            GraphText += "\n";

            foreach (var (_, connection) in connections)
            {
                GraphText += $"{connection.Source.Chunk.GetHashCode()} -> {connection.Destination.Chunk.GetHashCode()};\n";
            }
        }

        public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.MainFile;

        public string GraphText { get; set; } = "";
    }
}
