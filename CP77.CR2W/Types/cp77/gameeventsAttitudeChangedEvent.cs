using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameeventsAttitudeChangedEvent : redEvent
	{
		[Ordinal(0)]  [RED("otherAgent")] public wCHandle<gameAttitudeAgent> OtherAgent { get; set; }
		[Ordinal(1)]  [RED("attitude")] public CEnum<EAIAttitude> Attitude { get; set; }

		public gameeventsAttitudeChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
