using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_FootPlant : animAnimEvent
	{
		[Ordinal(0)]  [RED("side")] public CEnum<animEventSide> Side { get; set; }
		[Ordinal(1)]  [RED("customEvent")] public CName CustomEvent { get; set; }

		public animAnimEvent_FootPlant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
