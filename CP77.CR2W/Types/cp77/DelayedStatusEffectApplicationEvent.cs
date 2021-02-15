using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DelayedStatusEffectApplicationEvent : redEvent
	{
		[Ordinal(0)] [RED("statusEffectEvent")] public CHandle<gameeventsApplyStatusEffectEvent> StatusEffectEvent { get; set; }

		public DelayedStatusEffectApplicationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
