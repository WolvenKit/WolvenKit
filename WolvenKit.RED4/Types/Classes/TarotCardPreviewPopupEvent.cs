using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TarotCardPreviewPopupEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("data")] 
		public CHandle<TarotCardPreviewData> Data
		{
			get => GetPropertyValue<CHandle<TarotCardPreviewData>>();
			set => SetPropertyValue<CHandle<TarotCardPreviewData>>(value);
		}

		public TarotCardPreviewPopupEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
