using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_BaseSwitch : animAnimNode_Base
	{
		[Ordinal(11)] [RED("blendTime")] public CFloat BlendTime { get; set; }
		[Ordinal(12)] [RED("timeWarpingEnabled")] public CBool TimeWarpingEnabled { get; set; }
		[Ordinal(13)] [RED("syncMethod")] public CHandle<animISyncMethod> SyncMethod { get; set; }
		[Ordinal(14)] [RED("inputNodes")] public CArray<animPoseLink> InputNodes { get; set; }
		[Ordinal(15)] [RED("canRequestInertialization")] public CBool CanRequestInertialization { get; set; }

		public animAnimNode_BaseSwitch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
