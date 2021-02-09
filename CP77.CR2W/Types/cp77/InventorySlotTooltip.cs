using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InventorySlotTooltip : AGenericTooltipController
	{
		[Ordinal(1)]  [RED("itemName")] public inkTextWidgetReference ItemName { get; set; }
		[Ordinal(2)]  [RED("itemCategory")] public inkTextWidgetReference ItemCategory { get; set; }
		[Ordinal(3)]  [RED("itemPrice")] public inkTextWidgetReference ItemPrice { get; set; }
		[Ordinal(4)]  [RED("descriptionText")] public inkTextWidgetReference DescriptionText { get; set; }
		[Ordinal(5)]  [RED("lockedText")] public inkTextWidgetReference LockedText { get; set; }
		[Ordinal(6)]  [RED("requiredLevelText")] public inkTextWidgetReference RequiredLevelText { get; set; }
		[Ordinal(7)]  [RED("additionalStatsTextRef")] public inkTextWidgetReference AdditionalStatsTextRef { get; set; }
		[Ordinal(8)]  [RED("equippedHeader")] public inkWidgetReference EquippedHeader { get; set; }
		[Ordinal(9)]  [RED("primaryStatsList")] public inkWidgetReference PrimaryStatsList { get; set; }
		[Ordinal(10)]  [RED("comparedStatsList")] public inkWidgetReference ComparedStatsList { get; set; }
		[Ordinal(11)]  [RED("additionalStatsList")] public inkWidgetReference AdditionalStatsList { get; set; }
		[Ordinal(12)]  [RED("itemPriceGroup")] public inkWidgetReference ItemPriceGroup { get; set; }
		[Ordinal(13)]  [RED("damageIndicator")] public inkWidgetReference DamageIndicator { get; set; }
		[Ordinal(14)]  [RED("requiredLevelGroup")] public inkWidgetReference RequiredLevelGroup { get; set; }
		[Ordinal(15)]  [RED("damageIndicatorRef")] public inkWidgetReference DamageIndicatorRef { get; set; }
		[Ordinal(16)]  [RED("attachmentsListVertRef")] public inkWidgetReference AttachmentsListVertRef { get; set; }
		[Ordinal(17)]  [RED("attachmentsCtrlHorRef")] public inkWidgetReference AttachmentsCtrlHorRef { get; set; }
		[Ordinal(18)]  [RED("specialAbilitiesListRef")] public inkWidgetReference SpecialAbilitiesListRef { get; set; }
		[Ordinal(19)]  [RED("rarityBarRef")] public inkWidgetReference RarityBarRef { get; set; }
		[Ordinal(20)]  [RED("elementsToSetRarityState")] public CArray<inkWidgetReference> ElementsToSetRarityState { get; set; }
		[Ordinal(21)]  [RED("rarityElementsRefs")] public CArray<inkImageWidgetReference> RarityElementsRefs { get; set; }
		[Ordinal(22)]  [RED("tooltipCycleIndicatorsContainer")] public inkCompoundWidgetReference TooltipCycleIndicatorsContainer { get; set; }
		[Ordinal(23)]  [RED("tooltipCycleHintContainer")] public inkCompoundWidgetReference TooltipCycleHintContainer { get; set; }
		[Ordinal(24)]  [RED("primaryStatsCtrl")] public wCHandle<InventoryItemStatList> PrimaryStatsCtrl { get; set; }
		[Ordinal(25)]  [RED("comparedStatsCtrl")] public wCHandle<InventoryItemStatList> ComparedStatsCtrl { get; set; }
		[Ordinal(26)]  [RED("additionalStatsCtrl")] public wCHandle<InventoryItemStatList> AdditionalStatsCtrl { get; set; }
		[Ordinal(27)]  [RED("attachmentsCtrlVert")] public wCHandle<InventoryItemAttachmentsList> AttachmentsCtrlVert { get; set; }
		[Ordinal(28)]  [RED("attachmentsCtrlHor")] public wCHandle<InventoryItemAttachmentsList> AttachmentsCtrlHor { get; set; }
		[Ordinal(29)]  [RED("damageTypeIndicator")] public wCHandle<DamageTypeIndicator> DamageTypeIndicator { get; set; }
		[Ordinal(30)]  [RED("specialAbilitiesList")] public wCHandle<TooltipSpecialAbilityList> SpecialAbilitiesList { get; set; }
		[Ordinal(31)]  [RED("data")] public CHandle<InventoryTooltipData> Data { get; set; }
		[Ordinal(32)]  [RED("tooltipCycleHint")] public CHandle<ButtonHintListItem> TooltipCycleHint { get; set; }
		[Ordinal(33)]  [RED("anim")] public CHandle<inkanimProxy> Anim { get; set; }

		public InventorySlotTooltip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
