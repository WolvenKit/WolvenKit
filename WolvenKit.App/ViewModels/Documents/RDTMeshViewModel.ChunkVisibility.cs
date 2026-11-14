using System.Collections.Generic;
using WolvenKit.App.Models;

namespace WolvenKit.App.ViewModels.Documents;

/// <summary>
/// Chunks hidden or shown by hand stay so when another appearance is selected: each appearance has
/// its own copies of the meshes, so a switch showed every chunk of the new one again.
/// </summary>
public partial class RDTMeshViewModel
{
    private Appearance? _chunkStateAppearance;

    /// <summary>
    /// Copies the visibility of the last shown appearance's chunks to the same chunks (same component,
    /// same submesh) of <paramref name="app"/>. Only chunks of the shown LOD that the chunk mask lets
    /// through on both sides: what the mask or the LOD hides stays as the appearance has it.
    /// </summary>
    private void CarryChunkVisibility(Appearance app)
    {
        var previous = _chunkStateAppearance;
        _chunkStateAppearance = app;
        if (previous is null || ReferenceEquals(previous, app))
        {
            return;
        }

        // A .mesh file's appearances have one model each, named after the appearance: its chunks match
        // by submesh alone. An entity's components match by name.
        var single = previous.Models.Count == 1 && app.Models.Count == 1;
        string Key(LoadableModel model, SubmeshComponent sm) => single ? $"|{sm.Name}" : $"{model.Name}|{sm.Name}";

        var shown = new Dictionary<string, bool>();
        foreach (var model in previous.Models)
        {
            foreach (var sm in model.Meshes)
            {
                if (sm.EnabledWithMask && sm.LOD == previous.SelectedLOD)
                {
                    shown.TryAdd(Key(model, sm), sm.IsRendering);
                }
            }
        }

        if (shown.Count == 0)
        {
            return;
        }

        foreach (var model in app.Models)
        {
            foreach (var sm in model.Meshes)
            {
                if (sm.EnabledWithMask && sm.LOD == app.SelectedLOD && app.SelectedLOD == previous.SelectedLOD &&
                    shown.TryGetValue(Key(model, sm), out var isRendering) && sm.IsRendering != isRendering)
                {
                    sm.IsRendering = isRendering;
                }
            }
        }
    }
}
