using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ArcadeMachineInkGameController : DeviceInkGameControllerBase
	{
		private CWeakHandle<inkCanvasWidget> _defaultUI;
		private CWeakHandle<inkVideoWidget> _mainDisplayWidget;
		private CWeakHandle<inkTextWidget> _counterWidget;
		private CHandle<redCallbackObject> _onGlitchingStateChangedListener;

		[Ordinal(16)] 
		[RED("defaultUI")] 
		public CWeakHandle<inkCanvasWidget> DefaultUI
		{
			get => GetProperty(ref _defaultUI);
			set => SetProperty(ref _defaultUI, value);
		}

		[Ordinal(17)] 
		[RED("mainDisplayWidget")] 
		public CWeakHandle<inkVideoWidget> MainDisplayWidget
		{
			get => GetProperty(ref _mainDisplayWidget);
			set => SetProperty(ref _mainDisplayWidget, value);
		}

		[Ordinal(18)] 
		[RED("counterWidget")] 
		public CWeakHandle<inkTextWidget> CounterWidget
		{
			get => GetProperty(ref _counterWidget);
			set => SetProperty(ref _counterWidget, value);
		}

		[Ordinal(19)] 
		[RED("onGlitchingStateChangedListener")] 
		public CHandle<redCallbackObject> OnGlitchingStateChangedListener
		{
			get => GetProperty(ref _onGlitchingStateChangedListener);
			set => SetProperty(ref _onGlitchingStateChangedListener, value);
		}
	}
}
