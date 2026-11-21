using System.Linq;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Documents;

/// <summary>
/// A .mesh preview is built from the appearances and material entries when the tab first opens.
/// Edits that change them (Un-Dynamify Materials, Delete Unused Materials, added or renamed
/// appearances, other chunk materials) rebuild it: when the preview is shown again and before
/// materials are generated (by hand, on an appearance switch or by live update). Live update
/// alone only covers material values.
/// </summary>
public partial class RDTMeshViewModel
{
    private string? _builtMeshStructure;
    private bool _rebuildingMesh;

    /// <summary>
    /// Appearance names, chunk materials and material entries: what the preview's appearances are
    /// built from. The stand-ins the preview adds to a mesh without materials don't count.
    /// </summary>
    private string MeshStructure(CMesh mesh) => MeshStructure(mesh, _generatedAppearance, _generatedEntry);

    private static string MeshStructure(CMesh mesh, object? skipAppearance, object? skipEntry) =>
        string.Join("|", mesh.Appearances.Where(a => !ReferenceEquals(a, skipAppearance))
            .Select(a => a?.Chunk).OfType<meshMeshAppearance>()
            .Select(a => a.Name.GetResolvedText() + ":" + string.Join(",", a.ChunkMaterials.Select(c => c.GetResolvedText())))) +
        "#" + string.Join(",", mesh.MaterialEntries.Where(e => !ReferenceEquals(e, skipEntry))
            .Select(e => $"{e.Name.GetResolvedText()}/{e.Index}/{e.IsLocalInstance}"));

    /// <summary>Called when the preview builds the mesh's appearances.</summary>
    private void RememberMeshStructure() =>
        _builtMeshStructure = _data is CMesh mesh ? MeshStructure(mesh) : null;

    /// <summary>
    /// Rebuilds the appearances if the mesh changed since they were built, keeping the selected one
    /// (by name) if it is still there. True if it rebuilt.
    /// </summary>
    private bool RebuildMeshIfChanged()
    {
        if (_rebuildingMesh || _data is not CMesh mesh || !IsRendered || _builtMeshStructure is not { } before ||
            MeshStructure(mesh) == before)
        {
            return false;
        }

        _rebuildingMesh = true;
        try
        {
            var selected = SelectedAppearance?.Name;
            RollbackGeneratedData();
            Appearances = new();
            IsRendered = false;
            RenderMesh();
            OnPropertyChanged(nameof(Appearances));

            if (selected != null && Appearances.FirstOrDefault(a => a.Name == selected) is { } same)
            {
                SelectedAppearance = same;
            }
        }
        finally
        {
            _rebuildingMesh = false;
        }

        return true;
    }
}
