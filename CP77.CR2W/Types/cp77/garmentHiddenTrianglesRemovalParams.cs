using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class garmentHiddenTrianglesRemovalParams : CVariable
	{
		[Ordinal(0)]  [RED("garmentBorderThreshold")] public CFloat GarmentBorderThreshold { get; set; }
		[Ordinal(1)]  [RED("rayLengthInCM")] public CFloat RayLengthInCM { get; set; }
		[Ordinal(2)]  [RED("rayLengthMorphOffsetFactor")] public CFloat RayLengthMorphOffsetFactor { get; set; }
		[Ordinal(3)]  [RED("removeHiddenTriangles")] public CBool RemoveHiddenTriangles { get; set; }
		[Ordinal(4)]  [RED("removeHiddenTrianglesRasterization")] public CBool RemoveHiddenTrianglesRasterization { get; set; }

		public garmentHiddenTrianglesRemovalParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
