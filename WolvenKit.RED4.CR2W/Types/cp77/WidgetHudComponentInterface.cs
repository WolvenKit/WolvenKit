using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WidgetHudComponentInterface : WidgetBaseComponent
	{
		[Ordinal(5)] [RED("hudEntriesResource")] public rRef<inkHudEntriesResource> HudEntriesResource { get; set; }
		[Ordinal(6)] [RED("externalMaterial")] public rRef<CMaterialTemplate> ExternalMaterial { get; set; }
		[Ordinal(7)] [RED("meshTargetBinding")] public CHandle<worlduiMeshTargetBinding> MeshTargetBinding { get; set; }

		public WidgetHudComponentInterface(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
