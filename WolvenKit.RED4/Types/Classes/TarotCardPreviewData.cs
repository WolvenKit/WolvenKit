using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TarotCardPreviewData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("cardData")] 
		public TarotCardData CardData
		{
			get => GetPropertyValue<TarotCardData>();
			set => SetPropertyValue<TarotCardData>(value);
		}

		public TarotCardPreviewData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
