using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SettingsVarListener : userSettingsVarListener
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
