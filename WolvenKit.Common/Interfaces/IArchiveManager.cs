using System;
using System.Collections.Generic;
using System.IO;
using DynamicData;
using WolvenKit.Common.Model;
using WolvenKit.RED4.CR2W.Archive;

namespace WolvenKit.Common
{
    /// <summary>
    /// Top-level game bundle/archive manager
    /// </summary>
    public interface IArchiveManager
    {
        #region Properties

        Dictionary<string, IGameArchive> Archives { get; set; }
        SourceCache<IGameFile, ulong> Items { get; }
        RedFileSystemModel RootNode { get; set; }

        //IEnumerable<string> AutocompleteSource { get; }
        IEnumerable<string> Extensions { get; set; }
        //IEnumerable<IGameFile> FileList { get; }
        EArchiveType TypeName { get; }

        public bool IsManagerLoaded { get; }

        #endregion Properties

        public void LoadAll(FileInfo executable, bool rebuildtree = true);
        public void LoadArchive(string filename, bool ispatch = false);
        public void LoadModArchive(string filename);
        public void LoadModsArchivesLoadModsArchives(DirectoryInfo modsDir, DirectoryInfo dlcDir);

        RedFileSystemModel LookupDirectory(string fullpath, bool expandAll = false);
        public IGameFile LookupFile(ulong hash);
        Dictionary<string, IEnumerable<FileEntry>> GetGroupedFiles();
        void LoadFromFolder(DirectoryInfo archivedir, bool rebuildtree = false);

        public IObservable<IChangeSet<RedFileSystemModel>> ConnectGameArchives();
    }
}
