using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DropPointTerminalInkGameController : DeviceInkGameControllerBase
	{
		private inkWidgetReference _sellAction;
		private CHandle<redCallbackObject> _onGlitchingStateChangedListener;

		[Ordinal(16)] 
		[RED("sellAction")] 
		public inkWidgetReference SellAction
		{
			get => GetProperty(ref _sellAction);
			set => SetProperty(ref _sellAction, value);
		}

		[Ordinal(17)] 
		[RED("onGlitchingStateChangedListener")] 
		public CHandle<redCallbackObject> OnGlitchingStateChangedListener
		{
			get => GetProperty(ref _onGlitchingStateChangedListener);
			set => SetProperty(ref _onGlitchingStateChangedListener, value);
		}
	}
}
