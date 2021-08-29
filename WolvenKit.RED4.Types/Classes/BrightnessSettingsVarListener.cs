using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BrightnessSettingsVarListener : userSettingsVarListener
	{
		private CWeakHandle<BrightnessSettingsGameController> _ctrl;

		[Ordinal(0)] 
		[RED("ctrl")] 
		public CWeakHandle<BrightnessSettingsGameController> Ctrl
		{
			get => GetProperty(ref _ctrl);
			set => SetProperty(ref _ctrl, value);
		}
	}
}
