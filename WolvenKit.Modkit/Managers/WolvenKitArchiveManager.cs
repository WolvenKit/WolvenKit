using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using DynamicData;
using ProtoBuf;

namespace WolvenKit.Common.Model
{
    [ProtoContract]
    public abstract class WolvenKitArchiveManager : IGameArchiveManager
    {
        public abstract EArchiveType TypeName { get; }

        public abstract Dictionary<string, IGameArchive> Archives { get; set; }
        public SourceCache<IGameFile, ulong> Items { get; set; } = new(x => x.Key);

        public GameFileTreeNode RootNode { get; set; }

        //public IEnumerable<IGameFile> FileList => Items.Values.SelectMany(_ => _);
        //public IEnumerable<string> AutocompleteSource { get; set; } //=> FileList.Select(_ => GetFileName(_.Name)).Distinct();
        public IEnumerable<string> Extensions { get; set; } //=> FileList.Select(_ => _.Extension).Distinct();


        public abstract void LoadAll(FileInfo executable, bool rebuildtree = true);

        public abstract void LoadArchive(string filename, bool ispatch = false);

        public abstract void LoadModArchive(string filename);
        public abstract void LoadModsArchives(string mods, string dlc);

        protected static string GetModFolder(string path)
        {
            if (path.Split('\\').Length > 3 && path.Split('\\').Contains("content"))
            {
                return path.Split('\\')[path.Split('\\').ToList().IndexOf(path.Split('\\').FirstOrDefault(x => x == "content")) - 1];
            }
            return path;
        }

        protected void RebuildRootNode()
        {
            RootNode = new GameFileTreeNode()
            {
                Name = TypeName.ToString()
            };
            foreach (var item in Items.KeyValues)
            {
                var currentNode = RootNode;
                var model = item.Value;
                var parts = model.Name.Split('\\');

                for (var i = 0; i < parts.Length - 1; i++)
                {
                    if (!currentNode.Directories.Any(_ => _.Name == parts[i]))
                    {
                        var newNode = new GameFileTreeNode
                        {
                            Parent = currentNode,
                            Name = parts[i]
                        };
                        currentNode.Directories.Add(newNode);
                        currentNode = newNode;
                    }
                    else
                    {
                        currentNode = currentNode.Directories.First(_ => _.Name == parts[i]);
                    }
                }

                currentNode.Files.Add(item.Value);
                currentNode.Directories = new ObservableCollection<GameFileTreeNode>(currentNode.Directories.OrderBy(_ => _.Name)); 
            }
        }


        /// <summary>
        /// Since File.GetFileName() only works for real paths we need to have this
        /// </summary>
        /// <param name="s">Path/Name of the file</param>
        /// <returns></returns>
        public static string GetFileName(string s) => s.Contains('\\') ? s.Split('\\').Last() : s;


        /// <summary>
        /// Deep search for files
        /// </summary>
        /// <param name="mainnode">The rootnode to get the files from</param>
        /// <returns></returns>
        private static List<IGameFile> GetFiles(GameFileTreeNode mainnode)
        {
            var bundfiles = new List<IGameFile>();
            if (mainnode?.Files != null)
            {
                foreach (var wfile in mainnode.Files)
                {
                    bundfiles.Add(wfile);
                }
                bundfiles.AddRange(mainnode.Directories.SelectMany(GetFiles));
            }
            return bundfiles;
        }
    }
}
