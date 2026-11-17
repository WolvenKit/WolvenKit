using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiUpdateModsPopupController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("ReceivedModLogo")] 
		public gameuiModLogoInfoReceivedCallback ReceivedModLogo
		{
			get => GetPropertyValue<gameuiModLogoInfoReceivedCallback>();
			set => SetPropertyValue<gameuiModLogoInfoReceivedCallback>(value);
		}

		public gameuiUpdateModsPopupController()
		{
			ReceivedModLogo = new gameuiModLogoInfoReceivedCallback { CallbackName = "OnReceivedModLogo" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
