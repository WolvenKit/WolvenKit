using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questGameTimeDelay_ConditionType : questITimeConditionType
	{
		[Ordinal(0)] [RED("days")] public CUInt32 Days { get; set; }
		[Ordinal(1)] [RED("hours")] public CUInt32 Hours { get; set; }
		[Ordinal(2)] [RED("minutes")] public CUInt32 Minutes { get; set; }
		[Ordinal(3)] [RED("seconds")] public CUInt32 Seconds { get; set; }

		public questGameTimeDelay_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
