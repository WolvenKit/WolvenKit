using Nodify;
using WolvenKit.App.ViewModels.Documents;

namespace WolvenKit.App.ViewModels.GraphEditor;

public class GraphContext
{
    public readonly RDTGraphViewModel2 GraphViewModel;
    public RedDocumentViewModel DocumentViewModel { get; set; }

    public NodifyEditor? Editor { get; set; }
    
    public string StateParents { get; set; } = "";

    public GraphContext(RDTGraphViewModel2 graphViewModel, RedDocumentViewModel documentViewModel)
    {
        GraphViewModel = graphViewModel;
        DocumentViewModel = documentViewModel;
    }
}
