using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InventoryWideItemDisplay : InventoryItemDisplay
	{
		[Ordinal(0)]  [RED("additionalInfoText")] public inkTextWidgetReference AdditionalInfoText { get; set; }
		[Ordinal(1)]  [RED("additionalInfoToShow")] public CEnum<ItemAdditionalInfoType> AdditionalInfoToShow { get; set; }
		[Ordinal(2)]  [RED("damageIndicatorRef")] public inkWidgetReference DamageIndicatorRef { get; set; }
		[Ordinal(3)]  [RED("damageTypeIndicator")] public wCHandle<DamageTypeIndicator> DamageTypeIndicator { get; set; }
		[Ordinal(4)]  [RED("dpsText")] public inkTextWidgetReference DpsText { get; set; }
		[Ordinal(5)]  [RED("iconWrapper")] public inkWidgetReference IconWrapper { get; set; }
		[Ordinal(6)]  [RED("itemNameText")] public inkTextWidgetReference ItemNameText { get; set; }
		[Ordinal(7)]  [RED("rarityBackground")] public inkWidgetReference RarityBackground { get; set; }
		[Ordinal(8)]  [RED("singleIconSize")] public Vector2 SingleIconSize { get; set; }
		[Ordinal(9)]  [RED("statsWrapper")] public inkWidgetReference StatsWrapper { get; set; }

		public InventoryWideItemDisplay(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
