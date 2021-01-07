using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Catel.IO;
using System.Linq;
using System.Reflection;
using Catel.Collections;
using CP77Tools.Model;
using WolvenKit.Common;
using WolvenKit.Common.Model;

namespace CP77.CR2W.Archive
{
    public class ArchiveManager : IGameArchiveManager
    {
        public ArchiveManager(DirectoryInfo indir)
        {
            _parentDirectoryInfo = indir;

            Archives = new List<Archive>();
            Files = new Dictionary<ulong, List<ArchiveItem>>();
            Extensions = new List<string>();

            // load files
            Reload(indir);
        }

        public ArchiveManager()
        {
        }

        private DirectoryInfo _parentDirectoryInfo;

        #region properties

        public List<Archive> Archives { get; }
        public List<string> Extensions { get; }
        public Dictionary<ulong, List<ArchiveItem>> Files { get; }
        public Dictionary<string, List<ArchiveItem>> GroupedFiles => 
        
            Files.Values.GroupBy(
                f => f.FirstOrDefault().Extension,
                file => file,
                (ext, items) => new
                {
                    Key = ext,
                    File = items.Where(_ => _.FirstOrDefault().Extension == ext).SelectMany(_ => _).ToList()
                }).ToDictionary(_ => _.Key, _ => _.File);

        public WitcherTreeNode RootNode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IGameFile> FileList { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public EBundleType TypeName => throw new NotImplementedException();

        List<string> IGameArchiveManager.Extensions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<string> AutocompleteSource { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Dictionary<string, List<IGameFile>> Items { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        #endregion



        #region methods
        public void LoadAll(string exedir)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Reload the ArchiveManager from given directory (optional).
        /// </summary>
        /// <param name="indir"></param>
        public void Reload(DirectoryInfo indir = null)
        {
            if (indir != null)
                _parentDirectoryInfo = indir;


            var archives = _parentDirectoryInfo.GetFiles("*.archive").ToList();
            Archives.Clear();
            foreach (var fi in archives)
            {
                Archives.Add(new Archive(fi.FullName));
            }

            ReloadFiles();
        }

        /// <summary>
        /// Reloads file list from stored archives
        /// </summary>
        private void ReloadFiles()
        {
            Files.Clear();
            Extensions.Clear();

            foreach (var archive in Archives)
            {
                foreach (var (hash, value) in archive.Files)
                {
                    // add file
                    if (!Files.ContainsKey(hash))
                        Files.Add(hash, new List<ArchiveItem>());
                    Files[hash].Add(value);

                    // add extension
                    if (!Extensions.Contains(value.Extension))
                        Extensions.Add(value.Extension);
                }
            }

            

        }

        #endregion

    }
}
