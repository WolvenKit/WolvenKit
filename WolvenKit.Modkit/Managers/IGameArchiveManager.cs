using System.Collections.Generic;
using System.IO;
using DynamicData;
using WolvenKit.Common.Model;

namespace WolvenKit.Common
{
    /// <summary>
    /// Top-level game bundle/archive manager
    /// </summary>
    public interface IGameArchiveManager
    {
        #region Properties

        Dictionary<string, IGameArchive> Archives { get; set; }
        SourceCache<IGameFile, ulong> Items { get; }
        RedFileSystemModel RootNode { get; set; }

        //IEnumerable<string> AutocompleteSource { get; }
        IEnumerable<string> Extensions { get; set; }
        //IEnumerable<IGameFile> FileList { get; }
        EArchiveType TypeName { get; }

        #endregion Properties

        public void LoadAll(FileInfo executable, bool rebuildtree = true);
        public void LoadArchive(string filename, bool ispatch = false);
        public void LoadModArchive(string filename);
        public void LoadModsArchives(string mods, string dlc);
    }
}
