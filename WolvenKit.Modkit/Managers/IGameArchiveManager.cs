using System.Collections.Generic;
using System.IO;

namespace WolvenKit.Common
{
    /// <summary>
    /// Top-level game bundle/archive manager
    /// </summary>
    public interface IGameArchiveManager
    {
        #region Properties

        Dictionary<string, IGameArchive> Archives { get; set; }
        Dictionary<ulong, List<IGameFile>> Items { get; }
        GameFileTreeNode RootNode { get; set; }

        IEnumerable<string> AutocompleteSource { get; }
        IEnumerable<string> Extensions { get; }
        IEnumerable<IGameFile> FileList { get; }
        EArchiveType TypeName { get; }

        #endregion Properties

        public void LoadAll(FileInfo executable, bool rebuildtree = true);
        public void LoadArchive(string filename, bool ispatch = false);
        public void LoadModArchive(string filename);
        public void LoadModsArchives(string mods, string dlc);
    }
}
