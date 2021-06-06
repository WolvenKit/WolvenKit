using System.Collections.Generic;

namespace WolvenKit.Common.Model
{
    public enum EntryType
    {
        Directory,
        File,
        MoveUP
    }

    public class AssetBrowserData
    {
        private readonly string _extension;

        public AssetBrowserData(string extension)
        {
            _extension = extension;
        }

        #region Properties

        public List<IGameFile> AmbigiousFiles { get; set; }
        public GameFileTreeNode Children { get; set; }
        public string Name { get; set; }
        public ulong Hash { get; set; }
        public GameFileTreeNode Parent { get; set; }
        public string Size { get; set; }
        public GameFileTreeNode This { get; set; }
        public EntryType Type { get; set; }

        #endregion Properties

        public string GetExtension() => _extension.TrimStart('.');

        public string Extension => GetExtension();
    }
}
