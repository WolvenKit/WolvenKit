using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_BlendMultiple : animAnimNode_Base
	{
		[Ordinal(0)]  [RED("inputNodes")] public CArray<animPoseLink> InputNodes { get; set; }
		[Ordinal(1)]  [RED("inputValues")] public CArray<CFloat> InputValues { get; set; }
		[Ordinal(2)]  [RED("maxWeight")] public CFloat MaxWeight { get; set; }
		[Ordinal(3)]  [RED("minWeight")] public CFloat MinWeight { get; set; }
		[Ordinal(4)]  [RED("motionProvider")] public CHandle<animIMotionTableProvider> MotionProvider { get; set; }
		[Ordinal(5)]  [RED("radialBlending")] public CBool RadialBlending { get; set; }
		[Ordinal(6)]  [RED("sortedInputValues")] public CArray<CFloat> SortedInputValues { get; set; }
		[Ordinal(7)]  [RED("syncMethod")] public CHandle<animISyncMethod> SyncMethod { get; set; }
		[Ordinal(8)]  [RED("timeWarpingEnabled")] public CBool TimeWarpingEnabled { get; set; }
		[Ordinal(9)]  [RED("weightNode")] public animFloatLink WeightNode { get; set; }

		public animAnimNode_BlendMultiple(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
