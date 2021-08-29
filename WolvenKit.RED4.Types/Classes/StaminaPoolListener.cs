using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StaminaPoolListener : gameScriptStatPoolsListener
	{
		private CWeakHandle<StaminabarWidgetGameController> _staminaBar;

		[Ordinal(0)] 
		[RED("staminaBar")] 
		public CWeakHandle<StaminabarWidgetGameController> StaminaBar
		{
			get => GetProperty(ref _staminaBar);
			set => SetProperty(ref _staminaBar, value);
		}
	}
}
