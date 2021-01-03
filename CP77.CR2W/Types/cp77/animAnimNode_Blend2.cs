using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Blend2 : animAnimNode_Base
	{
		[Ordinal(0)]  [RED("firstInputNode")] public animPoseLink FirstInputNode { get; set; }
		[Ordinal(1)]  [RED("maxInputValue")] public CFloat MaxInputValue { get; set; }
		[Ordinal(2)]  [RED("minInputValue")] public CFloat MinInputValue { get; set; }
		[Ordinal(3)]  [RED("secondInputNode")] public animPoseLink SecondInputNode { get; set; }
		[Ordinal(4)]  [RED("syncMethod")] public CHandle<animISyncMethod> SyncMethod { get; set; }
		[Ordinal(5)]  [RED("timeWarpingEnabled")] public CBool TimeWarpingEnabled { get; set; }
		[Ordinal(6)]  [RED("weightNode")] public animFloatLink WeightNode { get; set; }

		public animAnimNode_Blend2(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
