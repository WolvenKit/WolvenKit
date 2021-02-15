using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnChangeIdleAnimEvent : scnPlayAnimEvent
	{
		[Ordinal(15)] [RED("idleAnimName")] public CName IdleAnimName { get; set; }
		[Ordinal(16)] [RED("addIdleAnimName")] public CName AddIdleAnimName { get; set; }
		[Ordinal(17)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(18)] [RED("animName")] public CName AnimName { get; set; }
		[Ordinal(19)] [RED("bakedFacialTransition")] public animFacialEmotionTransitionBaked BakedFacialTransition { get; set; }
		[Ordinal(20)] [RED("facialInstantTransition")] public CBool FacialInstantTransition { get; set; }

		public scnChangeIdleAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
