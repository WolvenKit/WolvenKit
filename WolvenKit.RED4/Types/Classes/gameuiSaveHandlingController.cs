using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiSaveHandlingController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("NeedToDisplayLoadMenuUpdateModsPopup")] 
		public gameuiLoadUISendModInfoToUpdateCallback NeedToDisplayLoadMenuUpdateModsPopup
		{
			get => GetPropertyValue<gameuiLoadUISendModInfoToUpdateCallback>();
			set => SetPropertyValue<gameuiLoadUISendModInfoToUpdateCallback>(value);
		}

		public gameuiSaveHandlingController()
		{
			NeedToDisplayLoadMenuUpdateModsPopup = new gameuiLoadUISendModInfoToUpdateCallback { CallbackName = "OnNeedToDisplayLoadMenuUpdateModsPopup" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
