using System.IO;
using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AreaShapeOutline : ISerializable
	{
		[Ordinal(0)] [RED("points")] public CArray<Vector3> Points { get; set; }
		[Ordinal(1)] [RED("height")] public CFloat Height { get; set; }
        private byte[] _unknown;

		public AreaShapeOutline(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public override void Read(BinaryReader file, uint size)
        {
            // TODO: WIP
            _unknown = file.ReadBytes((int) size);
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(_unknown);
        }
    }
}
