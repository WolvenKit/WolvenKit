using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_BaseSwitch : animAnimNode_Base
	{
		[Ordinal(0)]  [RED("blendTime")] public CFloat BlendTime { get; set; }
		[Ordinal(1)]  [RED("canRequestInertialization")] public CBool CanRequestInertialization { get; set; }
		[Ordinal(2)]  [RED("inputNodes")] public CArray<animPoseLink> InputNodes { get; set; }
		[Ordinal(3)]  [RED("syncMethod")] public CHandle<animISyncMethod> SyncMethod { get; set; }
		[Ordinal(4)]  [RED("timeWarpingEnabled")] public CBool TimeWarpingEnabled { get; set; }

		public animAnimNode_BaseSwitch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
