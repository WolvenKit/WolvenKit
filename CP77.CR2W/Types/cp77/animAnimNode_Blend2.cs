using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Blend2 : animAnimNode_Base
	{
		[Ordinal(11)] [RED("minInputValue")] public CFloat MinInputValue { get; set; }
		[Ordinal(12)] [RED("maxInputValue")] public CFloat MaxInputValue { get; set; }
		[Ordinal(13)] [RED("timeWarpingEnabled")] public CBool TimeWarpingEnabled { get; set; }
		[Ordinal(14)] [RED("syncMethod")] public CHandle<animISyncMethod> SyncMethod { get; set; }
		[Ordinal(15)] [RED("firstInputNode")] public animPoseLink FirstInputNode { get; set; }
		[Ordinal(16)] [RED("secondInputNode")] public animPoseLink SecondInputNode { get; set; }
		[Ordinal(17)] [RED("weightNode")] public animFloatLink WeightNode { get; set; }

		public animAnimNode_Blend2(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
