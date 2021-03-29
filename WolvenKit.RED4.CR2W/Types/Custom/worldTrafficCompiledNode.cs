using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using FastMember;
using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
    public class worldTrafficCompiledNode : worldTrafficCompiledNode_
    {
        private CUInt16 _unknown1;
        private CArrayVLQInt32<worldTrafficCompiledNode_UnkClass1> _unknown2;

        [Ordinal(1000)]
        [REDBuffer(true)]
        public CUInt16 Unknown1
        {
            get => GetProperty(ref _unknown1);
            set => SetProperty(ref _unknown1, value);
        }

        [Ordinal(1001)]
        [REDBuffer(true)]
        public CArrayVLQInt32<worldTrafficCompiledNode_UnkClass1> Unknown2
        {
            get => GetProperty(ref _unknown2);
            set => SetProperty(ref _unknown2, value);
        }

        public worldTrafficCompiledNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            Unknown1.ReadWithoutMeta(file, size);
            Unknown2.ReadWithoutMeta(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            Unknown1.WriteWithoutMeta(file);
            Unknown2.WriteWithoutMeta(file);
        }
    }

    public class worldTrafficCompiledNode_UnkClass1 : CVariable
    {
        private CUInt32 _unknown1;
        private CBytes _unknown2;
        private CBytes _unknown3;
        private CArrayVLQInt32<worldTrafficCompiledNode_UnkClass2> _unknown4;
        private CArrayVLQInt32<CUInt32> _unknown5;

        [Ordinal(1000)]
        [REDBuffer(true)]
        public CUInt32 Unknown1
        {
            get => GetProperty(ref _unknown1);
            set => SetProperty(ref _unknown1, value);
        }

        [Ordinal(1001)]
        [REDBuffer(true)]
        public CBytes Unknown2
        {
            get => GetProperty(ref _unknown2);
            set => SetProperty(ref _unknown2, value);
        }

        [Ordinal(1002)]
        [REDBuffer(true)]
        public CBytes Unknown3
        {
            get => GetProperty(ref _unknown3);
            set => SetProperty(ref _unknown3, value);
        }

        [Ordinal(1003)]
        [REDBuffer(true)]
        public CArrayVLQInt32<worldTrafficCompiledNode_UnkClass2> Unknown4
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

        public worldTrafficCompiledNode_UnkClass1(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public override void ReadWithoutMeta(BinaryReader file, uint size)
        {
            Unknown1.ReadWithoutMeta(file, size);
            Unknown2.Read(file, 0x20);
            Unknown3.Read(file, 0x15);
            Unknown4.ReadWithoutMeta(file, size);
            Unknown5.ReadWithoutMeta(file, size);
        }

        public override void WriteWithoutMeta(BinaryWriter file)
        {
            Unknown1.WriteWithoutMeta(file);
            Unknown2.Write(file);
            Unknown3.Write(file);
            Unknown4.WriteWithoutMeta(file);
            Unknown5.WriteWithoutMeta(file);
        }
    }

    public class worldTrafficCompiledNode_UnkClass2 : CVariable
    {
        private CBytes _unknown1;
        private CArrayVLQInt32<CUInt64> _unknown2;

        [Ordinal(1000)]
        [REDBuffer(true)]
        public CBytes Unknown1
        {
            get => GetProperty(ref _unknown1);
            set => SetProperty(ref _unknown1, value);
        }

        [Ordinal(1001)]
        [REDBuffer(true)]
        public CArrayVLQInt32<CUInt64> Unknown2
        {
            get => GetProperty(ref _unknown2);
            set => SetProperty(ref _unknown2, value);
        }

        public worldTrafficCompiledNode_UnkClass2(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public override void ReadWithoutMeta(BinaryReader file, uint size)
        {
            Unknown1.Read(file, 0x0D);
            Unknown2.ReadWithoutMeta(file, size);
        }

        public override void WriteWithoutMeta(BinaryWriter file)
        {
            Unknown1.Write(file);
            Unknown2.WriteWithoutMeta(file);
        }
    }
}
