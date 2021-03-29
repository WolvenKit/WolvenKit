using System.Diagnostics;
using System.IO;
using FastMember;
using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
    public class worldInstancedOccluderNode : worldInstancedOccluderNode_
    {
        private CArrayVLQInt32<worldInstancedOccluderNode_UnkClass1> _unknown1;

        [Ordinal(1000)]
        [REDBuffer(true)]
        public CArrayVLQInt32<worldInstancedOccluderNode_UnkClass1> Unknown1
        {
            get => GetProperty(ref _unknown1);
            set => SetProperty(ref _unknown1, value);
        }

        public worldInstancedOccluderNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            Unknown1.ReadWithoutMeta(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            Unknown1.WriteWithoutMeta(file);
        }
    }

    public class worldInstancedOccluderNode_UnkClass1 : CVariable
    {
        private CArrayCompressed<Vector4> _unknown1;

        [Ordinal(1000)]
        [REDBuffer(true)]
        public CArrayCompressed<Vector4> Unknown1
        {
            get => GetProperty(ref _unknown1);
            set => SetProperty(ref _unknown1, value);
        }

        public worldInstancedOccluderNode_UnkClass1(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public override void ReadWithoutMeta(BinaryReader file, uint size)
        {
            Unknown1.ReadWithoutMeta(file, size, 4);
        }

        public override void WriteWithoutMeta(BinaryWriter file)
        {
            Unknown1.WriteWithoutMeta(file);
        }
    }
}
