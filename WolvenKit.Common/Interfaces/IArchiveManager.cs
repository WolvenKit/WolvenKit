using System;
using System.Collections.Generic;
using System.IO;
using DynamicData;
using DynamicData.Kernel;
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

        SourceCache<IGameArchive, string> Archives { get; set; }
        SourceCache<IGameArchive, string> ModArchives { get; set; }
        //SourceCache<IGameFile, ulong> Items { get; }
        RedFileSystemModel RootNode { get; set; }
        public List<RedFileSystemModel> ModRoots { get; }

        //IEnumerable<string> AutocompleteSource { get; }
        IEnumerable<string> Extensions { get; set; }
        //IEnumerable<IGameFile> FileList { get; }
        EArchiveType TypeName { get; }

        public bool IsManagerLoaded { get; }

        #endregion Properties

        public void LoadGameArchives(FileInfo executable, bool rebuildtree = true);
        public void LoadArchive(string path, bool ispatch = false);
        public void LoadModArchive(string filename);
        public void LoadModsArchives(DirectoryInfo modsDir, DirectoryInfo dlcDir);

        Dictionary<string, IEnumerable<FileEntry>> GetGroupedFiles();
        void LoadFromFolder(DirectoryInfo archivedir);

        RedFileSystemModel LookupDirectory(string fullpath, bool expandAll = false);
        public Optional<IGameFile> Lookup(ulong hash);

        public IObservable<IChangeSet<RedFileSystemModel>> ConnectGameRoot();
        public IObservable<IChangeSet<RedFileSystemModel>> ConnectModRoot();
    }
}
