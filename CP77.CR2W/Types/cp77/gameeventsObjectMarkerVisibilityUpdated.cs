using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameeventsObjectMarkerVisibilityUpdated : redEvent
	{
		[Ordinal(0)]  [RED("canHaveObjectMarker")] public CBool CanHaveObjectMarker { get; set; }
		[Ordinal(1)]  [RED("isVisible")] public CBool IsVisible { get; set; }

		public gameeventsObjectMarkerVisibilityUpdated(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
