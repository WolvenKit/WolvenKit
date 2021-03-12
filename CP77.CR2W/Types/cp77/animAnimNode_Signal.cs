using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Signal : animAnimNode_FloatValue
	{
		[Ordinal(11)] [RED("blendIn")] public CFloat BlendIn { get; set; }
		[Ordinal(12)] [RED("blendOut")] public CFloat BlendOut { get; set; }
		[Ordinal(13)] [RED("startEvent")] public CName StartEvent { get; set; }
		[Ordinal(14)] [RED("endEvent")] public CName EndEvent { get; set; }
		[Ordinal(15)] [RED("defaultState")] public CBool DefaultState { get; set; }
		[Ordinal(16)] [RED("cooldown")] public CFloat Cooldown { get; set; }

		public animAnimNode_Signal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
