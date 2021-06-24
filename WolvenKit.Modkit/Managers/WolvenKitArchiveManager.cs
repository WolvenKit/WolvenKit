using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace WolvenKit.Common.Model
{
    [ProtoContract]
    public abstract class WolvenKitArchiveManager : IGameArchiveManager
    {
        public abstract EArchiveType TypeName { get; }

        public abstract Dictionary<string, IGameArchive> Archives { get; set; }
        public GameFileTreeNode RootNode { get; set; }

        public Dictionary<ulong, IEnumerable<IGameFile>> Items { get; set; } = new();


        public IEnumerable<IGameFile> FileList => Items.Values.SelectMany(_ => _);
        public IEnumerable<string> AutocompleteSource => FileList.Select(_ => GetFileName(_.Name)).Distinct();
        public IEnumerable<string> Extensions => FileList.Select(_ => _.Extension).Distinct();


        public abstract void LoadAll(string exedir, bool rebuildTree = true);

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
            RootNode = new GameFileTreeNode(TypeName)
            {
                Name = TypeName.ToString()
            };
            foreach (var item in Items)
            {
                var currentNode = RootNode;
                var model = item.Value;
                var parts = model.First().Name.Split('\\');

                for (var i = 0; i < parts.Length - 1; i++)
                {
                    if (!currentNode.Directories.ContainsKey(parts[i]))
                    {
                        var newNode = new GameFileTreeNode
                        {
                            Parent = currentNode,
                            Name = parts[i]
                        };
                        currentNode.Directories.Add(parts[i], newNode);
                        currentNode = newNode;
                    }
                    else
                    {
                        currentNode = currentNode.Directories[parts[i]];
                    }
                }

                currentNode.Files.Add(parts[^1], item.Value.ToList());
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
                    bundfiles.AddRange(wfile.Value);
                }
                bundfiles.AddRange(mainnode.Directories.Values.SelectMany(GetFiles));
            }
            return bundfiles;
        }
    }
}
