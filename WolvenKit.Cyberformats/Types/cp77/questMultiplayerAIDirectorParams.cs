using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questMultiplayerAIDirectorParams : ISerializable
	{
		[Ordinal(0)] [RED("function")] public CEnum<questMultiplayerAIDirectorFunction> Function { get; set; }
		[Ordinal(1)] [RED("status")] public CEnum<questMultiplayerAIDirectorStatus> Status { get; set; }
		[Ordinal(2)] [RED("pathRef")] public NodeRef PathRef { get; set; }
		[Ordinal(3)] [RED("scheduleEntryName")] public CString ScheduleEntryName { get; set; }
		[Ordinal(4)] [RED("scheduleName")] public CString ScheduleName { get; set; }

		public questMultiplayerAIDirectorParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
