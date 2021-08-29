using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LcdScreenInkGameController : DeviceInkGameControllerBase
	{
		private CWeakHandle<inkCanvasWidget> _defaultUI;
		private CWeakHandle<inkVideoWidget> _mainDisplayWidget;
		private CWeakHandle<inkTextWidget> _messegeWidget;
		private CWeakHandle<inkLeafWidget> _backgroundWidget;
		private CWeakHandle<gamedataScreenMessageData_Record> _messegeRecord;
		private CBool _replaceTextWithCustomNumber;
		private CInt32 _customNumber;
		private CHandle<redCallbackObject> _onGlitchingStateChangedListener;
		private CHandle<redCallbackObject> _onMessegeChangedListener;

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
		[RED("backgroundWidget")] 
		public CWeakHandle<inkLeafWidget> BackgroundWidget
		{
			get => GetProperty(ref _backgroundWidget);
			set => SetProperty(ref _backgroundWidget, value);
		}

		[Ordinal(20)] 
		[RED("messegeRecord")] 
		public CWeakHandle<gamedataScreenMessageData_Record> MessegeRecord
		{
			get => GetProperty(ref _messegeRecord);
			set => SetProperty(ref _messegeRecord, value);
		}

		[Ordinal(21)] 
		[RED("replaceTextWithCustomNumber")] 
		public CBool ReplaceTextWithCustomNumber
		{
			get => GetProperty(ref _replaceTextWithCustomNumber);
			set => SetProperty(ref _replaceTextWithCustomNumber, value);
		}

		[Ordinal(22)] 
		[RED("customNumber")] 
		public CInt32 CustomNumber
		{
			get => GetProperty(ref _customNumber);
			set => SetProperty(ref _customNumber, value);
		}

		[Ordinal(23)] 
		[RED("onGlitchingStateChangedListener")] 
		public CHandle<redCallbackObject> OnGlitchingStateChangedListener
		{
			get => GetProperty(ref _onGlitchingStateChangedListener);
			set => SetProperty(ref _onGlitchingStateChangedListener, value);
		}

		[Ordinal(24)] 
		[RED("onMessegeChangedListener")] 
		public CHandle<redCallbackObject> OnMessegeChangedListener
		{
			get => GetProperty(ref _onMessegeChangedListener);
			set => SetProperty(ref _onMessegeChangedListener, value);
		}
	}
}
