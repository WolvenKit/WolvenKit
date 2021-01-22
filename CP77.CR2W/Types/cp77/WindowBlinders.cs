using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WindowBlinders : InteractiveDevice
	{
		[Ordinal(0)]  [RED("animFeature")] public CHandle<AnimFeature_SimpleDevice> AnimFeature { get; set; }
		[Ordinal(1)]  [RED("portalLight")] public CHandle<gameLightComponent> PortalLight { get; set; }
		[Ordinal(2)]  [RED("sideTriggerNames")] public CArray<CName> SideTriggerNames { get; set; }
		[Ordinal(3)]  [RED("triggerComponents")] public CArray<CHandle<gameStaticTriggerAreaComponent>> TriggerComponents { get; set; }
		[Ordinal(4)]  [RED("workspotSideName")] public CName WorkspotSideName { get; set; }

		public WindowBlinders(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
