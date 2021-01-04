using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuickHackDescriptionGameController : BaseChunkGameController
	{
		[Ordinal(0)]  [RED("categoryContainer")] public inkWidgetReference CategoryContainer { get; set; }
		[Ordinal(1)]  [RED("categoryText")] public inkTextWidgetReference CategoryText { get; set; }
		[Ordinal(2)]  [RED("cooldown")] public inkTextWidgetReference Cooldown { get; set; }
		[Ordinal(3)]  [RED("damageLabel")] public inkTextWidgetReference DamageLabel { get; set; }
		[Ordinal(4)]  [RED("damageValue")] public inkTextWidgetReference DamageValue { get; set; }
		[Ordinal(5)]  [RED("damageWrapper")] public inkWidgetReference DamageWrapper { get; set; }
		[Ordinal(6)]  [RED("description")] public inkTextWidgetReference Description { get; set; }
		[Ordinal(7)]  [RED("duration")] public inkTextWidgetReference Duration { get; set; }
		[Ordinal(8)]  [RED("healthPercentageLabel")] public inkTextWidgetReference HealthPercentageLabel { get; set; }
		[Ordinal(9)]  [RED("memoryCost")] public inkTextWidgetReference MemoryCost { get; set; }
		[Ordinal(10)]  [RED("memoryRawCost")] public inkTextWidgetReference MemoryRawCost { get; set; }
		[Ordinal(11)]  [RED("quickHackDataCallbackID")] public CUInt32 QuickHackDataCallbackID { get; set; }
		[Ordinal(12)]  [RED("recompileTimer")] public inkTextWidgetReference RecompileTimer { get; set; }
		[Ordinal(13)]  [RED("selectedData")] public CHandle<QuickhackData> SelectedData { get; set; }
		[Ordinal(14)]  [RED("subHeader")] public inkTextWidgetReference SubHeader { get; set; }
		[Ordinal(15)]  [RED("tier")] public inkTextWidgetReference Tier { get; set; }
		[Ordinal(16)]  [RED("uploadTime")] public inkTextWidgetReference UploadTime { get; set; }

		public QuickHackDescriptionGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
