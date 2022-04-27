using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CrosshairGameControllerPersistentDot : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetPropertyValue<CHandle<userSettingsUserSettings>>();
			set => SetPropertyValue<CHandle<userSettingsUserSettings>>(value);
		}

		[Ordinal(10)] 
		[RED("settingsListener")] 
		public CHandle<PersistentDotSettingsListener> SettingsListener
		{
			get => GetPropertyValue<CHandle<PersistentDotSettingsListener>>();
			set => SetPropertyValue<CHandle<PersistentDotSettingsListener>>(value);
		}

		[Ordinal(11)] 
		[RED("groupPath")] 
		public CName GroupPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public CrosshairGameControllerPersistentDot()
		{
			GroupPath = "/interface";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
