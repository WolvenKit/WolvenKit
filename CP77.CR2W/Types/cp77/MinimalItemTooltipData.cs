using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MinimalItemTooltipData : ATooltipData
	{
		[Ordinal(0)]  [RED("DEBUG_iconErrorInfo")] public CHandle<DEBUG_IconErrorInfo> DEBUG_iconErrorInfo { get; set; }
		[Ordinal(1)]  [RED("ammoCount")] public CInt32 AmmoCount { get; set; }
		[Ordinal(2)]  [RED("armorDiff")] public CFloat ArmorDiff { get; set; }
		[Ordinal(3)]  [RED("armorValue")] public CFloat ArmorValue { get; set; }
		[Ordinal(4)]  [RED("attackSpeed")] public CFloat AttackSpeed { get; set; }
		[Ordinal(5)]  [RED("compareArmor")] public CBool CompareArmor { get; set; }
		[Ordinal(6)]  [RED("compareDPS")] public CBool CompareDPS { get; set; }
		[Ordinal(7)]  [RED("dedicatedMods")] public CArray<CHandle<MinimalItemTooltipModAttachmentData>> DedicatedMods { get; set; }
		[Ordinal(8)]  [RED("description")] public CName Description { get; set; }
		[Ordinal(9)]  [RED("displayContext")] public CEnum<InventoryTooltipDisplayContext> DisplayContext { get; set; }
		[Ordinal(10)]  [RED("dpsDiff")] public CFloat DpsDiff { get; set; }
		[Ordinal(11)]  [RED("dpsValue")] public CFloat DpsValue { get; set; }
		[Ordinal(12)]  [RED("equipmentArea")] public CEnum<gamedataEquipmentArea> EquipmentArea { get; set; }
		[Ordinal(13)]  [RED("grenadeData")] public CHandle<InventoryTooltiData_GrenadeData> GrenadeData { get; set; }
		[Ordinal(14)]  [RED("hasScope")] public CBool HasScope { get; set; }
		[Ordinal(15)]  [RED("hasSilencer")] public CBool HasSilencer { get; set; }
		[Ordinal(16)]  [RED("iconPath")] public CString IconPath { get; set; }
		[Ordinal(17)]  [RED("isCrafted")] public CBool IsCrafted { get; set; }
		[Ordinal(18)]  [RED("isEquipped")] public CBool IsEquipped { get; set; }
		[Ordinal(19)]  [RED("isIconic")] public CBool IsIconic { get; set; }
		[Ordinal(20)]  [RED("isScopeInstalled")] public CBool IsScopeInstalled { get; set; }
		[Ordinal(21)]  [RED("isSilencerInstalled")] public CBool IsSilencerInstalled { get; set; }
		[Ordinal(22)]  [RED("itemCategory")] public CEnum<gamedataItemCategory> ItemCategory { get; set; }
		[Ordinal(23)]  [RED("itemData")] public wCHandle<gameItemData> ItemData { get; set; }
		[Ordinal(24)]  [RED("itemEvolution")] public CEnum<gamedataWeaponEvolution> ItemEvolution { get; set; }
		[Ordinal(25)]  [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(26)]  [RED("itemName")] public CString ItemName { get; set; }
		[Ordinal(27)]  [RED("itemTweakID")] public TweakDBID ItemTweakID { get; set; }
		[Ordinal(28)]  [RED("itemType")] public CEnum<gamedataItemType> ItemType { get; set; }
		[Ordinal(29)]  [RED("mods")] public CArray<CHandle<MinimalItemTooltipModData>> Mods { get; set; }
		[Ordinal(30)]  [RED("price")] public CFloat Price { get; set; }
		[Ordinal(31)]  [RED("projectilesPerShot")] public CFloat ProjectilesPerShot { get; set; }
		[Ordinal(32)]  [RED("quality")] public CEnum<gamedataQuality> Quality { get; set; }
		[Ordinal(33)]  [RED("quantity")] public CInt32 Quantity { get; set; }
		[Ordinal(34)]  [RED("recipeData")] public CHandle<MinimalItemTooltipRecipeData> RecipeData { get; set; }
		[Ordinal(35)]  [RED("requirements")] public CHandle<MinimalItemTooltipDataRequirements> Requirements { get; set; }
		[Ordinal(36)]  [RED("stats")] public CArray<CHandle<MinimalItemTooltipStatData>> Stats { get; set; }
		[Ordinal(37)]  [RED("useMaleIcon")] public CBool UseMaleIcon { get; set; }
		[Ordinal(38)]  [RED("weight")] public CFloat Weight { get; set; }

		public MinimalItemTooltipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
