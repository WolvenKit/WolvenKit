using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioDynamicEventsWithInterval : CVariable
	{
		[Ordinal(0)] [RED("events")] public CArray<CName> Events { get; set; }
		[Ordinal(1)] [RED("interval")] public CFloat Interval { get; set; }

		public audioDynamicEventsWithInterval(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
