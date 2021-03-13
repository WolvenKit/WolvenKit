using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_TriggerBranch : animAnimNode_Base
	{
		[Ordinal(11)] [RED("base")] public animPoseLink Base { get; set; }
		[Ordinal(12)] [RED("overlay")] public animPoseLink Overlay { get; set; }
		[Ordinal(13)] [RED("blendIn")] public CFloat BlendIn { get; set; }
		[Ordinal(14)] [RED("blendOut")] public CFloat BlendOut { get; set; }
		[Ordinal(15)] [RED("startEvent")] public CName StartEvent { get; set; }
		[Ordinal(16)] [RED("endEvent")] public CName EndEvent { get; set; }
		[Ordinal(17)] [RED("cooldown")] public CFloat Cooldown { get; set; }

		public animAnimNode_TriggerBranch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
