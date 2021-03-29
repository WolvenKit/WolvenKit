using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using FastMember;
using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
    public class worldStreamingSector : worldStreamingSector_
    {
        private CUInt32 _unknown1;
        private CUInt32 _unknown2;
        private CArrayVLQInt32<CUInt32> _unknown3;
        private CArrayVLQInt32<CString> _unknown4;
        private CArrayVLQInt32<CUInt32> _unknown5;
        private CUInt32 _unknown6;

        [Ordinal(1000)]
        [REDBuffer(true)]
        public CUInt32 Unknown1
        {
            get => GetProperty(ref _unknown1);
            set => SetProperty(ref _unknown1, value);
        }

        [Ordinal(1001)]
        [REDBuffer(true)]
        public CUInt32 Unknown2
        {
            get => GetProperty(ref _unknown2);
            set => SetProperty(ref _unknown2, value);
        }

        [Ordinal(1002)]
        [REDBuffer(true)]
        public CArrayVLQInt32<CUInt32> Unknown3
        {
            get => GetProperty(ref _unknown3);
            set => SetProperty(ref _unknown3, value);
        }

        [Ordinal(1003)]
        [REDBuffer(true)]
        public CArrayVLQInt32<CString> Unknown4
        {
            get => GetProperty(ref _unknown4);
            set => SetProperty(ref _unknown4, value);
        }

        [Ordinal(1004)]
        [REDBuffer(true)]
        public CArrayVLQInt32<CUInt32> Unknown5
        {
            get => GetProperty(ref _unknown5);
            set => SetProperty(ref _unknown5, value);
        }

        [Ordinal(1005)]
        [REDBuffer(true)]
        public CUInt32 Unknown6
        {
            get => GetProperty(ref _unknown6);
            set => SetProperty(ref _unknown6, value);
        }

        public worldStreamingSector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            Unknown1.ReadWithoutMeta(file, size); // always 59?

            var size2 = file.ReadUInt32(); // size + itself

            Unknown2.ReadWithoutMeta(file, size); // always 2147483649?
            Unknown3.ReadWithoutMeta(file, size);
            Unknown4.ReadWithoutMeta(file, size);
            Unknown5.ReadWithoutMeta(file, size);
            Unknown6.ReadWithoutMeta(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            Unknown1.WriteWithoutMeta(file);

            var startPos = file.BaseStream.Position;
            file.Write((int)0);

            Unknown2.WriteWithoutMeta(file);
            Unknown3.WriteWithoutMeta(file);
            Unknown4.WriteWithoutMeta(file);
            Unknown5.WriteWithoutMeta(file);
            Unknown6.WriteWithoutMeta(file);

            var currentPos = file.BaseStream.Position;
            file.BaseStream.Position = startPos;
            file.Write((int)(currentPos - startPos));
            file.BaseStream.Position = currentPos;
        }
    }
}
