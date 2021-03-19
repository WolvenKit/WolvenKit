using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LcdScreenInkGameController : DeviceInkGameControllerBase
	{
		private wCHandle<inkCanvasWidget> _defaultUI;
		private wCHandle<inkVideoWidget> _mainDisplayWidget;
		private wCHandle<inkTextWidget> _messegeWidget;
		private wCHandle<inkLeafWidget> _backgroundWidget;
		private wCHandle<gamedataScreenMessageData_Record> _messegeRecord;
		private CBool _replaceTextWithCustomNumber;
		private CInt32 _customNumber;
		private CUInt32 _onGlitchingStateChangedListener;
		private CUInt32 _onMessegeChangedListener;

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
		[RED("backgroundWidget")] 
		public wCHandle<inkLeafWidget> BackgroundWidget
		{
			get => GetProperty(ref _backgroundWidget);
			set => SetProperty(ref _backgroundWidget, value);
		}

		[Ordinal(20)] 
		[RED("messegeRecord")] 
		public wCHandle<gamedataScreenMessageData_Record> MessegeRecord
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
		public CUInt32 OnGlitchingStateChangedListener
		{
			get => GetProperty(ref _onGlitchingStateChangedListener);
			set => SetProperty(ref _onGlitchingStateChangedListener, value);
		}

		[Ordinal(24)] 
		[RED("onMessegeChangedListener")] 
		public CUInt32 OnMessegeChangedListener
		{
			get => GetProperty(ref _onMessegeChangedListener);
			set => SetProperty(ref _onMessegeChangedListener, value);
		}

		public LcdScreenInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
