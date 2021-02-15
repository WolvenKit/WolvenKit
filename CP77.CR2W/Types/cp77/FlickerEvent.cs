using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FlickerEvent : redEvent
	{
		[Ordinal(0)] [RED("strength")] public CFloat Strength { get; set; }
		[Ordinal(1)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(2)] [RED("offset")] public CFloat Offset { get; set; }

		public FlickerEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
