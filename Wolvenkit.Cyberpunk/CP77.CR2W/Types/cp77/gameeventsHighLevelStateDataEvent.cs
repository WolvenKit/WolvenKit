using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameeventsHighLevelStateDataEvent : redEvent
	{
		[Ordinal(0)]  [RED("currentHighLevelState")] public CEnum<gamedataNPCHighLevelState> CurrentHighLevelState { get; set; }
		[Ordinal(1)]  [RED("currentNPCEntityID")] public entEntityID CurrentNPCEntityID { get; set; }

		public gameeventsHighLevelStateDataEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
