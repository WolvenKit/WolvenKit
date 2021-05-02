using System.IO;
using FastMember;
using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
    public class worldStreamingWorld : worldStreamingWorld_
    {
        private CUInt32 _unknown1;

        [Ordinal(30)]
        [REDBuffer(true)]
        public CUInt32 Unknown1
        {
            get => GetProperty(ref _unknown1);
            set => SetProperty(ref _unknown1, value);
        }

        public worldStreamingWorld(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public override void Read(BinaryReader file, uint size)
        {
            cr2w.UnknownVars.Add(this.UniqueIdentifier);

            base.Read(file, size);

            Unknown1.ReadWithoutMeta(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            Unknown1.WriteWithoutMeta(file);
        }
    }
}
