using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemComparableTypesCache : IScriptable
	{
		[Ordinal(0)] 
		[RED("itemTypeRecord")] 
		public CWeakHandle<gamedataItemType_Record> ItemTypeRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataItemType_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataItemType_Record>>(value);
		}

		[Ordinal(1)] 
		[RED("comparableTypes")] 
		public CArray<CEnum<gamedataItemType>> ComparableTypes
		{
			get => GetPropertyValue<CArray<CEnum<gamedataItemType>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataItemType>>>(value);
		}

		[Ordinal(2)] 
		[RED("comparableRecordTypes")] 
		public CArray<CWeakHandle<gamedataItemType_Record>> ComparableRecordTypes
		{
			get => GetPropertyValue<CArray<CWeakHandle<gamedataItemType_Record>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gamedataItemType_Record>>>(value);
		}

		public ItemComparableTypesCache()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
