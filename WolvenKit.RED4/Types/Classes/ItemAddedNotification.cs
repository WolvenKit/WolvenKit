using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemAddedNotification : GenericNotificationController
	{
		[Ordinal(12)] 
		[RED("itemImage")] 
		public inkImageWidgetReference ItemImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("rarityBar")] 
		public inkWidgetReference RarityBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("itemIconGender")] 
		public CEnum<gameItemIconGender> ItemIconGender
		{
			get => GetPropertyValue<CEnum<gameItemIconGender>>();
			set => SetPropertyValue<CEnum<gameItemIconGender>>(value);
		}

		[Ordinal(15)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public ItemAddedNotification()
		{
			ItemImage = new();
			RarityBar = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
