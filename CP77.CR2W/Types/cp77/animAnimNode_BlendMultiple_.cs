using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_BlendMultiple_ : animAnimNode_Base
	{
		[Ordinal(1)] [RED("inputValues")] public CArray<CFloat> InputValues { get; set; }
		[Ordinal(2)] [RED("sortedInputValues")] public CArray<CFloat> SortedInputValues { get; set; }
		[Ordinal(3)] [RED("minWeight")] public CFloat MinWeight { get; set; }
		[Ordinal(4)] [RED("maxWeight")] public CFloat MaxWeight { get; set; }
		[Ordinal(5)] [RED("radialBlending")] public CBool RadialBlending { get; set; }
		[Ordinal(6)] [RED("timeWarpingEnabled")] public CBool TimeWarpingEnabled { get; set; }
		[Ordinal(7)] [RED("syncMethod")] public CHandle<animISyncMethod> SyncMethod { get; set; }
		[Ordinal(8)] [RED("motionProvider")] public CHandle<animIMotionTableProvider> MotionProvider { get; set; }
		[Ordinal(9)] [RED("weightNode")] public animFloatLink WeightNode { get; set; }
		[Ordinal(10)] [RED("inputNodes")] public CArray<animPoseLink> InputNodes { get; set; }

		public animAnimNode_BlendMultiple_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
