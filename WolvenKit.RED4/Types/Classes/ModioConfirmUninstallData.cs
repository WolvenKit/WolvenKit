using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModioConfirmUninstallData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("ownerMenu")] 
		public CWeakHandle<BrowserModsMenuGameController> OwnerMenu
		{
			get => GetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>();
			set => SetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>(value);
		}

		public ModioConfirmUninstallData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
