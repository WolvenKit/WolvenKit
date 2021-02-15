using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameTelemetryTrackedQuest : CVariable
	{
		[Ordinal(0)] [RED("name")] public CString Name { get; set; }
		[Ordinal(1)] [RED("objectiveName")] public CString ObjectiveName { get; set; }
		[Ordinal(2)] [RED("type")] public CString Type { get; set; }
		[Ordinal(3)] [RED("distance")] public CFloat Distance { get; set; }
		[Ordinal(4)] [RED("questName")] public CString QuestName { get; set; }
		[Ordinal(5)] [RED("questType")] public CString QuestType { get; set; }

		public gameTelemetryTrackedQuest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
