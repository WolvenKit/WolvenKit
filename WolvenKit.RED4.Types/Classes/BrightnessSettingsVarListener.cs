using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BrightnessSettingsVarListener : userSettingsVarListener
	{
		[Ordinal(0)] 
		[RED("ctrl")] 
		public CWeakHandle<BrightnessSettingsGameController> Ctrl
		{
			get => GetPropertyValue<CWeakHandle<BrightnessSettingsGameController>>();
			set => SetPropertyValue<CWeakHandle<BrightnessSettingsGameController>>(value);
		}
	}
}
