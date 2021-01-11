using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WolvenKit.Common.Model
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

        public string Name { get; set; }
        public GameFileTreeNode Parent { get; set; }
        public Dictionary<string, GameFileTreeNode> Directories { get; set; }
        public Dictionary<string, List<IGameFile>> Files { get; set; }
    }
}
