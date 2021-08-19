using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MessageCounterController : gameuiWidgetGameController
	{
		private inkTextWidgetReference _messageCounter;
		private wCHandle<inkWidget> _rootWidget;
		private CHandle<redCallbackObject> _callInformationBBID;
		private wCHandle<gameJournalManager> _journalManager;
		private wCHandle<gameObject> _owner;

		[Ordinal(2)] 
		[RED("messageCounter")] 
		public inkTextWidgetReference MessageCounter
		{
			get => GetProperty(ref _messageCounter);
			set => SetProperty(ref _messageCounter, value);
		}

		[Ordinal(3)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
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
		public wCHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(6)] 
		[RED("Owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		public MessageCounterController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
