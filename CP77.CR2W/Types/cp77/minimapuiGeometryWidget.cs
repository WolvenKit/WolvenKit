using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class minimapuiGeometryWidget : inkCanvasWidget
	{
		[Ordinal(0)]  [RED("settings")] public minimapuiSettings Settings { get; set; }
		[Ordinal(1)]  [RED("widgetTemplates")] public CArray<inkWidgetReference> WidgetTemplates { get; set; }

		public minimapuiGeometryWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
