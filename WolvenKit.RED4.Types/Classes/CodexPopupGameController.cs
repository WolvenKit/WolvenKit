using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CodexPopupGameController : gameuiWidgetGameController
	{
		private inkCompoundWidgetReference _entryViewRef;
		private inkCompoundWidgetReference _characterEntryViewRef;
		private inkImageWidgetReference _imageViewRef;
		private CWeakHandle<CodexEntryViewController> _entryViewController;
		private CWeakHandle<CodexEntryViewController> _characterEntryViewController;
		private CWeakHandle<gameObject> _player;
		private CWeakHandle<gameJournalManager> _journalMgr;
		private CHandle<CodexPopupData> _data;

		[Ordinal(2)] 
		[RED("entryViewRef")] 
		public inkCompoundWidgetReference EntryViewRef
		{
			get => GetProperty(ref _entryViewRef);
			set => SetProperty(ref _entryViewRef, value);
		}

		[Ordinal(3)] 
		[RED("characterEntryViewRef")] 
		public inkCompoundWidgetReference CharacterEntryViewRef
		{
			get => GetProperty(ref _characterEntryViewRef);
			set => SetProperty(ref _characterEntryViewRef, value);
		}

		[Ordinal(4)] 
		[RED("imageViewRef")] 
		public inkImageWidgetReference ImageViewRef
		{
			get => GetProperty(ref _imageViewRef);
			set => SetProperty(ref _imageViewRef, value);
		}

		[Ordinal(5)] 
		[RED("entryViewController")] 
		public CWeakHandle<CodexEntryViewController> EntryViewController
		{
			get => GetProperty(ref _entryViewController);
			set => SetProperty(ref _entryViewController, value);
		}

		[Ordinal(6)] 
		[RED("characterEntryViewController")] 
		public CWeakHandle<CodexEntryViewController> CharacterEntryViewController
		{
			get => GetProperty(ref _characterEntryViewController);
			set => SetProperty(ref _characterEntryViewController, value);
		}

		[Ordinal(7)] 
		[RED("player")] 
		public CWeakHandle<gameObject> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(8)] 
		[RED("journalMgr")] 
		public CWeakHandle<gameJournalManager> JournalMgr
		{
			get => GetProperty(ref _journalMgr);
			set => SetProperty(ref _journalMgr, value);
		}

		[Ordinal(9)] 
		[RED("data")] 
		public CHandle<CodexPopupData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
