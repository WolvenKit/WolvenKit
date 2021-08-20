using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ConfessionalInkGameController : DeviceInkGameControllerBase
	{
		private wCHandle<inkCanvasWidget> _defaultUI;
		private wCHandle<inkVideoWidget> _mainDisplayWidget;
		private wCHandle<inkTextWidget> _messegeWidget;
		private wCHandle<inkTextWidget> _defaultTextWidget;
		private wCHandle<inkWidget> _actionsList;
		private CHandle<inkanimProxy> _runningAnimation;
		private CBool _isConfessing;
		private CHandle<redCallbackObject> _onGlitchingStateChangedListener;
		private CHandle<redCallbackObject> _onConfessListener;

		[Ordinal(16)] 
		[RED("defaultUI")] 
		public wCHandle<inkCanvasWidget> DefaultUI
		{
			get => GetProperty(ref _defaultUI);
			set => SetProperty(ref _defaultUI, value);
		}

		[Ordinal(17)] 
		[RED("mainDisplayWidget")] 
		public wCHandle<inkVideoWidget> MainDisplayWidget
		{
			get => GetProperty(ref _mainDisplayWidget);
			set => SetProperty(ref _mainDisplayWidget, value);
		}

		[Ordinal(18)] 
		[RED("messegeWidget")] 
		public wCHandle<inkTextWidget> MessegeWidget
		{
			get => GetProperty(ref _messegeWidget);
			set => SetProperty(ref _messegeWidget, value);
		}

		[Ordinal(19)] 
		[RED("defaultTextWidget")] 
		public wCHandle<inkTextWidget> DefaultTextWidget
		{
			get => GetProperty(ref _defaultTextWidget);
			set => SetProperty(ref _defaultTextWidget, value);
		}

		[Ordinal(20)] 
		[RED("actionsList")] 
		public wCHandle<inkWidget> ActionsList
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

		public ConfessionalInkGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
