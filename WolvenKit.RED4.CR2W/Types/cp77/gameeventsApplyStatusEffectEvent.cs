using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsApplyStatusEffectEvent : gameeventsStatusEffectEvent
	{
		[Ordinal(2)] [RED("isNewApplication")] public CBool IsNewApplication { get; set; }
		[Ordinal(3)] [RED("instigatorEntityID")] public entEntityID InstigatorEntityID { get; set; }

		public gameeventsApplyStatusEffectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
