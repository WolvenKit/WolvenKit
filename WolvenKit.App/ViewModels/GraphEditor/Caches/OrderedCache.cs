using System.IO;
using Newtonsoft.Json.Linq;

namespace WolvenKit.App.ViewModels.GraphEditor;

public class OrderedCache(GraphData data) : IGraphViewCache
{
    public bool AllowGraphSave { get; set; }

    private GraphContext Context => data.Context;
    
    private string StateParents => data.StateParents;

    public bool Load()
    {
        return false;
    }

    public void Save()
    {
        if (!AllowGraphSave) return;
        
        var docVM = Context.DocumentViewModel;

        var project = docVM.GetActiveProject();

        if (project == null) return;
        
        var statePath = Path.Combine(
            project.ProjectDirectory, 
            "GraphEditorStates",
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
        
        

    }
}