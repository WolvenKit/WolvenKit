using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SettingsNotificationListener : userSettingsNotificationListener
	{
		[Ordinal(0)] 
		[RED("ctrl")] 
		public CWeakHandle<SettingsMainGameController> Ctrl
		{
			get => GetPropertyValue<CWeakHandle<SettingsMainGameController>>();
			set => SetPropertyValue<CWeakHandle<SettingsMainGameController>>(value);
		}
	}
}
