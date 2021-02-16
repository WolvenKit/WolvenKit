using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldCompiledEffectPlacementInfo : CVariable
	{
		[Ordinal(0)] [RED("placementTagIndex")] public CUInt8 PlacementTagIndex { get; set; }
		[Ordinal(1)] [RED("relativePositionIndex")] public CUInt8 RelativePositionIndex { get; set; }
		[Ordinal(2)] [RED("relativeRotationIndex")] public CUInt8 RelativeRotationIndex { get; set; }
		[Ordinal(3)] [RED("flags")] public CUInt8 Flags { get; set; }

		public worldCompiledEffectPlacementInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
