using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class cpConveyorObject : gameObject
	{
		[Ordinal(40)] [RED("rotationLerpFactor")] public CFloat RotationLerpFactor { get; set; }
		[Ordinal(41)] [RED("ignoreZAxis")] public CBool IgnoreZAxis { get; set; }

		public cpConveyorObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
