using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using DynamicData;
using ProtoBuf;
using WolvenKit.Common.Services;

namespace WolvenKit.Common.Model
{
    [ProtoContract]
    public abstract class WolvenKitArchiveManager : IGameArchiveManager
    {
        public abstract EArchiveType TypeName { get; }

        public abstract Dictionary<string, IGameArchive> Archives { get; set; }
        public SourceCache<IGameFile, ulong> Items { get; set; } = new(x => x.Key);

        public RedFileSystemModel RootNode { get; set; }

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

        //private Dictionary<ulong, RedDirectoryViewModel> _directoryDict = new();
        //public bool ContainsDirectory(ulong key) => _directoryDict.ContainsKey(key);
        //public RedDirectoryViewModel GetDirectoryByKey(ulong key) => _directoryDict[key];   

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

                        //var h = newNode.Key;
                        //if (!_directoryDict.ContainsKey(h))
                        //{
                        //    _directoryDict.Add(h, newNode);
                        //}
                        //else
                        //{

                        //}
                    }
                    else
                    {
                        // add to existing directory
                        currentNode = currentNode.Directories.First(_ => _.Name == part);
                    }
                }

                // add file to the last directory in path
                currentNode.Files.Add(item.Key);
                //var dbg_ordered = currentNode.Directories.OrderBy(_ => _.Name);
                //currentNode.Directories = new ObservableCollection<RedDirectoryViewModel>(dbg_ordered); 
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
        //private static List<IGameFile> GetFiles(RedDirectoryViewModel mainnode)
        //{
        //    var bundfiles = new List<IGameFile>();
        //    if (mainnode?.Files != null)
        //    {
        //        foreach (var wfile in mainnode.Files)
        //        {
        //            bundfiles.Add(wfile.GetGameFile());
        //        }
        //        bundfiles.AddRange(mainnode.Directories.SelectMany(GetFiles));
        //    }
        //    return bundfiles;
        //}
    }
}
