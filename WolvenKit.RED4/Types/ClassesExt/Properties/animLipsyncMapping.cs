namespace WolvenKit.RED4.Types;

public partial class animLipsyncMapping
{
    [Ordinal(3)]
    [RED("scenePreviewPaths")]
    public CArray<CUInt64> ScenePreviewPaths
    {
        get => GetPropertyValue<CArray<CUInt64>>();
        set => SetPropertyValue<CArray<CUInt64>>(value);
    }

    partial void PostConstruct() => ScenePreviewPaths = [];

    /// <summary>Gets the entry for a scene, or <see langword="null"/> when the mapping has none.</summary>
    public animLipsyncMappingSceneEntry? GetSceneEntry(CUInt64 scenePathHash)
    {
        var index = ScenePaths.IndexOf(scenePathHash);
        return index >= 0 && index < SceneEntries.Count ? SceneEntries[index] : null;
    }

    /// <summary>
    /// Adds or replaces a scene entry while keeping all three arrays aligned.
    /// </summary>
    /// <remarks>Preview paths use scene hashes because the game appears to ignore them.</remarks>
    public void SetSceneEntry(CUInt64 scenePathHash, animLipsyncMappingSceneEntry entry)
    {
        AlignPreviewPaths();

        var index = ScenePaths.IndexOf(scenePathHash);
        if (index >= 0)
        {
            SceneEntries[index] = entry;
            return;
        }

        ScenePaths.Add(scenePathHash);
        ScenePreviewPaths.Add(scenePathHash);
        SceneEntries.Add(entry);
    }

    /// <summary>Removes a scene from all three arrays.</summary>
    public bool RemoveSceneEntry(CUInt64 scenePathHash)
    {
        AlignPreviewPaths();

        var index = ScenePaths.IndexOf(scenePathHash);
        if (index < 0)
        {
            return false;
        }

        ScenePaths.RemoveAt(index);
        ScenePreviewPaths.RemoveAt(index);
        SceneEntries.RemoveAt(index);
        return true;
    }

    private void AlignPreviewPaths()
    {
        while (ScenePreviewPaths.Count > ScenePaths.Count)
        {
            ScenePreviewPaths.RemoveAt(ScenePreviewPaths.Count - 1);
        }

        while (ScenePreviewPaths.Count < ScenePaths.Count)
        {
            ScenePreviewPaths.Add(ScenePaths[ScenePreviewPaths.Count]);
        }
    }
}
