using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CrosshairGameControllerPersistentDot : gameuiHUDGameController
	{
		private CHandle<userSettingsUserSettings> _settings;
		private CHandle<PersistentDotSettingsListener> _settingsListener;
		private CName _groupPath;

		[Ordinal(9)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetProperty(ref _settings);
			set => SetProperty(ref _settings, value);
		}

		[Ordinal(10)] 
		[RED("settingsListener")] 
		public CHandle<PersistentDotSettingsListener> SettingsListener
		{
			get => GetProperty(ref _settingsListener);
			set => SetProperty(ref _settingsListener, value);
		}

		[Ordinal(11)] 
		[RED("groupPath")] 
		public CName GroupPath
		{
			get => GetProperty(ref _groupPath);
			set => SetProperty(ref _groupPath, value);
		}

		public CrosshairGameControllerPersistentDot()
		{
			_groupPath = "/interface";
		}
	}
}
