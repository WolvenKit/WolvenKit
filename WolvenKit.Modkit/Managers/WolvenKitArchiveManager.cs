using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using DynamicData;
using DynamicData.Kernel;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.Common.Model
{
    public abstract class WolvenKitArchiveManager : ObservableObject, IArchiveManager
    {
        #region properties

        public abstract EArchiveType TypeName { get; }

        public abstract SourceCache<IGameArchive, string> Archives { get; set; }

        public abstract SourceCache<IGameArchive, string> ModArchives { get; set; }


        public RedFileSystemModel? RootNode { get; set; }

        public List<RedFileSystemModel> ModRoots { get; set; } = new();

        //public IEnumerable<string> AutocompleteSource { get; set; } //=> FileList.Select(_ => GetFileName(_.Name)).Distinct();

        public IEnumerable<string>? Extensions { get; set; }

        public abstract bool IsManagerLoading { get; set; }
        public abstract bool IsManagerLoaded { get; set; }

        public bool IsModBrowserActive { get; set; }

        public abstract IGameArchive? ProjectArchive { get; set; }

        #endregion

        public abstract void LoadGameArchives(FileInfo executable, bool rebuildtree = true);

        public abstract void LoadArchive(string path, EArchiveSource source = EArchiveSource.Unknown);

        public abstract void LoadModArchive(string filename, bool analyzeFiles = true);

        public abstract void LoadModsArchives(FileInfo executable, bool analyzeFiles = true);

        public abstract void LoadAdditionalModArchives(string archiveBasePath, bool analyzeFiles = true);

        protected static string GetModFolder(string path)
        {
            if (path.Split('\\').Length > 3 && path.Split('\\').Contains("content"))
            {
                return path.Split('\\')[path.Split('\\').ToList().IndexOf(path.Split('\\').First(x => x == "content")) - 1];
            }
            return path;
        }

        protected void RebuildGameRoot(IHashService hashService)
        {
            RootNode = new RedFileSystemModel(TypeName.ToString());

            var allFiles = Archives.Items
                .SelectMany(x => x.Files)
                .GroupBy(x => x.Key)
                .Select(x => x.First());

            Parallel.ForEach(allFiles, (file) =>
            {
                var path = hashService.Get(file.Key);
                if (path == null)
                {
                    RootNode.Files.Enqueue(file.Value);
                    return;
                }

                var lastNode = RootNode;

                var sb = new StringBuilder();
                for (var i = 0; i < path.Length; i++)
                {
                    if (path[i] == '\\')
                    {
                        var str = sb.ToString();

                        if (!lastNode.Directories.TryGetValue(str, out var tmpNode))
                        {
                            tmpNode = new RedFileSystemModel(str);
                            lastNode.Directories.TryAdd(str, tmpNode);
                        }
                        lastNode = tmpNode;
                    }
                    sb.Append(path[i]);
                }
                lastNode.Files.Enqueue(file.Value);
            });
        }

        protected void RebuildModRoot()
        {
            ModRoots.Clear();

            foreach (var archive in ModArchives.Items)
            {
                ArgumentNullException.ThrowIfNull(archive.ArchiveRelativePath);

                var modroot = new RedFileSystemModel(archive.ArchiveRelativePath);

                // loop through all files
                //Parallel.ForEach(archive.Files, item =>
                foreach (var item in archive.Files)
                {
                    var currentNode = modroot;
                    var model = item.Value;
                    var parts = model.Name.Split('\\');

                    // loop through path
                    var fullpath = "";
                    for (var i = 0; i < parts.Length - 1; i++)
                    {
                        var part = parts[i];
                        fullpath += part + Path.DirectorySeparatorChar;

                        var dirPath = fullpath.TrimEnd(Path.DirectorySeparatorChar);
                        var x = currentNode.Directories.GetOrAdd(dirPath, new RedFileSystemModel(dirPath));
                        currentNode = x;
                    }

                    // add file to the last directory in path
                    currentNode.Files.Enqueue(item.Value);
                }
                //);

                ModRoots.Add(modroot);
            }
        }

        public abstract Optional<IGameFile> Lookup(ulong hash);

        public abstract RedFileSystemModel? LookupDirectory(string fullpath, bool expandAll = false);

        public abstract Dictionary<string, IEnumerable<IGameFile>> GetGroupedFiles();

        public abstract IEnumerable<FileEntry> GetFiles();

        public abstract void LoadFromFolder(DirectoryInfo archivedir);

        public abstract IGameFile? GetGameFile(ResourcePath path, bool includeMods = true, bool includeProject = true);
        public abstract CR2WFile? GetCR2WFile(ResourcePath path, bool includeMods = true, bool includeProject = true);


        public abstract IObservable<IChangeSet<RedFileSystemModel>> ConnectGameRoot();

        public abstract IObservable<IChangeSet<RedFileSystemModel>> ConnectModRoot();
    }
}
