using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_BlendSpace_InternalsBlendSpaceCoordinateDescription : CVariable
	{
		[Ordinal(0)] [RED("name")] public CName Name { get; set; }
		[Ordinal(1)] [RED("minValue")] public CFloat MinValue { get; set; }
		[Ordinal(2)] [RED("maxValue")] public CFloat MaxValue { get; set; }
		[Ordinal(3)] [RED("gridDivisionsCount")] public CUInt32 GridDivisionsCount { get; set; }

		public animAnimNode_BlendSpace_InternalsBlendSpaceCoordinateDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
