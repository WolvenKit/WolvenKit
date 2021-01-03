using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameeventsSquadStartedCombatEvent : redEvent
	{
		[Ordinal(0)]  [RED("started")] public CBool Started { get; set; }

		public gameeventsSquadStartedCombatEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
