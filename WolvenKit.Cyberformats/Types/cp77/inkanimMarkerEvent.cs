using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkanimMarkerEvent : inkanimEvent
	{
		[Ordinal(1)] [RED("markerName")] public CName MarkerName { get; set; }

		public inkanimMarkerEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
