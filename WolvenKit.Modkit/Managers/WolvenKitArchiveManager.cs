using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using DynamicData;
using ProtoBuf;
using ReactiveUI;
using WolvenKit.Common.Services;
using WolvenKit.RED4.CR2W.Archive;

namespace WolvenKit.Common.Model
{
    [ProtoContract]
    public abstract class WolvenKitArchiveManager : ReactiveObject, IArchiveManager
    {
        #region properties

        public abstract EArchiveType TypeName { get; }

        public abstract Dictionary<string, IGameArchive> Archives { get; set; }

        public SourceCache<IGameFile, ulong> Items { get; set; } = new(x => x.Key);

        public RedFileSystemModel RootNode { get; set; }

        //public IEnumerable<string> AutocompleteSource { get; set; } //=> FileList.Select(_ => GetFileName(_.Name)).Distinct();

        public IEnumerable<string> Extensions { get; set; } //=> FileList.Select(_ => _.Extension).Distinct();

        public abstract bool IsManagerLoaded { get; set; }

        #endregion


        public abstract void LoadAll(FileInfo executable, bool rebuildtree = true);

        public abstract void LoadArchive(string filename, bool ispatch = false);

        public abstract void LoadModArchive(string filename);

        public abstract void LoadModsArchives(DirectoryInfo modsDir, DirectoryInfo dlcDir);

        protected static string GetModFolder(string path)
        {
            if (path.Split('\\').Length > 3 && path.Split('\\').Contains("content"))
            {
                return path.Split('\\')[path.Split('\\').ToList().IndexOf(path.Split('\\').FirstOrDefault(x => x == "content")) - 1];
            }
            return path;
        }

        protected void RebuildRootNode(IHashService _hashService)
        {
            RootNode = new RedFileSystemModel(TypeName.ToString());

            // loop through all files
            foreach (var item in Items.KeyValues)
            {
                var currentNode = RootNode;
                var model = item.Value;
                var parts = model.Name.Split('\\');

                // loop through path
                var fullpath = "";
                for (var i = 0; i < parts.Length - 1; i++)
                {
                    var part = parts[i];
                    fullpath += part + Path.DirectorySeparatorChar;
                    // directory does not already exist
                    if (!currentNode.Directories.Any(_ => _.Name == part))
                    {
                        var newNode = new RedFileSystemModel(fullpath.TrimEnd(Path.DirectorySeparatorChar));
                        currentNode.Directories.Add(newNode);
                        currentNode = newNode;
                    }
                    else
                    {
                        // add to existing directory
                        currentNode = currentNode.Directories.First(_ => _.Name == part);
                    }
                }

                // add file to the last directory in path
                currentNode.Files.Add(item.Key);
            }
        }

        public abstract RedFileSystemModel LookupDirectory(string fullpath, bool expandAll = false);
        public abstract IGameFile LookupFile(ulong hash);
        public abstract Dictionary<string, IEnumerable<FileEntry>> GetGroupedFiles();
        public abstract void LoadFromFolder(DirectoryInfo archivedir, bool rebuildtree = false);
        public abstract IObservable<IChangeSet<RedFileSystemModel>> ConnectGameArchives();
    }
}
