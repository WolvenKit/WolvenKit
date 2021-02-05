using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Switch : animAnimNode_MotionTableSwitch
	{
		[Ordinal(0)]  [RED("numInputs")] public CUInt32 NumInputs { get; set; }
		[Ordinal(1)]  [RED("blendTime")] public CFloat BlendTime { get; set; }
		[Ordinal(2)]  [RED("timeWarpingEnabled")] public CBool TimeWarpingEnabled { get; set; }
		[Ordinal(3)]  [RED("syncMethod")] public CHandle<animISyncMethod> SyncMethod { get; set; }
		[Ordinal(4)]  [RED("motionProvider")] public CHandle<animIMotionTableProvider> MotionProvider { get; set; }
		[Ordinal(5)]  [RED("weightNode")] public animFloatLink WeightNode { get; set; }
		[Ordinal(6)]  [RED("inputNodes")] public CArray<animPoseLink> InputNodes { get; set; }
		[Ordinal(7)]  [RED("pushDataByTag")] public CName PushDataByTag { get; set; }
		[Ordinal(8)]  [RED("canRequestInertialization")] public CBool CanRequestInertialization { get; set; }

		public animAnimNode_Switch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
