using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IntercomInkGameController : DeviceInkGameControllerBase
	{
		private inkWidgetReference _actionsList;
		private CWeakHandle<inkVideoWidget> _mainDisplayWidget;
		private CWeakHandle<CallActionWidgetController> _buttonRef;
		private CEnum<IntercomStatus> _state;
		private CHandle<redCallbackObject> _onUpdateStatusListener;
		private CHandle<redCallbackObject> _onGlitchingStateChangedListener;

		[Ordinal(16)] 
		[RED("actionsList")] 
		public inkWidgetReference ActionsList
		{
			get => GetProperty(ref _actionsList);
			set => SetProperty(ref _actionsList, value);
		}

		[Ordinal(17)] 
		[RED("mainDisplayWidget")] 
		public CWeakHandle<inkVideoWidget> MainDisplayWidget
		{
			get => GetProperty(ref _mainDisplayWidget);
			set => SetProperty(ref _mainDisplayWidget, value);
		}

		[Ordinal(18)] 
		[RED("buttonRef")] 
		public CWeakHandle<CallActionWidgetController> ButtonRef
		{
			get => GetProperty(ref _buttonRef);
			set => SetProperty(ref _buttonRef, value);
		}

		[Ordinal(19)] 
		[RED("state")] 
		public CEnum<IntercomStatus> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(20)] 
		[RED("onUpdateStatusListener")] 
		public CHandle<redCallbackObject> OnUpdateStatusListener
		{
			get => GetProperty(ref _onUpdateStatusListener);
			set => SetProperty(ref _onUpdateStatusListener, value);
		}

		[Ordinal(21)] 
		[RED("onGlitchingStateChangedListener")] 
		public CHandle<redCallbackObject> OnGlitchingStateChangedListener
		{
			get => GetProperty(ref _onGlitchingStateChangedListener);
			set => SetProperty(ref _onGlitchingStateChangedListener, value);
		}
	}
}
