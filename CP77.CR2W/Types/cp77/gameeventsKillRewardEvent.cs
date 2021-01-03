using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameeventsKillRewardEvent : redEvent
	{
		[Ordinal(0)]  [RED("killType")] public CEnum<gameKillType> KillType { get; set; }
		[Ordinal(1)]  [RED("victim")] public wCHandle<gameObject> Victim { get; set; }

		public gameeventsKillRewardEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
