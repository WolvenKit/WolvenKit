using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using DynamicData;
using DynamicData.Kernel;
using WolvenKit.Common.Model;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.Common
{
    /// <summary>
    /// Top-level game bundle/archive manager
    /// </summary>
    public interface IArchiveManager : INotifyPropertyChanged
    {
        #region Properties

        SourceCache<IGameArchive, string> Archives { get; set; }
        SourceCache<IGameArchive, string> ModArchives { get; set; }
        //SourceCache<IGameFile, ulong> Items { get; }
        RedFileSystemModel? RootNode { get; set; }
        public List<RedFileSystemModel> ModRoots { get; }

        IGameArchive? ProjectArchive { get; set; }

        //IEnumerable<string> AutocompleteSource { get; }
        IEnumerable<string>? Extensions { get; set; }
        //IEnumerable<IGameFile> FileList { get; }
        EArchiveType TypeName { get; }

        public bool IsManagerLoading { get; }
        public bool IsManagerLoaded { get; }
        bool IsModBrowserActive { get; set; }

        #endregion Properties

        public void LoadGameArchives(FileInfo executable, bool rebuildtree = true);
        public void LoadArchive(string path, EArchiveSource source = EArchiveSource.Unknown);
        public void LoadModArchive(string filename, bool analyzeFiles = true);
        public void LoadModsArchives(FileInfo executable, bool analyzeFiles = true);
        public void LoadAdditionalModArchives(string archiveBasePath, bool analyzeFiles = true);

        public Dictionary<string, IEnumerable<IGameFile>> GetGroupedFiles();
        public IEnumerable<FileEntry> GetFiles();
        void LoadFromFolder(DirectoryInfo archivedir);

        RedFileSystemModel? LookupDirectory(string fullpath, bool expandAll = false);
        public Optional<IGameFile> Lookup(ulong hash);
        public IGameFile? GetGameFile(ResourcePath path, bool includeMods = true, bool includeProject = true);
        public CR2WFile? GetCR2WFile(ResourcePath path, bool includeMods = true, bool includeProject = true);

        public IObservable<IChangeSet<RedFileSystemModel>> ConnectGameRoot();
        public IObservable<IChangeSet<RedFileSystemModel>> ConnectModRoot();
    }
}
