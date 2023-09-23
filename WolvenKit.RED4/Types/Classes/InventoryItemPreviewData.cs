using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryItemPreviewData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(8)] 
		[RED("itemName")] 
		public CString ItemName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(9)] 
		[RED("itemDescription")] 
		public CString ItemDescription
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(10)] 
		[RED("requiredLevel")] 
		public CInt32 RequiredLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(11)] 
		[RED("itemQualityState")] 
		public CName ItemQualityState
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("itemEvolution")] 
		public CEnum<gamedataWeaponEvolution> ItemEvolution
		{
			get => GetPropertyValue<CEnum<gamedataWeaponEvolution>>();
			set => SetPropertyValue<CEnum<gamedataWeaponEvolution>>(value);
		}

		[Ordinal(13)] 
		[RED("itemPerkGroup")] 
		public CEnum<gamedataPerkWeaponGroupType> ItemPerkGroup
		{
			get => GetPropertyValue<CEnum<gamedataPerkWeaponGroupType>>();
			set => SetPropertyValue<CEnum<gamedataPerkWeaponGroupType>>(value);
		}

		public InventoryItemPreviewData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
