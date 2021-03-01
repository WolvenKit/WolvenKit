using System.Collections.Generic;

namespace WolvenKit.Common.Model
{
    public class AssetBrowserData
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public string Extension { get; set; }
        public GameFileTreeNode Parent { get; set; }
        public GameFileTreeNode This { get; set; }
        public GameFileTreeNode Children { get; set; }
        public EntryType Type { get; set; }
        public List<IGameFile> AmbigiousFiles { get; set; }
    }

    public enum EntryType
    {
        Directory,
        File,
        MoveUP
    }
}
