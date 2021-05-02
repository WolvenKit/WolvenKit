using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using FastMember;
using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
    public class gameCompiledCoverData : gameCompiledCoverData_
    {
        private CUInt64 _unknown5;
        private Vector3 _unknown6;

        [Ordinal(4)]
        [REDBuffer(true)]
        public CUInt64 Unknown5
        {
            get => GetProperty(ref _unknown5);
            set => SetProperty(ref _unknown5, value);
        }

        [Ordinal(5)]
        [REDBuffer(true)]
        public Vector3 Unknown6
        {
            get => GetProperty(ref _unknown6);
            set => SetProperty(ref _unknown6, value);
        }

        public gameCompiledCoverData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            Unknown5.ReadWithoutMeta(file, size);
            Unknown6.ReadWithoutMeta(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            Unknown5.WriteWithoutMeta(file);
            Unknown6.WriteWithoutMeta(file);
        }
    }
}
