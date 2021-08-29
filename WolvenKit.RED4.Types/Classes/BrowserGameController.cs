using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BrowserGameController : gameuiWidgetGameController
	{
		private inkWidgetReference _logicControllerRef;
		private CWeakHandle<gameJournalManager> _journalManager;
		private CArray<CName> _locationTags;

		[Ordinal(2)] 
		[RED("logicControllerRef")] 
		public inkWidgetReference LogicControllerRef
		{
			get => GetProperty(ref _logicControllerRef);
			set => SetProperty(ref _logicControllerRef, value);
		}

		[Ordinal(3)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(4)] 
		[RED("locationTags")] 
		public CArray<CName> LocationTags
		{
			get => GetProperty(ref _locationTags);
			set => SetProperty(ref _locationTags, value);
		}
	}
}
