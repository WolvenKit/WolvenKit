using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HudPhoneGameController : gameuiProjectedHUDGameController
	{
		[Ordinal(9)] 
		[RED("AvatarControllerRef")] 
		public inkWidgetReference AvatarControllerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("AvatarController")] 
		public CWeakHandle<HudPhoneAvatarController> AvatarController
		{
			get => GetPropertyValue<CWeakHandle<HudPhoneAvatarController>>();
			set => SetPropertyValue<CWeakHandle<HudPhoneAvatarController>>(value);
		}

		[Ordinal(11)] 
		[RED("RootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(12)] 
		[RED("SoundNameActionOnOpen")] 
		public CName SoundNameActionOnOpen
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("SoundNameActionOnClose")] 
		public CName SoundNameActionOnClose
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(14)] 
		[RED("AudioInitiateCallPositiveEvent")] 
		public CName AudioInitiateCallPositiveEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("AudioInitiateCallNegativeEvent")] 
		public CName AudioInitiateCallNegativeEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(16)] 
		[RED("AudioInitiateCallEvent")] 
		public CName AudioInitiateCallEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(17)] 
		[RED("AudioPhoneOnEvent")] 
		public CName AudioPhoneOnEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(18)] 
		[RED("AudioPhoneOffEvent")] 
		public CName AudioPhoneOffEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(19)] 
		[RED("Holder")] 
		public inkWidgetReference Holder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("Owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(21)] 
		[RED("UnreadMessages")] 
		public CArray<CWeakHandle<gameJournalPhoneMessage>> UnreadMessages
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameJournalPhoneMessage>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameJournalPhoneMessage>>>(value);
		}

		[Ordinal(22)] 
		[RED("CurrentFunction")] 
		public CEnum<EHudPhoneFunction> CurrentFunction
		{
			get => GetPropertyValue<CEnum<EHudPhoneFunction>>();
			set => SetPropertyValue<CEnum<EHudPhoneFunction>>(value);
		}

		[Ordinal(23)] 
		[RED("CurrentCallInformation")] 
		public questPhoneCallInformation CurrentCallInformation
		{
			get => GetPropertyValue<questPhoneCallInformation>();
			set => SetPropertyValue<questPhoneCallInformation>(value);
		}

		[Ordinal(24)] 
		[RED("CurrentPhoneCallContact")] 
		public CWeakHandle<gameJournalContact> CurrentPhoneCallContact
		{
			get => GetPropertyValue<CWeakHandle<gameJournalContact>>();
			set => SetPropertyValue<CWeakHandle<gameJournalContact>>(value);
		}

		[Ordinal(25)] 
		[RED("DelaySystem")] 
		public CWeakHandle<gameDelaySystem> DelaySystem
		{
			get => GetPropertyValue<CWeakHandle<gameDelaySystem>>();
			set => SetPropertyValue<CWeakHandle<gameDelaySystem>>(value);
		}

		[Ordinal(26)] 
		[RED("PhoneSystem")] 
		public CWeakHandle<PhoneSystem> PhoneSystem
		{
			get => GetPropertyValue<CWeakHandle<PhoneSystem>>();
			set => SetPropertyValue<CWeakHandle<PhoneSystem>>(value);
		}

		[Ordinal(27)] 
		[RED("JournalMgr")] 
		public CWeakHandle<gameJournalManager> JournalMgr
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(28)] 
		[RED("gameplayRestrictions")] 
		public CArray<CName> GameplayRestrictions
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(29)] 
		[RED("Blackboard")] 
		public CWeakHandle<gameIBlackboard> Blackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(30)] 
		[RED("BlackboardDef")] 
		public CHandle<UI_ComDeviceDef> BlackboardDef
		{
			get => GetPropertyValue<CHandle<UI_ComDeviceDef>>();
			set => SetPropertyValue<CHandle<UI_ComDeviceDef>>(value);
		}

		[Ordinal(31)] 
		[RED("CallInformationBBID")] 
		public CHandle<redCallbackObject> CallInformationBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(32)] 
		[RED("StatusNameBBID")] 
		public CHandle<redCallbackObject> StatusNameBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(33)] 
		[RED("MinimizedListener")] 
		public CHandle<redCallbackObject> MinimizedListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(34)] 
		[RED("DelayedCallbackId")] 
		public gameDelayID DelayedCallbackId
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(35)] 
		[RED("DelayedTimeoutCallbackId")] 
		public gameDelayID DelayedTimeoutCallbackId
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(36)] 
		[RED("TimeoutPeroid")] 
		public CFloat TimeoutPeroid
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(37)] 
		[RED("portraitIntroAnim")] 
		public CHandle<inkanimProxy> PortraitIntroAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(38)] 
		[RED("portraitOutroAnim")] 
		public CHandle<inkanimProxy> PortraitOutroAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(39)] 
		[RED("portraitLoopAnim")] 
		public CHandle<inkanimProxy> PortraitLoopAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(40)] 
		[RED("options")] 
		public inkanimPlaybackOptions Options
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		[Ordinal(41)] 
		[RED("updatesProjection")] 
		public CHandle<inkScreenProjection> UpdatesProjection
		{
			get => GetPropertyValue<CHandle<inkScreenProjection>>();
			set => SetPropertyValue<CHandle<inkScreenProjection>>(value);
		}

		[Ordinal(42)] 
		[RED("buttonPressed")] 
		public CBool ButtonPressed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public HudPhoneGameController()
		{
			AvatarControllerRef = new();
			SoundNameActionOnOpen = "OnOpen";
			SoundNameActionOnClose = "OnOpen";
			AudioInitiateCallPositiveEvent = "PhoneCallPopup";
			AudioInitiateCallNegativeEvent = "PhoneCallPopup";
			AudioInitiateCallEvent = "PhoneCallPopup";
			AudioPhoneOnEvent = "PhoneCallPopup";
			AudioPhoneOffEvent = "PhoneCallPopup";
			Holder = new();
			UnreadMessages = new();
			CurrentCallInformation = new();
			GameplayRestrictions = new();
			DelayedCallbackId = new();
			DelayedTimeoutCallbackId = new();
			TimeoutPeroid = 8.000000F;
			Options = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
