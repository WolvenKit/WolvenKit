using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Catel.IoC;
using CP77.Common.Services;

namespace CP77.CR2W.Archive
{
    public class ArchiveItem
    {
        public ulong NameHash64 { get; set; }
        public DateTime DateTime { get; set; }
        public uint FileFlags { get; set; }
        public uint FirstDataSector { get; set; }
        public uint NextDataSector { get; set; }
        public uint FirstUnkIndex { get; set; }
        public uint NextUnkIndex { get; set; }
        public byte[] SHA1Hash { get; set; }

        private string _nameStr;
        public string NameStr => string.IsNullOrEmpty(_nameStr) ? $"{NameHash64}.bin" : _nameStr;
        public string Extension => Path.GetExtension(NameStr);

        private Archive _parentArchive;

        public ArchiveItem(BinaryReader br, Archive parent)
        {
            _parentArchive = parent;
            var mainController = ServiceLocator.Default.ResolveType<IMainController>();

            Read(br, mainController);
        }

        public ArchiveItem(Archive parent)
        {

        }

        private void Read(BinaryReader br, IMainController mainController)
        {
            NameHash64 = br.ReadUInt64();

            if (mainController != null && mainController.Hashdict.ContainsKey(NameHash64))
                _nameStr = mainController.Hashdict[NameHash64];

            DateTime = DateTime.FromFileTime(br.ReadInt64());


            FileFlags = br.ReadUInt32();
            FirstDataSector = br.ReadUInt32();
            NextDataSector = br.ReadUInt32();
            FirstUnkIndex = br.ReadUInt32();
            NextUnkIndex = br.ReadUInt32();

            SHA1Hash = br.ReadBytes(20);
        }
    }
}
