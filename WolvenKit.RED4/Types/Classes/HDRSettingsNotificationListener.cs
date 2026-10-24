using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HDRSettingsNotificationListener : userSettingsNotificationListener
	{
		[Ordinal(0)] 
		[RED("ctrl")] 
		public CWeakHandle<gameuiHDRSettingsGameController> Ctrl
		{
			get => GetPropertyValue<CWeakHandle<gameuiHDRSettingsGameController>>();
			set => SetPropertyValue<CWeakHandle<gameuiHDRSettingsGameController>>(value);
		}

		public HDRSettingsNotificationListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
