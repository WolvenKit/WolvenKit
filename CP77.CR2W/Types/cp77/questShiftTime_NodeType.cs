using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questShiftTime_NodeType : questITimeManagerNodeType
	{
		[Ordinal(0)]  [RED("timeShiftType")] public CEnum<questETimeShiftType> TimeShiftType { get; set; }
		[Ordinal(1)]  [RED("preventVisualGlitch")] public CBool PreventVisualGlitch { get; set; }
		[Ordinal(2)]  [RED("hours")] public CUInt32 Hours { get; set; }
		[Ordinal(3)]  [RED("minutes")] public CUInt32 Minutes { get; set; }
		[Ordinal(4)]  [RED("seconds")] public CUInt32 Seconds { get; set; }

		public questShiftTime_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
