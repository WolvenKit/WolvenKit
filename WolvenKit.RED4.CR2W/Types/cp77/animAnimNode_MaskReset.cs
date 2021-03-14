using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_MaskReset : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("weightNode")] public animFloatLink WeightNode { get; set; }
		[Ordinal(13)] [RED("transforms")] public CArray<animTransformIndex> Transforms { get; set; }

		public animAnimNode_MaskReset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
