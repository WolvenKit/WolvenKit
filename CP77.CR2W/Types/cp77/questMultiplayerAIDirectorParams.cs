using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questMultiplayerAIDirectorParams : ISerializable
	{
		[Ordinal(0)]  [RED("function")] public CEnum<questMultiplayerAIDirectorFunction> Function { get; set; }
		[Ordinal(1)]  [RED("pathRef")] public NodeRef PathRef { get; set; }
		[Ordinal(2)]  [RED("scheduleEntryName")] public CString ScheduleEntryName { get; set; }
		[Ordinal(3)]  [RED("scheduleName")] public CString ScheduleName { get; set; }
		[Ordinal(4)]  [RED("status")] public CEnum<questMultiplayerAIDirectorStatus> Status { get; set; }

		public questMultiplayerAIDirectorParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
