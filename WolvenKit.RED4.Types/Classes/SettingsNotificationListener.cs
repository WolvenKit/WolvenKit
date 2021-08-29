using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SettingsNotificationListener : userSettingsNotificationListener
	{
		private CWeakHandle<SettingsMainGameController> _ctrl;

		[Ordinal(0)] 
		[RED("ctrl")] 
		public CWeakHandle<SettingsMainGameController> Ctrl
		{
			get => GetProperty(ref _ctrl);
			set => SetProperty(ref _ctrl, value);
		}
	}
}
