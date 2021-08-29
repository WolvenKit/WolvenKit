using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HotkeyWidgetStatsListener : gameScriptStatusEffectListener
	{
		private CWeakHandle<GenericHotkeyController> _controller;

		[Ordinal(0)] 
		[RED("controller")] 
		public CWeakHandle<GenericHotkeyController> Controller
		{
			get => GetProperty(ref _controller);
			set => SetProperty(ref _controller, value);
		}
	}
}
