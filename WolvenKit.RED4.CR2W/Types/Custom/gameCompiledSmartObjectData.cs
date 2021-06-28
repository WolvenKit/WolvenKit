using System.Collections.Generic;
using System.IO;
using FastMember;
using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
    public class gameCompiledSmartObjectData : gameCompiledSmartObjectData_
    {
        private CInt32 _unknown1;
        private CUInt8 _unknown2;
        private CArrayVLQInt32<CUInt16> _unknown3;
        private CUInt8 _unknown4;

        [Ordinal(0)]
        [REDBuffer(true)]
        public CInt32 Unknown1
        {
            get => GetProperty(ref _unknown1);
            set => SetProperty(ref _unknown1, value);
        }

        [Ordinal(1)]
        [REDBuffer(true)]
        public CUInt8 Unknown2
        {
            get => GetProperty(ref _unknown2);
            set => SetProperty(ref _unknown2, value);
        }

        [Ordinal(2)]
        [REDBuffer(true)]
        public CArrayVLQInt32<CUInt16> Unknown3
        {
            get => GetProperty(ref _unknown3);
            set => SetProperty(ref _unknown3, value);
        }

        [Ordinal(3)]
        [REDBuffer(true)]
        public CUInt8 Unknown4
        {
            get => GetProperty(ref _unknown4);
            set => SetProperty(ref _unknown4, value);
        }

        public gameCompiledSmartObjectData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public override void Read(BinaryReader file, uint size)
        {
            cr2w.UnknownVars.Add(this.UniqueIdentifier);

            Unknown1.ReadWithoutMeta(file, size);
            Unknown2.ReadWithoutMeta(file, size);
            Unknown3.ReadWithoutMeta(file, size);
            Unknown4.ReadWithoutMeta(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            Unknown1.WriteWithoutMeta(file);
            Unknown2.WriteWithoutMeta(file);
            Unknown3.WriteWithoutMeta(file);
            Unknown4.WriteWithoutMeta(file);
        }
    }
}
