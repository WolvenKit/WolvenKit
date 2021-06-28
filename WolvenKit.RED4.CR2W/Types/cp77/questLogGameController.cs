using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questLogGameController : gameuiMenuGameController
	{
		private inkWidgetReference _virtualList;
		private inkWidgetReference _detailsPanel;
		private inkWidgetReference _buttonHints;
		private inkWidgetReference _buttonTrack;
		private ScriptGameInstance _game;
		private wCHandle<gameJournalManager> _journalManager;
		private CArray<wCHandle<gameJournalEntry>> _quests;
		private CArray<wCHandle<gameJournalEntry>> _resolvedQuests;
		private wCHandle<ButtonHints> _buttonHintsController;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private wCHandle<gameJournalQuest> _trackedQuest;
		private wCHandle<gameJournalQuest> _curreentQuest;
		private CInt32 _externallyOpenedQuestHash;
		private CInt32 _playerLevel;
		private CInt32 _recommendedLevel;
		private CHandle<inkanimProxy> _entryAnimProxy;
		private CBool _canUsePhone;
		private CArray<CHandle<VirutalNestedListData>> _listData;

		[Ordinal(3)] 
		[RED("virtualList")] 
		public inkWidgetReference VirtualList
		{
			get => GetProperty(ref _virtualList);
			set => SetProperty(ref _virtualList, value);
		}

		[Ordinal(4)] 
		[RED("detailsPanel")] 
		public inkWidgetReference DetailsPanel
		{
			get => GetProperty(ref _detailsPanel);
			set => SetProperty(ref _detailsPanel, value);
		}

		[Ordinal(5)] 
		[RED("buttonHints")] 
		public inkWidgetReference ButtonHints
		{
			get => GetProperty(ref _buttonHints);
			set => SetProperty(ref _buttonHints, value);
		}

		[Ordinal(6)] 
		[RED("buttonTrack")] 
		public inkWidgetReference ButtonTrack
		{
			get => GetProperty(ref _buttonTrack);
			set => SetProperty(ref _buttonTrack, value);
		}

		[Ordinal(7)] 
		[RED("game")] 
		public ScriptGameInstance Game
		{
			get => GetProperty(ref _game);
			set => SetProperty(ref _game, value);
		}

		[Ordinal(8)] 
		[RED("journalManager")] 
		public wCHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(9)] 
		[RED("quests")] 
		public CArray<wCHandle<gameJournalEntry>> Quests
		{
			get => GetProperty(ref _quests);
			set => SetProperty(ref _quests, value);
		}

		[Ordinal(10)] 
		[RED("resolvedQuests")] 
		public CArray<wCHandle<gameJournalEntry>> ResolvedQuests
		{
			get => GetProperty(ref _resolvedQuests);
			set => SetProperty(ref _resolvedQuests, value);
		}

		[Ordinal(11)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(12)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(13)] 
		[RED("trackedQuest")] 
		public wCHandle<gameJournalQuest> TrackedQuest
		{
			get => GetProperty(ref _trackedQuest);
			set => SetProperty(ref _trackedQuest, value);
		}

		[Ordinal(14)] 
		[RED("curreentQuest")] 
		public wCHandle<gameJournalQuest> CurreentQuest
		{
			get => GetProperty(ref _curreentQuest);
			set => SetProperty(ref _curreentQuest, value);
		}

		[Ordinal(15)] 
		[RED("externallyOpenedQuestHash")] 
		public CInt32 ExternallyOpenedQuestHash
		{
			get => GetProperty(ref _externallyOpenedQuestHash);
			set => SetProperty(ref _externallyOpenedQuestHash, value);
		}

		[Ordinal(16)] 
		[RED("playerLevel")] 
		public CInt32 PlayerLevel
		{
			get => GetProperty(ref _playerLevel);
			set => SetProperty(ref _playerLevel, value);
		}

		[Ordinal(17)] 
		[RED("recommendedLevel")] 
		public CInt32 RecommendedLevel
		{
			get => GetProperty(ref _recommendedLevel);
			set => SetProperty(ref _recommendedLevel, value);
		}

		[Ordinal(18)] 
		[RED("entryAnimProxy")] 
		public CHandle<inkanimProxy> EntryAnimProxy
		{
			get => GetProperty(ref _entryAnimProxy);
			set => SetProperty(ref _entryAnimProxy, value);
		}

		[Ordinal(19)] 
		[RED("canUsePhone")] 
		public CBool CanUsePhone
		{
			get => GetProperty(ref _canUsePhone);
			set => SetProperty(ref _canUsePhone, value);
		}

		[Ordinal(20)] 
		[RED("listData")] 
		public CArray<CHandle<VirutalNestedListData>> ListData
		{
			get => GetProperty(ref _listData);
			set => SetProperty(ref _listData, value);
		}

		public questLogGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
