using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiItemAddedNotificationViewData : gameuiGenericNotificationViewData
	{
		[Ordinal(5)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(6)] 
		[RED("animation")] 
		public CName Animation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("itemRarity")] 
		public CName ItemRarity
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameuiItemAddedNotificationViewData()
		{
			ItemID = new gameItemID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
