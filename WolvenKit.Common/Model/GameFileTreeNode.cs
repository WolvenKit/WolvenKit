using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading;
using WolvenKit.Common.Model;

namespace WolvenKit.Common
{
    public class GameFileTreeNode
    {
        #region Constructors

        public GameFileTreeNode()
        {
            Directories = new ObservableCollection<GameFileTreeNode>();
            Files = new List<IGameFile>();
            Name = "";
        }

        public GameFileTreeNode(EArchiveType bundleType)
        {
            Directories = new ObservableCollection<GameFileTreeNode>();
            Files = new List<IGameFile>();
            Name = "";
        }

        #endregion Constructors

        #region Properties

        public string Name { get; set; }

        public GameFileTreeNode Parent { get; set; }

        public ObservableCollection<GameFileTreeNode> Directories { get; set; }

        public List<IGameFile> Files { get; set; }

        public string Extension => nameof(ECustomImageKeys.ClosedDirImageKey);

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

        #endregion Properties
   
        public override string ToString() => Name;

    }
}
