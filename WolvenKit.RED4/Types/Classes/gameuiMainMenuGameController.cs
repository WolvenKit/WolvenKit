using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiMainMenuGameController : gameuiMenuItemListGameController
	{
		[Ordinal(7)] 
		[RED("backgroundContainer")] 
		public inkCompoundWidgetReference BackgroundContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("NeedToDisplayStartupUpdateModsPopup")] 
		public gameuiSendModInfoToUpdateCallback NeedToDisplayStartupUpdateModsPopup
		{
			get => GetPropertyValue<gameuiSendModInfoToUpdateCallback>();
			set => SetPropertyValue<gameuiSendModInfoToUpdateCallback>(value);
		}

		public gameuiMainMenuGameController()
		{
			BackgroundContainer = new inkCompoundWidgetReference();
			NeedToDisplayStartupUpdateModsPopup = new gameuiSendModInfoToUpdateCallback { CallbackName = "OnNeedToDisplayStartupUpdateModsPopup" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
