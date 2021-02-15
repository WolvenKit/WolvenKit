using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameeventsApplyStatusEffectEvent : gameeventsStatusEffectEvent
	{
		[Ordinal(2)] [RED("isNewApplication")] public CBool IsNewApplication { get; set; }
		[Ordinal(3)] [RED("instigatorEntityID")] public entEntityID InstigatorEntityID { get; set; }

		public gameeventsApplyStatusEffectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
