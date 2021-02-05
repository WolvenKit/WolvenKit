using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InventoryWideItemDisplay : InventoryItemDisplay
	{
		[Ordinal(20)]  [RED("itemNameText")] public inkTextWidgetReference ItemNameText { get; set; }
		[Ordinal(21)]  [RED("rarityBackground")] public inkWidgetReference RarityBackground { get; set; }
		[Ordinal(22)]  [RED("iconWrapper")] public inkWidgetReference IconWrapper { get; set; }
		[Ordinal(23)]  [RED("statsWrapper")] public inkWidgetReference StatsWrapper { get; set; }
		[Ordinal(24)]  [RED("dpsText")] public inkTextWidgetReference DpsText { get; set; }
		[Ordinal(25)]  [RED("damageIndicatorRef")] public inkWidgetReference DamageIndicatorRef { get; set; }
		[Ordinal(26)]  [RED("additionalInfoText")] public inkTextWidgetReference AdditionalInfoText { get; set; }
		[Ordinal(27)]  [RED("singleIconSize")] public Vector2 SingleIconSize { get; set; }
		[Ordinal(28)]  [RED("damageTypeIndicator")] public wCHandle<DamageTypeIndicator> DamageTypeIndicator { get; set; }
		[Ordinal(29)]  [RED("additionalInfoToShow")] public CEnum<ItemAdditionalInfoType> AdditionalInfoToShow { get; set; }

		public InventoryWideItemDisplay(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
