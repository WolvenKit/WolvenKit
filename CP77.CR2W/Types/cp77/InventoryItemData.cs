using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InventoryItemData : CVariable
	{
		[Ordinal(0)] [RED("Empty")] public CBool Empty { get; set; }
		[Ordinal(1)] [RED("ID")] public gameItemID ID { get; set; }
		[Ordinal(2)] [RED("SlotID")] public TweakDBID SlotID { get; set; }
		[Ordinal(3)] [RED("Name")] public CString Name { get; set; }
		[Ordinal(4)] [RED("Quality")] public CName Quality { get; set; }
		[Ordinal(5)] [RED("Quantity")] public CInt32 Quantity { get; set; }
		[Ordinal(6)] [RED("Ammo")] public CInt32 Ammo { get; set; }
		[Ordinal(7)] [RED("Shape")] public CEnum<gameInventoryItemShape> Shape { get; set; }
		[Ordinal(8)] [RED("ItemShape")] public CEnum<gameInventoryItemShape> ItemShape { get; set; }
		[Ordinal(9)] [RED("IconPath")] public CString IconPath { get; set; }
		[Ordinal(10)] [RED("CategoryName")] public CString CategoryName { get; set; }
		[Ordinal(11)] [RED("ItemType")] public CEnum<gamedataItemType> ItemType { get; set; }
		[Ordinal(12)] [RED("LocalizedItemType")] public CString LocalizedItemType { get; set; }
		[Ordinal(13)] [RED("Description")] public CString Description { get; set; }
		[Ordinal(14)] [RED("AdditionalDescription")] public CString AdditionalDescription { get; set; }
		[Ordinal(15)] [RED("Price")] public CFloat Price { get; set; }
		[Ordinal(16)] [RED("BuyPrice")] public CFloat BuyPrice { get; set; }
		[Ordinal(17)] [RED("UnlockProgress")] public CFloat UnlockProgress { get; set; }
		[Ordinal(18)] [RED("RequiredLevel")] public CInt32 RequiredLevel { get; set; }
		[Ordinal(19)] [RED("ItemLevel")] public CInt32 ItemLevel { get; set; }
		[Ordinal(20)] [RED("DamageType")] public CEnum<gamedataDamageType> DamageType { get; set; }
		[Ordinal(21)] [RED("EquipmentArea")] public CEnum<gamedataEquipmentArea> EquipmentArea { get; set; }
		[Ordinal(22)] [RED("ComparedQuality")] public CEnum<gamedataQuality> ComparedQuality { get; set; }
		[Ordinal(23)] [RED("IsPart")] public CBool IsPart { get; set; }
		[Ordinal(24)] [RED("IsCraftingMaterial")] public CBool IsCraftingMaterial { get; set; }
		[Ordinal(25)] [RED("IsEquipped")] public CBool IsEquipped { get; set; }
		[Ordinal(26)] [RED("IsNew")] public CBool IsNew { get; set; }
		[Ordinal(27)] [RED("IsAvailable")] public CBool IsAvailable { get; set; }
		[Ordinal(28)] [RED("IsVendorItem")] public CBool IsVendorItem { get; set; }
		[Ordinal(29)] [RED("IsBroken")] public CBool IsBroken { get; set; }
		[Ordinal(30)] [RED("SlotIndex")] public CInt32 SlotIndex { get; set; }
		[Ordinal(31)] [RED("PositionInBackpack")] public CUInt32 PositionInBackpack { get; set; }
		[Ordinal(32)] [RED("IconGender")] public CEnum<gameItemIconGender> IconGender { get; set; }
		[Ordinal(33)] [RED("GameItemData")] public wCHandle<gameItemData> GameItemData { get; set; }
		[Ordinal(34)] [RED("HasPlayerSmartGunLink")] public CBool HasPlayerSmartGunLink { get; set; }
		[Ordinal(35)] [RED("PlayerLevel")] public CInt32 PlayerLevel { get; set; }
		[Ordinal(36)] [RED("PlayerStrenght")] public CInt32 PlayerStrenght { get; set; }
		[Ordinal(37)] [RED("PlayerReflexes")] public CInt32 PlayerReflexes { get; set; }
		[Ordinal(38)] [RED("PlayerStreetCred")] public CInt32 PlayerStreetCred { get; set; }
		[Ordinal(39)] [RED("IsRequirementMet")] public CBool IsRequirementMet { get; set; }
		[Ordinal(40)] [RED("IsEquippable")] public CBool IsEquippable { get; set; }
		[Ordinal(41)] [RED("Requirement")] public gameSItemStackRequirementData Requirement { get; set; }
		[Ordinal(42)] [RED("EquipRequirement")] public gameSItemStackRequirementData EquipRequirement { get; set; }
		[Ordinal(43)] [RED("LootItemType")] public CEnum<gameLootItemType> LootItemType { get; set; }
		[Ordinal(44)] [RED("Attachments")] public CArray<InventoryItemAttachments> Attachments { get; set; }
		[Ordinal(45)] [RED("Abilities")] public CArray<gameInventoryItemAbility> Abilities { get; set; }
		[Ordinal(46)] [RED("PlacementSlots")] public CArray<TweakDBID> PlacementSlots { get; set; }
		[Ordinal(47)] [RED("PrimaryStats")] public CArray<gameStatViewData> PrimaryStats { get; set; }
		[Ordinal(48)] [RED("SecondaryStats")] public CArray<gameStatViewData> SecondaryStats { get; set; }

		public InventoryItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
