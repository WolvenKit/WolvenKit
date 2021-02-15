using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class garmentGarmentLayerParams : CResource
	{
		[Ordinal(1)] [RED("bending")] public garmentBendingParams Bending { get; set; }
		[Ordinal(2)] [RED("smoothing")] public garmentSmoothingParams Smoothing { get; set; }
		[Ordinal(3)] [RED("collarArea")] public garmentCollarAreaParams CollarArea { get; set; }
		[Ordinal(4)] [RED("hiddenTrianglesRemoval")] public garmentHiddenTrianglesRemovalParams HiddenTrianglesRemoval { get; set; }

		public garmentGarmentLayerParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
