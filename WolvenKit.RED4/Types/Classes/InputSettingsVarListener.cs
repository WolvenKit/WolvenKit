using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InputSettingsVarListener : userSettingsVarListener
	{
		[Ordinal(0)] 
		[RED("ctrl")] 
		public CWeakHandle<gameuiControllerSettingsGameController> Ctrl
		{
			get => GetPropertyValue<CWeakHandle<gameuiControllerSettingsGameController>>();
			set => SetPropertyValue<CWeakHandle<gameuiControllerSettingsGameController>>(value);
		}

		public InputSettingsVarListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
