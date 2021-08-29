using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemComparableTypesCache : IScriptable
	{
		private CEnum<gamedataItemType> _itemType;
		private CWeakHandle<gamedataItemType_Record> _itemTypeRecord;
		private CArray<CEnum<gamedataItemType>> _comparableTypes;
		private CArray<CWeakHandle<gamedataItemType_Record>> _comparableRecordTypes;

		[Ordinal(0)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get => GetProperty(ref _itemType);
			set => SetProperty(ref _itemType, value);
		}

		[Ordinal(1)] 
		[RED("itemTypeRecord")] 
		public CWeakHandle<gamedataItemType_Record> ItemTypeRecord
		{
			get => GetProperty(ref _itemTypeRecord);
			set => SetProperty(ref _itemTypeRecord, value);
		}

		[Ordinal(2)] 
		[RED("comparableTypes")] 
		public CArray<CEnum<gamedataItemType>> ComparableTypes
		{
			get => GetProperty(ref _comparableTypes);
			set => SetProperty(ref _comparableTypes, value);
		}

		[Ordinal(3)] 
		[RED("comparableRecordTypes")] 
		public CArray<CWeakHandle<gamedataItemType_Record>> ComparableRecordTypes
		{
			get => GetProperty(ref _comparableRecordTypes);
			set => SetProperty(ref _comparableRecordTypes, value);
		}
	}
}
