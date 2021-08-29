using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TooltipLootingCachedData : IScriptable
	{
		private CWeakHandle<gameItemData> _externalItemData;
		private CWeakHandle<gamedataItem_Record> _itemRecord;
		private CWeakHandle<gameItemData> _comparisonItemData;
		private gameItemID _comparisonItemId;
		private CHandle<MinimalLootingListItemData> _lootingData;

		[Ordinal(0)] 
		[RED("externalItemData")] 
		public CWeakHandle<gameItemData> ExternalItemData
		{
			get => GetProperty(ref _externalItemData);
			set => SetProperty(ref _externalItemData, value);
		}

		[Ordinal(1)] 
		[RED("itemRecord")] 
		public CWeakHandle<gamedataItem_Record> ItemRecord
		{
			get => GetProperty(ref _itemRecord);
			set => SetProperty(ref _itemRecord, value);
		}

		[Ordinal(2)] 
		[RED("comparisonItemData")] 
		public CWeakHandle<gameItemData> ComparisonItemData
		{
			get => GetProperty(ref _comparisonItemData);
			set => SetProperty(ref _comparisonItemData, value);
		}

		[Ordinal(3)] 
		[RED("comparisonItemId")] 
		public gameItemID ComparisonItemId
		{
			get => GetProperty(ref _comparisonItemId);
			set => SetProperty(ref _comparisonItemId, value);
		}

		[Ordinal(4)] 
		[RED("lootingData")] 
		public CHandle<MinimalLootingListItemData> LootingData
		{
			get => GetProperty(ref _lootingData);
			set => SetProperty(ref _lootingData, value);
		}
	}
}
