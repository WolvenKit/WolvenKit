using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ConfessionalInkGameController : DeviceInkGameControllerBase
	{
		private CWeakHandle<inkCanvasWidget> _defaultUI;
		private CWeakHandle<inkVideoWidget> _mainDisplayWidget;
		private CWeakHandle<inkTextWidget> _messegeWidget;
		private CWeakHandle<inkTextWidget> _defaultTextWidget;
		private CWeakHandle<inkWidget> _actionsList;
		private CHandle<inkanimProxy> _runningAnimation;
		private CBool _isConfessing;
		private CHandle<redCallbackObject> _onGlitchingStateChangedListener;
		private CHandle<redCallbackObject> _onConfessListener;

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
		[RED("messegeWidget")] 
		public CWeakHandle<inkTextWidget> MessegeWidget
		{
			get => GetProperty(ref _messegeWidget);
			set => SetProperty(ref _messegeWidget, value);
		}

		[Ordinal(19)] 
		[RED("defaultTextWidget")] 
		public CWeakHandle<inkTextWidget> DefaultTextWidget
		{
			get => GetProperty(ref _defaultTextWidget);
			set => SetProperty(ref _defaultTextWidget, value);
		}

		[Ordinal(20)] 
		[RED("actionsList")] 
		public CWeakHandle<inkWidget> ActionsList
		{
			get => GetProperty(ref _actionsList);
			set => SetProperty(ref _actionsList, value);
		}

		[Ordinal(21)] 
		[RED("RunningAnimation")] 
		public CHandle<inkanimProxy> RunningAnimation
		{
			get => GetProperty(ref _runningAnimation);
			set => SetProperty(ref _runningAnimation, value);
		}

		[Ordinal(22)] 
		[RED("isConfessing")] 
		public CBool IsConfessing
		{
			get => GetProperty(ref _isConfessing);
			set => SetProperty(ref _isConfessing, value);
		}

		[Ordinal(23)] 
		[RED("onGlitchingStateChangedListener")] 
		public CHandle<redCallbackObject> OnGlitchingStateChangedListener
		{
			get => GetProperty(ref _onGlitchingStateChangedListener);
			set => SetProperty(ref _onGlitchingStateChangedListener, value);
		}

		[Ordinal(24)] 
		[RED("onConfessListener")] 
		public CHandle<redCallbackObject> OnConfessListener
		{
			get => GetProperty(ref _onConfessListener);
			set => SetProperty(ref _onConfessListener, value);
		}
	}
}
