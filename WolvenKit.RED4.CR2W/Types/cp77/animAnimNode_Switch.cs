using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Switch : animAnimNode_MotionTableSwitch
	{
		[Ordinal(11)] [RED("numInputs")] public CUInt32 NumInputs { get; set; }
		[Ordinal(12)] [RED("blendTime")] public CFloat BlendTime { get; set; }
		[Ordinal(13)] [RED("timeWarpingEnabled")] public CBool TimeWarpingEnabled { get; set; }
		[Ordinal(14)] [RED("syncMethod")] public CHandle<animISyncMethod> SyncMethod { get; set; }
		[Ordinal(15)] [RED("motionProvider")] public CHandle<animIMotionTableProvider> MotionProvider { get; set; }
		[Ordinal(16)] [RED("weightNode")] public animFloatLink WeightNode { get; set; }
		[Ordinal(17)] [RED("inputNodes")] public CArray<animPoseLink> InputNodes { get; set; }
		[Ordinal(18)] [RED("pushDataByTag")] public CName PushDataByTag { get; set; }
		[Ordinal(19)] [RED("canRequestInertialization")] public CBool CanRequestInertialization { get; set; }

		public animAnimNode_Switch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
