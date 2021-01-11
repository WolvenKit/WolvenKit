using System.Collections.Generic;

namespace WolvenKit.Common.Model
{
    /// <summary>
    /// Top-level game file, holds archived game assets. Types :
    /// .bundle, .cache (collision, texture, sound) .w3speech
    /// </summary>
    public interface IGameArchiveManager
    {
        GameFileTreeNode RootNode { get; set; }
        List<IGameFile> FileList { get; set; }
        EArchiveType TypeName { get; }
        List<string> Extensions { get; set; }
        List<string> AutocompleteSource { get; set; }
        Dictionary<string, List<IGameFile>> Items { get; set; }
    }
}
