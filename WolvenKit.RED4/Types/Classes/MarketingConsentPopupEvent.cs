using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MarketingConsentPopupEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<inkMarketingConsentPopupType> Type
		{
			get => GetPropertyValue<CEnum<inkMarketingConsentPopupType>>();
			set => SetPropertyValue<CEnum<inkMarketingConsentPopupType>>(value);
		}

		public MarketingConsentPopupEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
