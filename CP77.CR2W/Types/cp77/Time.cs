using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Time : CVariable
	{
		[Ordinal(0)] [RED("days")] public CInt32 Days { get; set; }
		[Ordinal(1)] [RED("hours")] public CInt32 Hours { get; set; }
		[Ordinal(2)] [RED("minutes")] public CInt32 Minutes { get; set; }

		public Time(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
