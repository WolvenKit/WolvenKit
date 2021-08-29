using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BriefingScreen : gameuiHUDGameController
	{
		private inkWidgetReference _logicControllerRef;
		private CWeakHandle<gameJournalManager> _journalManager;
		private CHandle<redCallbackObject> _bbOpenerEventID;
		private CHandle<redCallbackObject> _bbSizeEventID;
		private CHandle<redCallbackObject> _bbAlignmentEventID;

		[Ordinal(9)] 
		[RED("logicControllerRef")] 
		public inkWidgetReference LogicControllerRef
		{
			get => GetProperty(ref _logicControllerRef);
			set => SetProperty(ref _logicControllerRef, value);
		}

		[Ordinal(10)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(11)] 
		[RED("bbOpenerEventID")] 
		public CHandle<redCallbackObject> BbOpenerEventID
		{
			get => GetProperty(ref _bbOpenerEventID);
			set => SetProperty(ref _bbOpenerEventID, value);
		}

		[Ordinal(12)] 
		[RED("bbSizeEventID")] 
		public CHandle<redCallbackObject> BbSizeEventID
		{
			get => GetProperty(ref _bbSizeEventID);
			set => SetProperty(ref _bbSizeEventID, value);
		}

		[Ordinal(13)] 
		[RED("bbAlignmentEventID")] 
		public CHandle<redCallbackObject> BbAlignmentEventID
		{
			get => GetProperty(ref _bbAlignmentEventID);
			set => SetProperty(ref _bbAlignmentEventID, value);
		}
	}
}
