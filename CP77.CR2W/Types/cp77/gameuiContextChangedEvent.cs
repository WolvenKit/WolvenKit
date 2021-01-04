using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiContextChangedEvent : redEvent
	{
		[Ordinal(0)]  [RED("newContext")] public gameuiContext NewContext { get; set; }
		[Ordinal(1)]  [RED("oldContext")] public gameuiContext OldContext { get; set; }

		public gameuiContextChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
