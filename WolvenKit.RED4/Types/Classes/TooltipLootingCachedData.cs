using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TooltipLootingCachedData : IScriptable
	{
		[Ordinal(0)] 
		[RED("externalItemData")] 
		public CWeakHandle<gameItemData> ExternalItemData
		{
			get => GetPropertyValue<CWeakHandle<gameItemData>>();
			set => SetPropertyValue<CWeakHandle<gameItemData>>(value);
		}

		[Ordinal(1)] 
		[RED("itemRecord")] 
		public CWeakHandle<gamedataItem_Record> ItemRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataItem_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataItem_Record>>(value);
		}

		[Ordinal(2)] 
		[RED("comparisonItemData")] 
		public CWeakHandle<gameItemData> ComparisonItemData
		{
			get => GetPropertyValue<CWeakHandle<gameItemData>>();
			set => SetPropertyValue<CWeakHandle<gameItemData>>(value);
		}

		[Ordinal(3)] 
		[RED("comparisonItemId")] 
		public gameItemID ComparisonItemId
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(4)] 
		[RED("lootingData")] 
		public CHandle<MinimalLootingListItemData> LootingData
		{
			get => GetPropertyValue<CHandle<MinimalLootingListItemData>>();
			set => SetPropertyValue<CHandle<MinimalLootingListItemData>>(value);
		}

		[Ordinal(5)] 
		[RED("comparisonWeaponBars")] 
		public CHandle<UIInventoryItemWeaponBars> ComparisonWeaponBars
		{
			get => GetPropertyValue<CHandle<UIInventoryItemWeaponBars>>();
			set => SetPropertyValue<CHandle<UIInventoryItemWeaponBars>>(value);
		}

		[Ordinal(6)] 
		[RED("comparisonQualityF")] 
		public CFloat ComparisonQualityF
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public TooltipLootingCachedData()
		{
			ComparisonItemId = new gameItemID();
			ComparisonQualityF = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
