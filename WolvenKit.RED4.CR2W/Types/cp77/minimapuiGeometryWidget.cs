using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class minimapuiGeometryWidget : inkCanvasWidget
	{
		[Ordinal(23)] [RED("widgetTemplates")] public CArray<inkWidgetReference> WidgetTemplates { get; set; }
		[Ordinal(24)] [RED("settings")] public minimapuiSettings Settings { get; set; }

		public minimapuiGeometryWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
