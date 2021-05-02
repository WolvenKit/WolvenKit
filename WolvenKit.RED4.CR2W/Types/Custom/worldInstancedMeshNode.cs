using System.IO;
using FastMember;
using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
    public class worldInstancedMeshNode : worldInstancedMeshNode_
    {
        private CArrayVLQInt32<worldInstancedMeshNode_UnkClass1> _unknown1;
        private CArrayVLQInt32<CFloat> _unknown2;
        private CArrayVLQInt32<CUInt32> _unknown3;

        [Ordinal(1000)]
        [REDBuffer(true)]
        public CArrayVLQInt32<worldInstancedMeshNode_UnkClass1> Unknown1
        {
            get => GetProperty(ref _unknown1);
            set => SetProperty(ref _unknown1, value);
        }

        [Ordinal(1001)]
        [REDBuffer(true)]
        public CArrayVLQInt32<CFloat> Unknown2
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

        public worldInstancedMeshNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public override void Read(BinaryReader file, uint size)
        {
            cr2w.UnknownVars.Add(this.UniqueIdentifier);

            base.Read(file, size);

            Unknown1.ReadWithoutMeta(file, size);
            Unknown2.ReadWithoutMeta(file, size);
            Unknown3.ReadWithoutMeta(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            Unknown1.WriteWithoutMeta(file);
            Unknown2.WriteWithoutMeta(file);
            Unknown3.WriteWithoutMeta(file);
        }
    }

    public class worldInstancedMeshNode_UnkClass1 : CVariable
    {
        private Vector4 _unknown1;
        private Vector4 _unknown2;

        [Ordinal(1000)]
        [REDBuffer(true)]
        public Vector4 Unknown1
        {
            get => GetProperty(ref _unknown1);
            set => SetProperty(ref _unknown1, value);
        }

        [Ordinal(1001)]
        [REDBuffer(true)]
        public Vector4 Unknown2
        {
            get => GetProperty(ref _unknown2);
            set => SetProperty(ref _unknown2, value);
        }

        public worldInstancedMeshNode_UnkClass1(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public override void ReadWithoutMeta(BinaryReader file, uint size)
        {
            Unknown1.ReadWithoutMeta(file, size);
            Unknown2.ReadWithoutMeta(file, size);
        }

        public override void WriteWithoutMeta(BinaryWriter file)
        {
            Unknown1.WriteWithoutMeta(file);
            Unknown2.WriteWithoutMeta(file);
        }
    }
}
