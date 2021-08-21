using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HudPhoneGameController : gameuiProjectedHUDGameController
	{
		private inkWidgetReference _avatarControllerRef;
		private wCHandle<HudPhoneAvatarController> _avatarController;
		private wCHandle<inkWidget> _rootWidget;
		private CName _soundNameActionOnOpen;
		private CName _soundNameActionOnClose;
		private CName _audioInitiateCallPositiveEvent;
		private CName _audioInitiateCallNegativeEvent;
		private CName _audioInitiateCallEvent;
		private CName _audioPhoneOnEvent;
		private CName _audioPhoneOffEvent;
		private inkWidgetReference _holder;
		private wCHandle<gameObject> _owner;
		private CArray<wCHandle<gameJournalPhoneMessage>> _unreadMessages;
		private CEnum<EHudPhoneFunction> _currentFunction;
		private questPhoneCallInformation _currentCallInformation;
		private wCHandle<gameJournalContact> _currentPhoneCallContact;
		private wCHandle<gameDelaySystem> _delaySystem;
		private wCHandle<PhoneSystem> _phoneSystem;
		private wCHandle<gameJournalManager> _journalMgr;
		private CArray<CName> _gameplayRestrictions;
		private wCHandle<gameIBlackboard> _blackboard;
		private CHandle<UI_ComDeviceDef> _blackboardDef;
		private CHandle<redCallbackObject> _callInformationBBID;
		private CHandle<redCallbackObject> _statusNameBBID;
		private CHandle<redCallbackObject> _minimizedListener;
		private gameDelayID _delayedCallbackId;
		private gameDelayID _delayedTimeoutCallbackId;
		private CFloat _timeoutPeroid;
		private CHandle<inkanimProxy> _portraitIntroAnim;
		private CHandle<inkanimProxy> _portraitOutroAnim;
		private CHandle<inkanimProxy> _portraitLoopAnim;
		private inkanimPlaybackOptions _options;
		private CHandle<inkScreenProjection> _updatesProjection;
		private CBool _buttonPressed;

		[Ordinal(9)] 
		[RED("AvatarControllerRef")] 
		public inkWidgetReference AvatarControllerRef
		{
			get => GetProperty(ref _avatarControllerRef);
			set => SetProperty(ref _avatarControllerRef, value);
		}

		[Ordinal(10)] 
		[RED("AvatarController")] 
		public wCHandle<HudPhoneAvatarController> AvatarController
		{
			get => GetProperty(ref _avatarController);
			set => SetProperty(ref _avatarController, value);
		}

		[Ordinal(11)] 
		[RED("RootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(12)] 
		[RED("SoundNameActionOnOpen")] 
		public CName SoundNameActionOnOpen
		{
			get => GetProperty(ref _soundNameActionOnOpen);
			set => SetProperty(ref _soundNameActionOnOpen, value);
		}

		[Ordinal(13)] 
		[RED("SoundNameActionOnClose")] 
		public CName SoundNameActionOnClose
		{
			get => GetProperty(ref _soundNameActionOnClose);
			set => SetProperty(ref _soundNameActionOnClose, value);
		}

		[Ordinal(14)] 
		[RED("AudioInitiateCallPositiveEvent")] 
		public CName AudioInitiateCallPositiveEvent
		{
			get => GetProperty(ref _audioInitiateCallPositiveEvent);
			set => SetProperty(ref _audioInitiateCallPositiveEvent, value);
		}

		[Ordinal(15)] 
		[RED("AudioInitiateCallNegativeEvent")] 
		public CName AudioInitiateCallNegativeEvent
		{
			get => GetProperty(ref _audioInitiateCallNegativeEvent);
			set => SetProperty(ref _audioInitiateCallNegativeEvent, value);
		}

		[Ordinal(16)] 
		[RED("AudioInitiateCallEvent")] 
		public CName AudioInitiateCallEvent
		{
			get => GetProperty(ref _audioInitiateCallEvent);
			set => SetProperty(ref _audioInitiateCallEvent, value);
		}

		[Ordinal(17)] 
		[RED("AudioPhoneOnEvent")] 
		public CName AudioPhoneOnEvent
		{
			get => GetProperty(ref _audioPhoneOnEvent);
			set => SetProperty(ref _audioPhoneOnEvent, value);
		}

		[Ordinal(18)] 
		[RED("AudioPhoneOffEvent")] 
		public CName AudioPhoneOffEvent
		{
			get => GetProperty(ref _audioPhoneOffEvent);
			set => SetProperty(ref _audioPhoneOffEvent, value);
		}

		[Ordinal(19)] 
		[RED("Holder")] 
		public inkWidgetReference Holder
		{
			get => GetProperty(ref _holder);
			set => SetProperty(ref _holder, value);
		}

		[Ordinal(20)] 
		[RED("Owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(21)] 
		[RED("UnreadMessages")] 
		public CArray<wCHandle<gameJournalPhoneMessage>> UnreadMessages
		{
			get => GetProperty(ref _unreadMessages);
			set => SetProperty(ref _unreadMessages, value);
		}

		[Ordinal(22)] 
		[RED("CurrentFunction")] 
		public CEnum<EHudPhoneFunction> CurrentFunction
		{
			get => GetProperty(ref _currentFunction);
			set => SetProperty(ref _currentFunction, value);
		}

		[Ordinal(23)] 
		[RED("CurrentCallInformation")] 
		public questPhoneCallInformation CurrentCallInformation
		{
			get => GetProperty(ref _currentCallInformation);
			set => SetProperty(ref _currentCallInformation, value);
		}

		[Ordinal(24)] 
		[RED("CurrentPhoneCallContact")] 
		public wCHandle<gameJournalContact> CurrentPhoneCallContact
		{
			get => GetProperty(ref _currentPhoneCallContact);
			set => SetProperty(ref _currentPhoneCallContact, value);
		}

		[Ordinal(25)] 
		[RED("DelaySystem")] 
		public wCHandle<gameDelaySystem> DelaySystem
		{
			get => GetProperty(ref _delaySystem);
			set => SetProperty(ref _delaySystem, value);
		}

		[Ordinal(26)] 
		[RED("PhoneSystem")] 
		public wCHandle<PhoneSystem> PhoneSystem
		{
			get => GetProperty(ref _phoneSystem);
			set => SetProperty(ref _phoneSystem, value);
		}

		[Ordinal(27)] 
		[RED("JournalMgr")] 
		public wCHandle<gameJournalManager> JournalMgr
		{
			get => GetProperty(ref _journalMgr);
			set => SetProperty(ref _journalMgr, value);
		}

		[Ordinal(28)] 
		[RED("gameplayRestrictions")] 
		public CArray<CName> GameplayRestrictions
		{
			get => GetProperty(ref _gameplayRestrictions);
			set => SetProperty(ref _gameplayRestrictions, value);
		}

		[Ordinal(29)] 
		[RED("Blackboard")] 
		public wCHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		[Ordinal(30)] 
		[RED("BlackboardDef")] 
		public CHandle<UI_ComDeviceDef> BlackboardDef
		{
			get => GetProperty(ref _blackboardDef);
			set => SetProperty(ref _blackboardDef, value);
		}

		[Ordinal(31)] 
		[RED("CallInformationBBID")] 
		public CHandle<redCallbackObject> CallInformationBBID
		{
			get => GetProperty(ref _callInformationBBID);
			set => SetProperty(ref _callInformationBBID, value);
		}

		[Ordinal(32)] 
		[RED("StatusNameBBID")] 
		public CHandle<redCallbackObject> StatusNameBBID
		{
			get => GetProperty(ref _statusNameBBID);
			set => SetProperty(ref _statusNameBBID, value);
		}

		[Ordinal(33)] 
		[RED("MinimizedListener")] 
		public CHandle<redCallbackObject> MinimizedListener
		{
			get => GetProperty(ref _minimizedListener);
			set => SetProperty(ref _minimizedListener, value);
		}

		[Ordinal(34)] 
		[RED("DelayedCallbackId")] 
		public gameDelayID DelayedCallbackId
		{
			get => GetProperty(ref _delayedCallbackId);
			set => SetProperty(ref _delayedCallbackId, value);
		}

		[Ordinal(35)] 
		[RED("DelayedTimeoutCallbackId")] 
		public gameDelayID DelayedTimeoutCallbackId
		{
			get => GetProperty(ref _delayedTimeoutCallbackId);
			set => SetProperty(ref _delayedTimeoutCallbackId, value);
		}

		[Ordinal(36)] 
		[RED("TimeoutPeroid")] 
		public CFloat TimeoutPeroid
		{
			get => GetProperty(ref _timeoutPeroid);
			set => SetProperty(ref _timeoutPeroid, value);
		}

		[Ordinal(37)] 
		[RED("portraitIntroAnim")] 
		public CHandle<inkanimProxy> PortraitIntroAnim
		{
			get => GetProperty(ref _portraitIntroAnim);
			set => SetProperty(ref _portraitIntroAnim, value);
		}

		[Ordinal(38)] 
		[RED("portraitOutroAnim")] 
		public CHandle<inkanimProxy> PortraitOutroAnim
		{
			get => GetProperty(ref _portraitOutroAnim);
			set => SetProperty(ref _portraitOutroAnim, value);
		}

		[Ordinal(39)] 
		[RED("portraitLoopAnim")] 
		public CHandle<inkanimProxy> PortraitLoopAnim
		{
			get => GetProperty(ref _portraitLoopAnim);
			set => SetProperty(ref _portraitLoopAnim, value);
		}

		[Ordinal(40)] 
		[RED("options")] 
		public inkanimPlaybackOptions Options
		{
			get => GetProperty(ref _options);
			set => SetProperty(ref _options, value);
		}

		[Ordinal(41)] 
		[RED("updatesProjection")] 
		public CHandle<inkScreenProjection> UpdatesProjection
		{
			get => GetProperty(ref _updatesProjection);
			set => SetProperty(ref _updatesProjection, value);
		}

		[Ordinal(42)] 
		[RED("buttonPressed")] 
		public CBool ButtonPressed
		{
			get => GetProperty(ref _buttonPressed);
			set => SetProperty(ref _buttonPressed, value);
		}

		public HudPhoneGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
