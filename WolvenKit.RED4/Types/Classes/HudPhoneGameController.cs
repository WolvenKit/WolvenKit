using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HudPhoneGameController : gameuiSongbirdAudioCallGameController
	{
		[Ordinal(13)] 
		[RED("isAudioCall")] 
		public CBool IsAudioCall
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("AvatarControllerRef")] 
		public inkWidgetReference AvatarControllerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("AvatarController")] 
		public CWeakHandle<HudPhoneAvatarController> AvatarController
		{
			get => GetPropertyValue<CWeakHandle<HudPhoneAvatarController>>();
			set => SetPropertyValue<CWeakHandle<HudPhoneAvatarController>>(value);
		}

		[Ordinal(16)] 
		[RED("RootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(17)] 
		[RED("Holder")] 
		public inkWidgetReference Holder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("Owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(19)] 
		[RED("CurrentFunction")] 
		public CEnum<EHudPhoneFunction> CurrentFunction
		{
			get => GetPropertyValue<CEnum<EHudPhoneFunction>>();
			set => SetPropertyValue<CEnum<EHudPhoneFunction>>(value);
		}

		[Ordinal(20)] 
		[RED("CurrentCallInformation")] 
		public questPhoneCallInformation CurrentCallInformation
		{
			get => GetPropertyValue<questPhoneCallInformation>();
			set => SetPropertyValue<questPhoneCallInformation>(value);
		}

		[Ordinal(21)] 
		[RED("CurrentPhoneCallContact")] 
		public CWeakHandle<gameJournalContact> CurrentPhoneCallContact
		{
			get => GetPropertyValue<CWeakHandle<gameJournalContact>>();
			set => SetPropertyValue<CWeakHandle<gameJournalContact>>(value);
		}

		[Ordinal(22)] 
		[RED("DelaySystem")] 
		public CWeakHandle<gameDelaySystem> DelaySystem
		{
			get => GetPropertyValue<CWeakHandle<gameDelaySystem>>();
			set => SetPropertyValue<CWeakHandle<gameDelaySystem>>(value);
		}

		[Ordinal(23)] 
		[RED("PhoneSystem")] 
		public CWeakHandle<PhoneSystem> PhoneSystem
		{
			get => GetPropertyValue<CWeakHandle<PhoneSystem>>();
			set => SetPropertyValue<CWeakHandle<PhoneSystem>>(value);
		}

		[Ordinal(24)] 
		[RED("JournalMgr")] 
		public CWeakHandle<gameJournalManager> JournalMgr
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(25)] 
		[RED("gameplayRestrictions")] 
		public CArray<CName> GameplayRestrictions
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(26)] 
		[RED("Blackboard")] 
		public CWeakHandle<gameIBlackboard> Blackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(27)] 
		[RED("BlackboardDef")] 
		public CHandle<UI_ComDeviceDef> BlackboardDef
		{
			get => GetPropertyValue<CHandle<UI_ComDeviceDef>>();
			set => SetPropertyValue<CHandle<UI_ComDeviceDef>>(value);
		}

		[Ordinal(28)] 
		[RED("CallInformationBBID")] 
		public CHandle<redCallbackObject> CallInformationBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(29)] 
		[RED("StatusNameBBID")] 
		public CHandle<redCallbackObject> StatusNameBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(30)] 
		[RED("MinimizedListener")] 
		public CHandle<redCallbackObject> MinimizedListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(31)] 
		[RED("DelayedCallbackId")] 
		public gameDelayID DelayedCallbackId
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(32)] 
		[RED("DelayedTimeoutCallbackId")] 
		public gameDelayID DelayedTimeoutCallbackId
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(33)] 
		[RED("TimeoutPeroid")] 
		public CFloat TimeoutPeroid
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(34)] 
		[RED("buttonPressed")] 
		public CBool ButtonPressed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public HudPhoneGameController()
		{
			AvatarControllerRef = new inkWidgetReference();
			Holder = new inkWidgetReference();
			CurrentCallInformation = new questPhoneCallInformation();
			GameplayRestrictions = new();
			DelayedCallbackId = new gameDelayID();
			DelayedTimeoutCallbackId = new gameDelayID();
			TimeoutPeroid = 8.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
