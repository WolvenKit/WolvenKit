using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiTooltipsManager : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("flipX")] public CBool FlipX { get; set; }
		[Ordinal(1)]  [RED("flipY")] public CBool FlipY { get; set; }
		[Ordinal(2)]  [RED("rootMargin")] public inkMargin RootMargin { get; set; }
		[Ordinal(3)]  [RED("screenMargin")] public inkMargin ScreenMargin { get; set; }
		[Ordinal(4)]  [RED("tooltipsContainer")] public inkWidgetReference TooltipsContainer { get; set; }

		public gameuiTooltipsManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
