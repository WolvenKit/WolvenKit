using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WolvenKit.Common.Model;

namespace WolvenKit.Common
{
    public class GameFileTreeNode
    {
        public GameFileTreeNode()
        {
            Directories = new Dictionary<string, GameFileTreeNode>();
            Files = new Dictionary<string, List<IGameFile>>();
            Name = "";
        }

        public GameFileTreeNode(EArchiveType bundleType)
        {
            Directories = new Dictionary<string, GameFileTreeNode>();
            Files = new Dictionary<string, List<IGameFile>>();
            Name = "";
        }

        public EArchiveType Type
        {
            get
            {
                // Getting the type of the archive by its path
                string[] bundlenodenames = FullPath.Split(Path.DirectorySeparatorChar);
                string bundlename;
                //At app startup there will be no Root prefixed, but after it will
                if (bundlenodenames.First() == "Root")
                {
                    bundlename = bundlenodenames.Skip(1).First();
                }
                else
                {
                    bundlename = bundlenodenames.First();
                }

                if (String.IsNullOrEmpty(bundlename) || bundlename.ToUpper() == "ROOT" || bundlename.ToUpper() == "DEPOT")
                    bundlename = EArchiveType.ANY.ToString();

                return (EArchiveType)Enum.Parse(typeof(EArchiveType), bundlename);
            }
        }

        public string FullPath
        {
            get
            {
                var path = "";
                var current = this;
                while (true)
                {
                    path = Path.Combine(current.Name, path);
                    current = current.Parent;
                    if (current == null)
                        break;
                }

                return path ?? "";
            }
        }

        public List<GameFileTreeNode> SubDirectories => Directories.Values.ToList();

        public string Name { get; set; }
        public GameFileTreeNode Parent { get; set; }
        public Dictionary<string, GameFileTreeNode> Directories { get; set; }
        public Dictionary<string, List<IGameFile>> Files { get; set; }

        public List<AssetBrowserData> ToAssetBrowserData()
        {
            var ret = new List<AssetBrowserData>();
            ret.Add(new AssetBrowserData()
            {
                Name = "..",
                Type = EntryType.MoveUP,
                This = this,
                Parent = this.Parent
            });
            ret.AddRange(Directories.Select(d => new AssetBrowserData()
            {
                Name = d.Key,
                Size = d.Value.Directories.Count + " directories, " + d.Value.Files.Count + " files",
                Parent = this.Parent,
                Children = d.Value,
                This = this,
                Type = EntryType.Directory
            }));

            ret.AddRange(Files.Select(f => new AssetBrowserData()
            {
                Name = f.Key,
                Size = f.Value[0].Size + " bytes",
                This = this,
                Type = EntryType.File,
                Parent = this.Parent
            }));

            return ret;
        }
    }
}
