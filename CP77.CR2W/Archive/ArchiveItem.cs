using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Catel.IoC;
using CP77.Common.Services;

namespace CP77.CR2W.Archive
{
    public class FileInfoEntry
    {
        public ulong NameHash64 { get; private set; }
        public DateTime DateTime { get; private set; }
        public uint FileFlags { get; private set; }
        public uint FirstDataSector { get; private set; }
        public uint NextDataSector { get; private set; }
        public uint FirstUnkIndex { get; private set; }
        public uint NextUnkIndex { get; private set; }
        public byte[] SHA1Hash { get; private set; }

        private string _nameStr;
        public string NameStr => string.IsNullOrEmpty(_nameStr) ? $"{NameHash64}.bin" : _nameStr;
        public string Extension => Path.GetExtension(NameStr);

        private Archive _parentArchive;

        public FileInfoEntry(BinaryReader br, Archive parent)
        {
            _parentArchive = parent;
            var mainController = ServiceLocator.Default.ResolveType<IMainController>();

            Read(br, mainController);
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
