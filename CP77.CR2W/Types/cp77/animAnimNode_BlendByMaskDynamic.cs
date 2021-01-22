using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_BlendByMaskDynamic : animAnimNode_Base
	{
		[Ordinal(0)]  [RED("base")] public animPoseLink Base { get; set; }
		[Ordinal(1)]  [RED("blend")] public animPoseLink Blend { get; set; }
		[Ordinal(2)]  [RED("mask")] public animIntLink Mask { get; set; }
		[Ordinal(3)]  [RED("masks")] public CArray<CName> Masks { get; set; }
		[Ordinal(4)]  [RED("syncMethod")] public CHandle<animISyncMethod> SyncMethod { get; set; }
		[Ordinal(5)]  [RED("weight")] public animFloatLink Weight { get; set; }

		public animAnimNode_BlendByMaskDynamic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
