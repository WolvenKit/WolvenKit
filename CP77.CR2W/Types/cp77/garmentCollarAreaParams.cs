using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class garmentCollarAreaParams : CVariable
	{
		[Ordinal(0)] [RED("enable")] public CBool Enable { get; set; }
		[Ordinal(1)] [RED("radiusInCM")] public CFloat RadiusInCM { get; set; }
		[Ordinal(2)] [RED("radiusForTriangleRemovalInCM")] public CFloat RadiusForTriangleRemovalInCM { get; set; }
		[Ordinal(3)] [RED("offsetFromSkinInCM")] public CFloat OffsetFromSkinInCM { get; set; }
		[Ordinal(4)] [RED("offset")] public Vector3 Offset { get; set; }

		public garmentCollarAreaParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
