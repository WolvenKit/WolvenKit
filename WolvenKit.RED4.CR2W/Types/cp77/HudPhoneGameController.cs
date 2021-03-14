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
		private CUInt32 _callInformationBBID;
		private CUInt32 _statusNameBBID;
		private CUInt32 _minimizedListener;
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
			get
			{
				if (_avatarControllerRef == null)
				{
					_avatarControllerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "AvatarControllerRef", cr2w, this);
				}
				return _avatarControllerRef;
			}
			set
			{
				if (_avatarControllerRef == value)
				{
					return;
				}
				_avatarControllerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("AvatarController")] 
		public wCHandle<HudPhoneAvatarController> AvatarController
		{
			get
			{
				if (_avatarController == null)
				{
					_avatarController = (wCHandle<HudPhoneAvatarController>) CR2WTypeManager.Create("whandle:HudPhoneAvatarController", "AvatarController", cr2w, this);
				}
				return _avatarController;
			}
			set
			{
				if (_avatarController == value)
				{
					return;
				}
				_avatarController = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("RootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get
			{
				if (_rootWidget == null)
				{
					_rootWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "RootWidget", cr2w, this);
				}
				return _rootWidget;
			}
			set
			{
				if (_rootWidget == value)
				{
					return;
				}
				_rootWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("SoundNameActionOnOpen")] 
		public CName SoundNameActionOnOpen
		{
			get
			{
				if (_soundNameActionOnOpen == null)
				{
					_soundNameActionOnOpen = (CName) CR2WTypeManager.Create("CName", "SoundNameActionOnOpen", cr2w, this);
				}
				return _soundNameActionOnOpen;
			}
			set
			{
				if (_soundNameActionOnOpen == value)
				{
					return;
				}
				_soundNameActionOnOpen = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("SoundNameActionOnClose")] 
		public CName SoundNameActionOnClose
		{
			get
			{
				if (_soundNameActionOnClose == null)
				{
					_soundNameActionOnClose = (CName) CR2WTypeManager.Create("CName", "SoundNameActionOnClose", cr2w, this);
				}
				return _soundNameActionOnClose;
			}
			set
			{
				if (_soundNameActionOnClose == value)
				{
					return;
				}
				_soundNameActionOnClose = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("AudioInitiateCallPositiveEvent")] 
		public CName AudioInitiateCallPositiveEvent
		{
			get
			{
				if (_audioInitiateCallPositiveEvent == null)
				{
					_audioInitiateCallPositiveEvent = (CName) CR2WTypeManager.Create("CName", "AudioInitiateCallPositiveEvent", cr2w, this);
				}
				return _audioInitiateCallPositiveEvent;
			}
			set
			{
				if (_audioInitiateCallPositiveEvent == value)
				{
					return;
				}
				_audioInitiateCallPositiveEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("AudioInitiateCallNegativeEvent")] 
		public CName AudioInitiateCallNegativeEvent
		{
			get
			{
				if (_audioInitiateCallNegativeEvent == null)
				{
					_audioInitiateCallNegativeEvent = (CName) CR2WTypeManager.Create("CName", "AudioInitiateCallNegativeEvent", cr2w, this);
				}
				return _audioInitiateCallNegativeEvent;
			}
			set
			{
				if (_audioInitiateCallNegativeEvent == value)
				{
					return;
				}
				_audioInitiateCallNegativeEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("AudioInitiateCallEvent")] 
		public CName AudioInitiateCallEvent
		{
			get
			{
				if (_audioInitiateCallEvent == null)
				{
					_audioInitiateCallEvent = (CName) CR2WTypeManager.Create("CName", "AudioInitiateCallEvent", cr2w, this);
				}
				return _audioInitiateCallEvent;
			}
			set
			{
				if (_audioInitiateCallEvent == value)
				{
					return;
				}
				_audioInitiateCallEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("AudioPhoneOnEvent")] 
		public CName AudioPhoneOnEvent
		{
			get
			{
				if (_audioPhoneOnEvent == null)
				{
					_audioPhoneOnEvent = (CName) CR2WTypeManager.Create("CName", "AudioPhoneOnEvent", cr2w, this);
				}
				return _audioPhoneOnEvent;
			}
			set
			{
				if (_audioPhoneOnEvent == value)
				{
					return;
				}
				_audioPhoneOnEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("AudioPhoneOffEvent")] 
		public CName AudioPhoneOffEvent
		{
			get
			{
				if (_audioPhoneOffEvent == null)
				{
					_audioPhoneOffEvent = (CName) CR2WTypeManager.Create("CName", "AudioPhoneOffEvent", cr2w, this);
				}
				return _audioPhoneOffEvent;
			}
			set
			{
				if (_audioPhoneOffEvent == value)
				{
					return;
				}
				_audioPhoneOffEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("Holder")] 
		public inkWidgetReference Holder
		{
			get
			{
				if (_holder == null)
				{
					_holder = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "Holder", cr2w, this);
				}
				return _holder;
			}
			set
			{
				if (_holder == value)
				{
					return;
				}
				_holder = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("Owner")] 
		public wCHandle<gameObject> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "Owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("UnreadMessages")] 
		public CArray<wCHandle<gameJournalPhoneMessage>> UnreadMessages
		{
			get
			{
				if (_unreadMessages == null)
				{
					_unreadMessages = (CArray<wCHandle<gameJournalPhoneMessage>>) CR2WTypeManager.Create("array:whandle:gameJournalPhoneMessage", "UnreadMessages", cr2w, this);
				}
				return _unreadMessages;
			}
			set
			{
				if (_unreadMessages == value)
				{
					return;
				}
				_unreadMessages = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("CurrentFunction")] 
		public CEnum<EHudPhoneFunction> CurrentFunction
		{
			get
			{
				if (_currentFunction == null)
				{
					_currentFunction = (CEnum<EHudPhoneFunction>) CR2WTypeManager.Create("EHudPhoneFunction", "CurrentFunction", cr2w, this);
				}
				return _currentFunction;
			}
			set
			{
				if (_currentFunction == value)
				{
					return;
				}
				_currentFunction = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("CurrentCallInformation")] 
		public questPhoneCallInformation CurrentCallInformation
		{
			get
			{
				if (_currentCallInformation == null)
				{
					_currentCallInformation = (questPhoneCallInformation) CR2WTypeManager.Create("questPhoneCallInformation", "CurrentCallInformation", cr2w, this);
				}
				return _currentCallInformation;
			}
			set
			{
				if (_currentCallInformation == value)
				{
					return;
				}
				_currentCallInformation = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("CurrentPhoneCallContact")] 
		public wCHandle<gameJournalContact> CurrentPhoneCallContact
		{
			get
			{
				if (_currentPhoneCallContact == null)
				{
					_currentPhoneCallContact = (wCHandle<gameJournalContact>) CR2WTypeManager.Create("whandle:gameJournalContact", "CurrentPhoneCallContact", cr2w, this);
				}
				return _currentPhoneCallContact;
			}
			set
			{
				if (_currentPhoneCallContact == value)
				{
					return;
				}
				_currentPhoneCallContact = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("DelaySystem")] 
		public wCHandle<gameDelaySystem> DelaySystem
		{
			get
			{
				if (_delaySystem == null)
				{
					_delaySystem = (wCHandle<gameDelaySystem>) CR2WTypeManager.Create("whandle:gameDelaySystem", "DelaySystem", cr2w, this);
				}
				return _delaySystem;
			}
			set
			{
				if (_delaySystem == value)
				{
					return;
				}
				_delaySystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("PhoneSystem")] 
		public wCHandle<PhoneSystem> PhoneSystem
		{
			get
			{
				if (_phoneSystem == null)
				{
					_phoneSystem = (wCHandle<PhoneSystem>) CR2WTypeManager.Create("whandle:PhoneSystem", "PhoneSystem", cr2w, this);
				}
				return _phoneSystem;
			}
			set
			{
				if (_phoneSystem == value)
				{
					return;
				}
				_phoneSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("JournalMgr")] 
		public wCHandle<gameJournalManager> JournalMgr
		{
			get
			{
				if (_journalMgr == null)
				{
					_journalMgr = (wCHandle<gameJournalManager>) CR2WTypeManager.Create("whandle:gameJournalManager", "JournalMgr", cr2w, this);
				}
				return _journalMgr;
			}
			set
			{
				if (_journalMgr == value)
				{
					return;
				}
				_journalMgr = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("gameplayRestrictions")] 
		public CArray<CName> GameplayRestrictions
		{
			get
			{
				if (_gameplayRestrictions == null)
				{
					_gameplayRestrictions = (CArray<CName>) CR2WTypeManager.Create("array:CName", "gameplayRestrictions", cr2w, this);
				}
				return _gameplayRestrictions;
			}
			set
			{
				if (_gameplayRestrictions == value)
				{
					return;
				}
				_gameplayRestrictions = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("Blackboard")] 
		public wCHandle<gameIBlackboard> Blackboard
		{
			get
			{
				if (_blackboard == null)
				{
					_blackboard = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "Blackboard", cr2w, this);
				}
				return _blackboard;
			}
			set
			{
				if (_blackboard == value)
				{
					return;
				}
				_blackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("BlackboardDef")] 
		public CHandle<UI_ComDeviceDef> BlackboardDef
		{
			get
			{
				if (_blackboardDef == null)
				{
					_blackboardDef = (CHandle<UI_ComDeviceDef>) CR2WTypeManager.Create("handle:UI_ComDeviceDef", "BlackboardDef", cr2w, this);
				}
				return _blackboardDef;
			}
			set
			{
				if (_blackboardDef == value)
				{
					return;
				}
				_blackboardDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("CallInformationBBID")] 
		public CUInt32 CallInformationBBID
		{
			get
			{
				if (_callInformationBBID == null)
				{
					_callInformationBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "CallInformationBBID", cr2w, this);
				}
				return _callInformationBBID;
			}
			set
			{
				if (_callInformationBBID == value)
				{
					return;
				}
				_callInformationBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("StatusNameBBID")] 
		public CUInt32 StatusNameBBID
		{
			get
			{
				if (_statusNameBBID == null)
				{
					_statusNameBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "StatusNameBBID", cr2w, this);
				}
				return _statusNameBBID;
			}
			set
			{
				if (_statusNameBBID == value)
				{
					return;
				}
				_statusNameBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("MinimizedListener")] 
		public CUInt32 MinimizedListener
		{
			get
			{
				if (_minimizedListener == null)
				{
					_minimizedListener = (CUInt32) CR2WTypeManager.Create("Uint32", "MinimizedListener", cr2w, this);
				}
				return _minimizedListener;
			}
			set
			{
				if (_minimizedListener == value)
				{
					return;
				}
				_minimizedListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("DelayedCallbackId")] 
		public gameDelayID DelayedCallbackId
		{
			get
			{
				if (_delayedCallbackId == null)
				{
					_delayedCallbackId = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "DelayedCallbackId", cr2w, this);
				}
				return _delayedCallbackId;
			}
			set
			{
				if (_delayedCallbackId == value)
				{
					return;
				}
				_delayedCallbackId = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("DelayedTimeoutCallbackId")] 
		public gameDelayID DelayedTimeoutCallbackId
		{
			get
			{
				if (_delayedTimeoutCallbackId == null)
				{
					_delayedTimeoutCallbackId = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "DelayedTimeoutCallbackId", cr2w, this);
				}
				return _delayedTimeoutCallbackId;
			}
			set
			{
				if (_delayedTimeoutCallbackId == value)
				{
					return;
				}
				_delayedTimeoutCallbackId = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("TimeoutPeroid")] 
		public CFloat TimeoutPeroid
		{
			get
			{
				if (_timeoutPeroid == null)
				{
					_timeoutPeroid = (CFloat) CR2WTypeManager.Create("Float", "TimeoutPeroid", cr2w, this);
				}
				return _timeoutPeroid;
			}
			set
			{
				if (_timeoutPeroid == value)
				{
					return;
				}
				_timeoutPeroid = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("portraitIntroAnim")] 
		public CHandle<inkanimProxy> PortraitIntroAnim
		{
			get
			{
				if (_portraitIntroAnim == null)
				{
					_portraitIntroAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "portraitIntroAnim", cr2w, this);
				}
				return _portraitIntroAnim;
			}
			set
			{
				if (_portraitIntroAnim == value)
				{
					return;
				}
				_portraitIntroAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("portraitOutroAnim")] 
		public CHandle<inkanimProxy> PortraitOutroAnim
		{
			get
			{
				if (_portraitOutroAnim == null)
				{
					_portraitOutroAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "portraitOutroAnim", cr2w, this);
				}
				return _portraitOutroAnim;
			}
			set
			{
				if (_portraitOutroAnim == value)
				{
					return;
				}
				_portraitOutroAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("portraitLoopAnim")] 
		public CHandle<inkanimProxy> PortraitLoopAnim
		{
			get
			{
				if (_portraitLoopAnim == null)
				{
					_portraitLoopAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "portraitLoopAnim", cr2w, this);
				}
				return _portraitLoopAnim;
			}
			set
			{
				if (_portraitLoopAnim == value)
				{
					return;
				}
				_portraitLoopAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("options")] 
		public inkanimPlaybackOptions Options
		{
			get
			{
				if (_options == null)
				{
					_options = (inkanimPlaybackOptions) CR2WTypeManager.Create("inkanimPlaybackOptions", "options", cr2w, this);
				}
				return _options;
			}
			set
			{
				if (_options == value)
				{
					return;
				}
				_options = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("updatesProjection")] 
		public CHandle<inkScreenProjection> UpdatesProjection
		{
			get
			{
				if (_updatesProjection == null)
				{
					_updatesProjection = (CHandle<inkScreenProjection>) CR2WTypeManager.Create("handle:inkScreenProjection", "updatesProjection", cr2w, this);
				}
				return _updatesProjection;
			}
			set
			{
				if (_updatesProjection == value)
				{
					return;
				}
				_updatesProjection = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("buttonPressed")] 
		public CBool ButtonPressed
		{
			get
			{
				if (_buttonPressed == null)
				{
					_buttonPressed = (CBool) CR2WTypeManager.Create("Bool", "buttonPressed", cr2w, this);
				}
				return _buttonPressed;
			}
			set
			{
				if (_buttonPressed == value)
				{
					return;
				}
				_buttonPressed = value;
				PropertySet(this);
			}
		}

		public HudPhoneGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
