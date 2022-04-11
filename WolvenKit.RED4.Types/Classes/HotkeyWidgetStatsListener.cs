using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HotkeyWidgetStatsListener : gameScriptStatusEffectListener
	{
		[Ordinal(0)] 
		[RED("controller")] 
		public CWeakHandle<GenericHotkeyController> Controller
		{
			get => GetPropertyValue<CWeakHandle<GenericHotkeyController>>();
			set => SetPropertyValue<CWeakHandle<GenericHotkeyController>>(value);
		}
	}
}
