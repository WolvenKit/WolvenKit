using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnChangeIdleAnimEvent : scnPlayAnimEvent
	{
		[Ordinal(0)]  [RED("addIdleAnimName")] public CName AddIdleAnimName { get; set; }
		[Ordinal(1)]  [RED("animName")] public CName AnimName { get; set; }
		[Ordinal(2)]  [RED("bakedFacialTransition")] public animFacialEmotionTransitionBaked BakedFacialTransition { get; set; }
		[Ordinal(3)]  [RED("facialInstantTransition")] public CBool FacialInstantTransition { get; set; }
		[Ordinal(4)]  [RED("idleAnimName")] public CName IdleAnimName { get; set; }
		[Ordinal(5)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }

		public scnChangeIdleAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
