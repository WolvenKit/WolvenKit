using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiHackingMinigameGameController : gameuiWidgetGameController
	{
		private TweakDBID _symbolsRecordTDBID;
		private TweakDBID _minigameDefaultsTDBID;
		private CWeakHandle<gamedataMinigame_Def_Record> _miniGameRecord;
		private CInt32 _dimension;
		private CBool _isTutorialActive;
		private CBool _isOfficerBreach;
		private CBool _isRemoteBreach;
		private CBool _isItemBreach;
		private CInt32 _numberAttempts;
		private inkWidgetReference _tooltipsManagerRef;
		private CWeakHandle<gameuiTooltipsManager> _tooltipsManager;
		private CHandle<gameuiGameSystemUI> _uiSystem;
		private CBool _contextHelpOverlay;
		private CWeakHandle<gameIBlackboard> _bbMinigame;
		private CHandle<redCallbackObject> _bbMinigameStateListener;
		private CWeakHandle<gameIBlackboard> _bbUiData;
		private CHandle<redCallbackObject> _bbControllerStateListener;

		[Ordinal(2)] 
		[RED("symbolsRecordTDBID")] 
		public TweakDBID SymbolsRecordTDBID
		{
			get => GetProperty(ref _symbolsRecordTDBID);
			set => SetProperty(ref _symbolsRecordTDBID, value);
		}

		[Ordinal(3)] 
		[RED("minigameDefaultsTDBID")] 
		public TweakDBID MinigameDefaultsTDBID
		{
			get => GetProperty(ref _minigameDefaultsTDBID);
			set => SetProperty(ref _minigameDefaultsTDBID, value);
		}

		[Ordinal(4)] 
		[RED("miniGameRecord")] 
		public CWeakHandle<gamedataMinigame_Def_Record> MiniGameRecord
		{
			get => GetProperty(ref _miniGameRecord);
			set => SetProperty(ref _miniGameRecord, value);
		}

		[Ordinal(5)] 
		[RED("dimension")] 
		public CInt32 Dimension
		{
			get => GetProperty(ref _dimension);
			set => SetProperty(ref _dimension, value);
		}

		[Ordinal(6)] 
		[RED("isTutorialActive")] 
		public CBool IsTutorialActive
		{
			get => GetProperty(ref _isTutorialActive);
			set => SetProperty(ref _isTutorialActive, value);
		}

		[Ordinal(7)] 
		[RED("isOfficerBreach")] 
		public CBool IsOfficerBreach
		{
			get => GetProperty(ref _isOfficerBreach);
			set => SetProperty(ref _isOfficerBreach, value);
		}

		[Ordinal(8)] 
		[RED("isRemoteBreach")] 
		public CBool IsRemoteBreach
		{
			get => GetProperty(ref _isRemoteBreach);
			set => SetProperty(ref _isRemoteBreach, value);
		}

		[Ordinal(9)] 
		[RED("isItemBreach")] 
		public CBool IsItemBreach
		{
			get => GetProperty(ref _isItemBreach);
			set => SetProperty(ref _isItemBreach, value);
		}

		[Ordinal(10)] 
		[RED("numberAttempts")] 
		public CInt32 NumberAttempts
		{
			get => GetProperty(ref _numberAttempts);
			set => SetProperty(ref _numberAttempts, value);
		}

		[Ordinal(11)] 
		[RED("tooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetProperty(ref _tooltipsManagerRef);
			set => SetProperty(ref _tooltipsManagerRef, value);
		}

		[Ordinal(12)] 
		[RED("TooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}

		[Ordinal(13)] 
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetProperty(ref _uiSystem);
			set => SetProperty(ref _uiSystem, value);
		}

		[Ordinal(14)] 
		[RED("contextHelpOverlay")] 
		public CBool ContextHelpOverlay
		{
			get => GetProperty(ref _contextHelpOverlay);
			set => SetProperty(ref _contextHelpOverlay, value);
		}

		[Ordinal(15)] 
		[RED("bbMinigame")] 
		public CWeakHandle<gameIBlackboard> BbMinigame
		{
			get => GetProperty(ref _bbMinigame);
			set => SetProperty(ref _bbMinigame, value);
		}

		[Ordinal(16)] 
		[RED("bbMinigameStateListener")] 
		public CHandle<redCallbackObject> BbMinigameStateListener
		{
			get => GetProperty(ref _bbMinigameStateListener);
			set => SetProperty(ref _bbMinigameStateListener, value);
		}

		[Ordinal(17)] 
		[RED("bbUiData")] 
		public CWeakHandle<gameIBlackboard> BbUiData
		{
			get => GetProperty(ref _bbUiData);
			set => SetProperty(ref _bbUiData, value);
		}

		[Ordinal(18)] 
		[RED("bbControllerStateListener")] 
		public CHandle<redCallbackObject> BbControllerStateListener
		{
			get => GetProperty(ref _bbControllerStateListener);
			set => SetProperty(ref _bbControllerStateListener, value);
		}
	}
}
