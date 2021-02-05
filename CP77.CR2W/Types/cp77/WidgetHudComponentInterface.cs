using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WidgetHudComponentInterface : WidgetBaseComponent
	{
		[Ordinal(0)]  [RED("hudEntriesResource")] public rRef<inkHudEntriesResource> HudEntriesResource { get; set; }
		[Ordinal(1)]  [RED("externalMaterial")] public rRef<CMaterialTemplate> ExternalMaterial { get; set; }
		[Ordinal(2)]  [RED("meshTargetBinding")] public CHandle<worlduiMeshTargetBinding> MeshTargetBinding { get; set; }

		public WidgetHudComponentInterface(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
