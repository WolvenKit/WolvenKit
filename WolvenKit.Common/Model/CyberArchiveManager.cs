using System;
using System.Collections.Generic;
using System.Linq;

namespace WolvenKit.Common
{
    /// <summary>
    ///
    /// </summary>
    public abstract class CyberArchiveManager : IGameArchiveManager
    {
        #region Fields

        protected readonly string[] VanillaDlClist = new string[] { "DLC1", "DLC2", "DLC3", "DLC4", "DLC5", "DLC6", "DLC7", "DLC8", "DLC9", "DLC10", "DLC11", "DLC12", "DLC13", "DLC14", "DLC15", "DLC16", "bob", "ep1" };

        #endregion Fields

        #region Properties

        public List<string> AutocompleteSource { get; set; }
        public List<string> Extensions { get; set; } = new();
        public List<IGameFile> FileList { get; set; }
        public Dictionary<string, List<IGameFile>> Items { get; set; }
        public GameFileTreeNode RootNode { get; set; }
        public abstract EArchiveType TypeName { get; }

        #endregion Properties

        #region Methods

        public abstract void LoadAll(string exedir);

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

        /// <summary>
        ///     Rebuilds the bundle tree structure also rebuilds NOTE: Filelist,autocomplete,extensions
        /// </summary>
        protected void RebuildRootNode()
        {
            RootNode = new GameFileTreeNode(TypeName)
            {
                Name = TypeName.ToString()
            };
            foreach (var item in Items)
            {
                var currentNode = RootNode;
                var parts = item.Key.Split('\\');

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

                currentNode.Files.Add(parts[parts.Length - 1], item.Value);
            }
            RebuildFileList();
            RebuildExtensions();
            RebuildAutoCompleteSource();
        }

        /// <summary>
        /// Since File.GetFileName() only works for real paths we need to have this
        /// </summary>
        /// <param name="s">Path/Name of the file</param>
        /// <returns></returns>
        private static string GetFileName(string s)
        {
            return s.Contains('\\') ? s.Split('\\').Last() : s;
        }

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

        /// <summary>
        /// Gets the distinct filenames from the loaded bundles so they can be used for autocomplete
        /// </summary>
        private void RebuildAutoCompleteSource()
        {
            AutocompleteSource = new List<string>();
            AutocompleteSource.AddRange(FileList.Select(x => GetFileName(x.Name)).Distinct().ToArray());
        }

        /// <summary>
        /// Gets the avaliable extensions in the files
        /// </summary>
        private void RebuildExtensions()
        {
            foreach (var file in FileList.Where(file => !Extensions.Contains(file.Name.Split('.').Last())))
            {
                Extensions.Add(file.Name.Split('.').Last());
            }
            Extensions.Sort();
        }

        /// <summary>
        /// Calls GetFiles on the rootnode
        /// </summary>
        private void RebuildFileList()
        {
            FileList = GetFiles(RootNode);
        }

        #endregion Methods
    }
}
