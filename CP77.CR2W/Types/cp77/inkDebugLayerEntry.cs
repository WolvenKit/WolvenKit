using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkDebugLayerEntry : CVariable
	{
		[Ordinal(0)] [RED("widgetResource")] public raRef<inkWidgetLibraryResource> WidgetResource { get; set; }
		[Ordinal(1)] [RED("anchorPlace")] public CEnum<inkEAnchor> AnchorPlace { get; set; }
		[Ordinal(2)] [RED("anchorPoint")] public Vector2 AnchorPoint { get; set; }

		public inkDebugLayerEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
