using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MarketingConsentPopupData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("type")] 
		public CEnum<inkMarketingConsentPopupType> Type
		{
			get => GetPropertyValue<CEnum<inkMarketingConsentPopupType>>();
			set => SetPropertyValue<CEnum<inkMarketingConsentPopupType>>(value);
		}

		public MarketingConsentPopupData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
