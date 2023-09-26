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
			CardImage = new inkImageWidgetReference();
			CardNameLabel = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
