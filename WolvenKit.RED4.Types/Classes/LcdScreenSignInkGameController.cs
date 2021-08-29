using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LcdScreenSignInkGameController : DeviceInkGameControllerBase
	{
		private CWeakHandle<gamedataScreenMessageData_Record> _messegeRecord;
		private CBool _replaceTextWithCustomNumber;
		private CInt32 _customNumber;
		private CHandle<redCallbackObject> _onGlitchingStateChangedListener;
		private CHandle<redCallbackObject> _onMessegeChangedListener;

		[Ordinal(16)] 
		[RED("messegeRecord")] 
		public CWeakHandle<gamedataScreenMessageData_Record> MessegeRecord
		{
			get => GetProperty(ref _messegeRecord);
			set => SetProperty(ref _messegeRecord, value);
		}

		[Ordinal(17)] 
		[RED("replaceTextWithCustomNumber")] 
		public CBool ReplaceTextWithCustomNumber
		{
			get => GetProperty(ref _replaceTextWithCustomNumber);
			set => SetProperty(ref _replaceTextWithCustomNumber, value);
		}

		[Ordinal(18)] 
		[RED("customNumber")] 
		public CInt32 CustomNumber
		{
			get => GetProperty(ref _customNumber);
			set => SetProperty(ref _customNumber, value);
		}

		[Ordinal(19)] 
		[RED("onGlitchingStateChangedListener")] 
		public CHandle<redCallbackObject> OnGlitchingStateChangedListener
		{
			get => GetProperty(ref _onGlitchingStateChangedListener);
			set => SetProperty(ref _onGlitchingStateChangedListener, value);
		}

		[Ordinal(20)] 
		[RED("onMessegeChangedListener")] 
		public CHandle<redCallbackObject> OnMessegeChangedListener
		{
			get => GetProperty(ref _onMessegeChangedListener);
			set => SetProperty(ref _onMessegeChangedListener, value);
		}
	}
}
