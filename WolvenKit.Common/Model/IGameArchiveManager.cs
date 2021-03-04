using System.Collections.Generic;

namespace WolvenKit.Common
{
    /// <summary>
    /// Top-level game file, holds archived game assets. Types :
    /// .bundle, .cache (collision, texture, sound) .w3speech
    /// </summary>
    public interface IGameArchiveManager
    {
        #region Properties

        List<string> AutocompleteSource { get; set; }
        List<string> Extensions { get; set; }
        List<IGameFile> FileList { get; set; }
        Dictionary<string, List<IGameFile>> Items { get; set; }
        GameFileTreeNode RootNode { get; set; }
        EArchiveType TypeName { get; }

        #endregion Properties
    }
}
