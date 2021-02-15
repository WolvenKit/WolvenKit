using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameweaponeventsChangeTriggerModeEvent : redEvent
	{
		[Ordinal(0)] [RED("triggerMode")] public CEnum<gamedataTriggerMode> TriggerMode { get; set; }

		public gameweaponeventsChangeTriggerModeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
