using System.Collections.Generic;

namespace WolvenKit.Common
{
    /// <summary>
    /// Top-level game bundle/archive manager
    /// </summary>
    public interface IGameArchiveManager
    {
        #region Properties

        Dictionary<string, IGameArchive> Archives { get; set; }
        Dictionary<ulong, IEnumerable<IGameFile>> Items { get; }
        GameFileTreeNode RootNode { get; set; }

        IEnumerable<string> AutocompleteSource { get; }
        IEnumerable<string> Extensions { get; }
        IEnumerable<IGameFile> FileList { get; }
        EArchiveType TypeName { get; }

        #endregion Properties

        public void LoadAll(string exedir, bool rebuildTree = true);
        public void LoadArchive(string filename, bool ispatch = false);
        public void LoadModArchive(string filename);
        public void LoadModsArchives(string mods, string dlc);
    }
}
