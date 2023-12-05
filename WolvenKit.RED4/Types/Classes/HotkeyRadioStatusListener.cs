using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HotkeyRadioStatusListener : gameScriptStatusEffectListener
	{
		[Ordinal(0)] 
		[RED("radioWidgetController")] 
		public CWeakHandle<HotkeyConsumableWidgetController> RadioWidgetController
		{
			get => GetPropertyValue<CWeakHandle<HotkeyConsumableWidgetController>>();
			set => SetPropertyValue<CWeakHandle<HotkeyConsumableWidgetController>>(value);
		}

		public HotkeyRadioStatusListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
