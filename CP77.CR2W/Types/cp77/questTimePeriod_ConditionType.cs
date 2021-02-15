using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questTimePeriod_ConditionType : questITimeConditionType
	{
		[Ordinal(0)] [RED("begin")] public GameTime Begin { get; set; }
		[Ordinal(1)] [RED("end")] public GameTime End { get; set; }

		public questTimePeriod_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
