using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_MaskReset : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("transforms")] public CArray<animTransformIndex> Transforms { get; set; }
		[Ordinal(1)]  [RED("weightNode")] public animFloatLink WeightNode { get; set; }

		public animAnimNode_MaskReset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
