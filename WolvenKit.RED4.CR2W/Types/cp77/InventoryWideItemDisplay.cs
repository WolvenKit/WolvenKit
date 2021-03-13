using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryWideItemDisplay : InventoryItemDisplay
	{
		[Ordinal(21)] [RED("itemNameText")] public inkTextWidgetReference ItemNameText { get; set; }
		[Ordinal(22)] [RED("rarityBackground")] public inkWidgetReference RarityBackground { get; set; }
		[Ordinal(23)] [RED("iconWrapper")] public inkWidgetReference IconWrapper { get; set; }
		[Ordinal(24)] [RED("statsWrapper")] public inkWidgetReference StatsWrapper { get; set; }
		[Ordinal(25)] [RED("dpsText")] public inkTextWidgetReference DpsText { get; set; }
		[Ordinal(26)] [RED("damageIndicatorRef")] public inkWidgetReference DamageIndicatorRef { get; set; }
		[Ordinal(27)] [RED("additionalInfoText")] public inkTextWidgetReference AdditionalInfoText { get; set; }
		[Ordinal(28)] [RED("singleIconSize")] public Vector2 SingleIconSize { get; set; }
		[Ordinal(29)] [RED("damageTypeIndicator")] public wCHandle<DamageTypeIndicator> DamageTypeIndicator { get; set; }
		[Ordinal(30)] [RED("additionalInfoToShow")] public CEnum<ItemAdditionalInfoType> AdditionalInfoToShow { get; set; }

		public InventoryWideItemDisplay(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
