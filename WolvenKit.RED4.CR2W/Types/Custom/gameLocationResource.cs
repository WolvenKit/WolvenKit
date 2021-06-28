using System;
using System.IO;
using WolvenKit.Core.Extensions;
using WolvenKit.Interfaces.Extensions;
using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
	public class gameLocationResource : gameLocationResource_
    {
        private const uint Version = 0;

		public gameLocationResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            var version = file.ReadUInt32();
            if (version != Version)
                throw new NotImplementedException($"{nameof(gameLocationResource)} - version mismatch");
            var datasize = file.ReadUInt32() - 4;

            var count = file.ReadVLQInt32();
            for (int i = 0; i < count; i++)
            {
                // unused
            }
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            file.Write(Version);

            using var ms = new MemoryStream();
            using var bw = new BinaryWriter(ms);
            bw.Write((byte)0x00); //TODO

            file.Write((uint)ms.Length + 4);
            file.Write(ms.ToByteArray());
        }
    }
}
