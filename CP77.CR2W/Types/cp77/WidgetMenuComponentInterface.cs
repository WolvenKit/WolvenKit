using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WidgetMenuComponentInterface : WidgetBaseComponent
	{
		[Ordinal(5)] [RED("widgetResource")] public rRef<inkWidgetLibraryResource> WidgetResource { get; set; }
		[Ordinal(6)] [RED("cursorResource")] public rRef<inkWidgetLibraryResource> CursorResource { get; set; }
		[Ordinal(7)] [RED("externalMaterial")] public rRef<CMaterialTemplate> ExternalMaterial { get; set; }
		[Ordinal(8)] [RED("meshTargetBinding")] public CHandle<worlduiMeshTargetBinding> MeshTargetBinding { get; set; }

		public WidgetMenuComponentInterface(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
