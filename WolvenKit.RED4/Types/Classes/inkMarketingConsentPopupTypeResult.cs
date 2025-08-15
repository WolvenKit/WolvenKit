
namespace WolvenKit.RED4.Types
{
	public partial class inkMarketingConsentPopupTypeResult : inkCallbackBase
	{
		public inkMarketingConsentPopupTypeResult()
		{
			CallbackName = "MarketingConsentPopupTypeResult";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
