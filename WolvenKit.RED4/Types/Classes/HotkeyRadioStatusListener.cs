using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HotkeyRadioStatusListener : gameScriptStatusEffectListener
	{
		[Ordinal(0)] 
		[RED("radioWidgetController")] 
		public CWeakHandle<HotkeyRadioWidgetController> RadioWidgetController
		{
			get => GetPropertyValue<CWeakHandle<HotkeyRadioWidgetController>>();
			set => SetPropertyValue<CWeakHandle<HotkeyRadioWidgetController>>(value);
		}

		public HotkeyRadioStatusListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
