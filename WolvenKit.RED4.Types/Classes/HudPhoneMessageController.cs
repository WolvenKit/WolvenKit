using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HudPhoneMessageController : HUDPhoneElement
	{
		private inkTextWidgetReference _messageText;
		private CHandle<inkanimProxy> _messageAnim;
		private CName _showingAnimationName;
		private CName _hidingAnimationName;
		private CName _visibleAnimationName;
		private CInt32 _messageMaxLength;
		private CString _messageTopper;
		private CBool _paused;
		private CWeakHandle<gameJournalPhoneMessage> _currentMessage;
		private CArray<CWeakHandle<gameJournalPhoneMessage>> _queue;

		[Ordinal(2)] 
		[RED("MessageText")] 
		public inkTextWidgetReference MessageText
		{
			get => GetProperty(ref _messageText);
			set => SetProperty(ref _messageText, value);
		}

		[Ordinal(3)] 
		[RED("MessageAnim")] 
		public CHandle<inkanimProxy> MessageAnim
		{
			get => GetProperty(ref _messageAnim);
			set => SetProperty(ref _messageAnim, value);
		}

		[Ordinal(4)] 
		[RED("ShowingAnimationName")] 
		public CName ShowingAnimationName
		{
			get => GetProperty(ref _showingAnimationName);
			set => SetProperty(ref _showingAnimationName, value);
		}

		[Ordinal(5)] 
		[RED("HidingAnimationName")] 
		public CName HidingAnimationName
		{
			get => GetProperty(ref _hidingAnimationName);
			set => SetProperty(ref _hidingAnimationName, value);
		}

		[Ordinal(6)] 
		[RED("VisibleAnimationName")] 
		public CName VisibleAnimationName
		{
			get => GetProperty(ref _visibleAnimationName);
			set => SetProperty(ref _visibleAnimationName, value);
		}

		[Ordinal(7)] 
		[RED("MessageMaxLength")] 
		public CInt32 MessageMaxLength
		{
			get => GetProperty(ref _messageMaxLength);
			set => SetProperty(ref _messageMaxLength, value);
		}

		[Ordinal(8)] 
		[RED("MessageTopper")] 
		public CString MessageTopper
		{
			get => GetProperty(ref _messageTopper);
			set => SetProperty(ref _messageTopper, value);
		}

		[Ordinal(9)] 
		[RED("Paused")] 
		public CBool Paused
		{
			get => GetProperty(ref _paused);
			set => SetProperty(ref _paused, value);
		}

		[Ordinal(10)] 
		[RED("CurrentMessage")] 
		public CWeakHandle<gameJournalPhoneMessage> CurrentMessage
		{
			get => GetProperty(ref _currentMessage);
			set => SetProperty(ref _currentMessage, value);
		}

		[Ordinal(11)] 
		[RED("Queue")] 
		public CArray<CWeakHandle<gameJournalPhoneMessage>> Queue
		{
			get => GetProperty(ref _queue);
			set => SetProperty(ref _queue, value);
		}
	}
}
