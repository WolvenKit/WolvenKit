using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TooltipLootingCachedData : IScriptable
	{
		private wCHandle<gameItemData> _externalItemData;
		private wCHandle<gamedataItem_Record> _itemRecord;
		private wCHandle<gameItemData> _comparisonItemData;
		private gameItemID _comparisonItemId;
		private CHandle<MinimalLootingListItemData> _lootingData;

		[Ordinal(0)] 
		[RED("externalItemData")] 
		public wCHandle<gameItemData> ExternalItemData
		{
			get => GetProperty(ref _externalItemData);
			set => SetProperty(ref _externalItemData, value);
		}

		[Ordinal(1)] 
		[RED("itemRecord")] 
		public wCHandle<gamedataItem_Record> ItemRecord
		{
			get => GetProperty(ref _itemRecord);
			set => SetProperty(ref _itemRecord, value);
		}

		[Ordinal(2)] 
		[RED("comparisonItemData")] 
		public wCHandle<gameItemData> ComparisonItemData
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

		public TooltipLootingCachedData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
