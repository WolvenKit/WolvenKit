using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interactionWidgetGameController : gameuiHUDGameController
	{
		private wCHandle<inkWidget> _root;
		private wCHandle<inkTextWidget> _titleLabel;
		private wCHandle<inkWidget> _titleBorder;
		private wCHandle<inkHorizontalPanelWidget> _optionsList;
		private CArray<wCHandle<inkWidget>> _widgetsPool;
		private CArray<CHandle<redCallbackObject>> _widgetsCallbacks;
		private wCHandle<gameIBlackboard> _bbInteraction;
		private wCHandle<gameIBlackboard> _bbPlayerStateMachine;
		private CHandle<UIInteractionsDef> _bbInteractionDefinition;
		private CHandle<redCallbackObject> _updateInteractionId;
		private CHandle<redCallbackObject> _activeHubListenerId;
		private CHandle<redCallbackObject> _contactsActiveListenerId;
		private CInt32 _id;
		private CBool _isActive;
		private CBool _areContactsOpen;
		private inkWidgetReference _progressBarHolder;
		private wCHandle<DialogChoiceTimerController> _progressBar;
		private CBool _hasProgressBar;
		private wCHandle<gameIBlackboard> _bb;
		private CHandle<UIInteractionsDef> _bbUIInteractionsDef;
		private CHandle<redCallbackObject> _bbLastAttemptedChoiceCallbackId;
		private CHandle<redCallbackObject> _onZoneChangeCallback;
		private CInt32 _pendingRequests;
		private CArray<wCHandle<inkAsyncSpawnRequest>> _spawnTokens;
		private CArray<gameinteractionsvisInteractionChoiceData> _currentOptions;

		[Ordinal(9)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(10)] 
		[RED("titleLabel")] 
		public wCHandle<inkTextWidget> TitleLabel
		{
			get => GetProperty(ref _titleLabel);
			set => SetProperty(ref _titleLabel, value);
		}

		[Ordinal(11)] 
		[RED("titleBorder")] 
		public wCHandle<inkWidget> TitleBorder
		{
			get => GetProperty(ref _titleBorder);
			set => SetProperty(ref _titleBorder, value);
		}

		[Ordinal(12)] 
		[RED("optionsList")] 
		public wCHandle<inkHorizontalPanelWidget> OptionsList
		{
			get => GetProperty(ref _optionsList);
			set => SetProperty(ref _optionsList, value);
		}

		[Ordinal(13)] 
		[RED("widgetsPool")] 
		public CArray<wCHandle<inkWidget>> WidgetsPool
		{
			get => GetProperty(ref _widgetsPool);
			set => SetProperty(ref _widgetsPool, value);
		}

		[Ordinal(14)] 
		[RED("widgetsCallbacks")] 
		public CArray<CHandle<redCallbackObject>> WidgetsCallbacks
		{
			get => GetProperty(ref _widgetsCallbacks);
			set => SetProperty(ref _widgetsCallbacks, value);
		}

		[Ordinal(15)] 
		[RED("bbInteraction")] 
		public wCHandle<gameIBlackboard> BbInteraction
		{
			get => GetProperty(ref _bbInteraction);
			set => SetProperty(ref _bbInteraction, value);
		}

		[Ordinal(16)] 
		[RED("bbPlayerStateMachine")] 
		public wCHandle<gameIBlackboard> BbPlayerStateMachine
		{
			get => GetProperty(ref _bbPlayerStateMachine);
			set => SetProperty(ref _bbPlayerStateMachine, value);
		}

		[Ordinal(17)] 
		[RED("bbInteractionDefinition")] 
		public CHandle<UIInteractionsDef> BbInteractionDefinition
		{
			get => GetProperty(ref _bbInteractionDefinition);
			set => SetProperty(ref _bbInteractionDefinition, value);
		}

		[Ordinal(18)] 
		[RED("updateInteractionId")] 
		public CHandle<redCallbackObject> UpdateInteractionId
		{
			get => GetProperty(ref _updateInteractionId);
			set => SetProperty(ref _updateInteractionId, value);
		}

		[Ordinal(19)] 
		[RED("activeHubListenerId")] 
		public CHandle<redCallbackObject> ActiveHubListenerId
		{
			get => GetProperty(ref _activeHubListenerId);
			set => SetProperty(ref _activeHubListenerId, value);
		}

		[Ordinal(20)] 
		[RED("contactsActiveListenerId")] 
		public CHandle<redCallbackObject> ContactsActiveListenerId
		{
			get => GetProperty(ref _contactsActiveListenerId);
			set => SetProperty(ref _contactsActiveListenerId, value);
		}

		[Ordinal(21)] 
		[RED("id")] 
		public CInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(22)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(23)] 
		[RED("areContactsOpen")] 
		public CBool AreContactsOpen
		{
			get => GetProperty(ref _areContactsOpen);
			set => SetProperty(ref _areContactsOpen, value);
		}

		[Ordinal(24)] 
		[RED("progressBarHolder")] 
		public inkWidgetReference ProgressBarHolder
		{
			get => GetProperty(ref _progressBarHolder);
			set => SetProperty(ref _progressBarHolder, value);
		}

		[Ordinal(25)] 
		[RED("progressBar")] 
		public wCHandle<DialogChoiceTimerController> ProgressBar
		{
			get => GetProperty(ref _progressBar);
			set => SetProperty(ref _progressBar, value);
		}

		[Ordinal(26)] 
		[RED("hasProgressBar")] 
		public CBool HasProgressBar
		{
			get => GetProperty(ref _hasProgressBar);
			set => SetProperty(ref _hasProgressBar, value);
		}

		[Ordinal(27)] 
		[RED("bb")] 
		public wCHandle<gameIBlackboard> Bb
		{
			get => GetProperty(ref _bb);
			set => SetProperty(ref _bb, value);
		}

		[Ordinal(28)] 
		[RED("bbUIInteractionsDef")] 
		public CHandle<UIInteractionsDef> BbUIInteractionsDef
		{
			get => GetProperty(ref _bbUIInteractionsDef);
			set => SetProperty(ref _bbUIInteractionsDef, value);
		}

		[Ordinal(29)] 
		[RED("bbLastAttemptedChoiceCallbackId")] 
		public CHandle<redCallbackObject> BbLastAttemptedChoiceCallbackId
		{
			get => GetProperty(ref _bbLastAttemptedChoiceCallbackId);
			set => SetProperty(ref _bbLastAttemptedChoiceCallbackId, value);
		}

		[Ordinal(30)] 
		[RED("OnZoneChangeCallback")] 
		public CHandle<redCallbackObject> OnZoneChangeCallback
		{
			get => GetProperty(ref _onZoneChangeCallback);
			set => SetProperty(ref _onZoneChangeCallback, value);
		}

		[Ordinal(31)] 
		[RED("pendingRequests")] 
		public CInt32 PendingRequests
		{
			get => GetProperty(ref _pendingRequests);
			set => SetProperty(ref _pendingRequests, value);
		}

		[Ordinal(32)] 
		[RED("spawnTokens")] 
		public CArray<wCHandle<inkAsyncSpawnRequest>> SpawnTokens
		{
			get => GetProperty(ref _spawnTokens);
			set => SetProperty(ref _spawnTokens, value);
		}

		[Ordinal(33)] 
		[RED("currentOptions")] 
		public CArray<gameinteractionsvisInteractionChoiceData> CurrentOptions
		{
			get => GetProperty(ref _currentOptions);
			set => SetProperty(ref _currentOptions, value);
		}

		public interactionWidgetGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
