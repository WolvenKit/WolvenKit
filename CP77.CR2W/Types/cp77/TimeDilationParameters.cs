using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TimeDilationParameters : IScriptable
	{
		[Ordinal(0)]  [RED("reason")] public CName Reason { get; set; }
		[Ordinal(1)]  [RED("timeDilation")] public CFloat TimeDilation { get; set; }
		[Ordinal(2)]  [RED("playerTimeDilation")] public CFloat PlayerTimeDilation { get; set; }
		[Ordinal(3)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(4)]  [RED("easeInCurve")] public CName EaseInCurve { get; set; }
		[Ordinal(5)]  [RED("easeOutCurve")] public CName EaseOutCurve { get; set; }

		public TimeDilationParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
