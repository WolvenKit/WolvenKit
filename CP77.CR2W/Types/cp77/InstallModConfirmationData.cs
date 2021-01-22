using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InstallModConfirmationData : IScriptable
	{
		[Ordinal(0)]  [RED("itemId")] public gameItemID ItemId { get; set; }
		[Ordinal(1)]  [RED("partId")] public gameItemID PartId { get; set; }
		[Ordinal(2)]  [RED("slotID")] public TweakDBID SlotID { get; set; }
		[Ordinal(3)]  [RED("telemetryItemData")] public gameTelemetryInventoryItem TelemetryItemData { get; set; }
		[Ordinal(4)]  [RED("telemetryPartData")] public gameTelemetryInventoryItem TelemetryPartData { get; set; }

		public InstallModConfirmationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
