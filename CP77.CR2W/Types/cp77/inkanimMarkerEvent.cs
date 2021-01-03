using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkanimMarkerEvent : inkanimEvent
	{
		[Ordinal(0)]  [RED("markerName")] public CName MarkerName { get; set; }

		public inkanimMarkerEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
