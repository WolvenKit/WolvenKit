using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WolvenKit.Common.Model;

namespace WolvenKit.Common
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class WitcherArchiveManager : IWitcherArchiveManager
    {
        public WitcherTreeNode RootNode { get; set; }
        public List<IWitcherFile> FileList { get; set; }
        public Dictionary<string, List<IWitcherFile>> Items { get; set; }
        public AutoCompleteStringCollection AutocompleteSource { get; set; }
        public List<string> Extensions { get; set; }


        public abstract EBundleType TypeName { get; }

        public abstract void LoadModBundle(string filename);
        public abstract void LoadBundle(string filename, bool ispatch = false);
        public abstract void LoadAll(string exedir);
        public abstract void LoadModsBundles(string mods, string dlc);


        protected readonly string[] VanillaDlClist = new string[] { "DLC1", "DLC2", "DLC3", "DLC4", "DLC5", "DLC6", "DLC7", "DLC8", "DLC9", "DLC10", "DLC11", "DLC12", "DLC13", "DLC14", "DLC15", "DLC16", "bob", "ep1" };

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
            RootNode = new WitcherTreeNode(TypeName)
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
                        var newNode = new WitcherTreeNode
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
        /// Calls GetFiles on the rootnode
        /// </summary>
        private void RebuildFileList()
        {
            FileList = GetFiles(RootNode);
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
        /// Gets the distinct filenames from the loaded bundles so they can be used for autocomplete
        /// </summary>
        private void RebuildAutoCompleteSource()
        {
            AutocompleteSource.AddRange(FileList.Select(x => GetFileName(x.Name)).Distinct().ToArray());
        }

        /// <summary>
        /// Deep search for files
        /// </summary>
        /// <param name="mainnode">The rootnode to get the files from</param>
        /// <returns></returns>
        private static List<IWitcherFile> GetFiles(WitcherTreeNode mainnode)
        {
            var bundfiles = new List<IWitcherFile>();
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
        /// Since File.GetFileName() only works for real paths we need to have this
        /// </summary>
        /// <param name="s">Path/Name of the file</param>
        /// <returns></returns>
        private static string GetFileName(string s)
        {
            return s.Contains('\\') ? s.Split('\\').Last() : s;
        }
    }


}
