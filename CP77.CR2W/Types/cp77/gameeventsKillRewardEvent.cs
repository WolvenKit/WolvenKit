using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameeventsKillRewardEvent : redEvent
	{
		[Ordinal(0)] [RED("victim")] public wCHandle<gameObject> Victim { get; set; }
		[Ordinal(1)] [RED("killType")] public CEnum<gameKillType> KillType { get; set; }

		public gameeventsKillRewardEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
