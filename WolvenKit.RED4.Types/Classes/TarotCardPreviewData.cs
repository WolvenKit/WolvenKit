using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TarotCardPreviewData : inkGameNotificationData
	{
		private TarotCardData _cardData;

		[Ordinal(6)] 
		[RED("cardData")] 
		public TarotCardData CardData
		{
			get => GetProperty(ref _cardData);
			set => SetProperty(ref _cardData, value);
		}
	}
}
