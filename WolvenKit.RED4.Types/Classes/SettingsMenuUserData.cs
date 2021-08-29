using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SettingsMenuUserData : gameuiMenuGameController
	{
		private CBool _isDlcSettings;

		[Ordinal(3)] 
		[RED("isDlcSettings")] 
		public CBool IsDlcSettings
		{
			get => GetProperty(ref _isDlcSettings);
			set => SetProperty(ref _isDlcSettings, value);
		}
	}
}
