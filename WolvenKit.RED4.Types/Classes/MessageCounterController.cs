using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MessageCounterController : gameuiWidgetGameController
	{
		private inkTextWidgetReference _messageCounter;
		private CWeakHandle<inkWidget> _rootWidget;
		private CHandle<redCallbackObject> _callInformationBBID;
		private CWeakHandle<gameJournalManager> _journalManager;
		private CWeakHandle<gameObject> _owner;

		[Ordinal(2)] 
		[RED("messageCounter")] 
		public inkTextWidgetReference MessageCounter
		{
			get => GetProperty(ref _messageCounter);
			set => SetProperty(ref _messageCounter, value);
		}

		[Ordinal(3)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(4)] 
		[RED("CallInformationBBID")] 
		public CHandle<redCallbackObject> CallInformationBBID
		{
			get => GetProperty(ref _callInformationBBID);
			set => SetProperty(ref _callInformationBBID, value);
		}

		[Ordinal(5)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(6)] 
		[RED("Owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}
	}
}
