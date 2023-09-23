using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TarotCardAddedNotification : GenericNotificationController
	{
		[Ordinal(15)] 
		[RED("cardImage")] 
		public inkImageWidgetReference CardImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("cardNameLabel")] 
		public inkTextWidgetReference CardNameLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public TarotCardAddedNotification()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
