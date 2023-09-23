using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PhoneSystem : gameScriptableSystem
	{
		[Ordinal(0)] 
		[RED("BlackboardSystem")] 
		public CHandle<gameBlackboardSystem> BlackboardSystem
		{
			get => GetPropertyValue<CHandle<gameBlackboardSystem>>();
			set => SetPropertyValue<CHandle<gameBlackboardSystem>>(value);
		}

		[Ordinal(1)] 
		[RED("Blackboard")] 
		public CWeakHandle<gameIBlackboard> Blackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(2)] 
		[RED("PsmBlackboard")] 
		public CWeakHandle<gameIBlackboard> PsmBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(3)] 
		[RED("LastCallInformation")] 
		public questPhoneCallInformation LastCallInformation
		{
			get => GetPropertyValue<questPhoneCallInformation>();
			set => SetPropertyValue<questPhoneCallInformation>(value);
		}

		[Ordinal(4)] 
		[RED("StatusEffectsListener")] 
		public CHandle<PhoneStatusEffectListener> StatusEffectsListener
		{
			get => GetPropertyValue<CHandle<PhoneStatusEffectListener>>();
			set => SetPropertyValue<CHandle<PhoneStatusEffectListener>>(value);
		}

		[Ordinal(5)] 
		[RED("StatsListener")] 
		public CHandle<PhoneStatsListener> StatsListener
		{
			get => GetPropertyValue<CHandle<PhoneStatsListener>>();
			set => SetPropertyValue<CHandle<PhoneStatsListener>>(value);
		}

		[Ordinal(6)] 
		[RED("ContactsOpen")] 
		public CBool ContactsOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("PhoneVisibilityBBId")] 
		public CHandle<redCallbackObject> PhoneVisibilityBBId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(8)] 
		[RED("ContactsOpenBBId")] 
		public CHandle<redCallbackObject> ContactsOpenBBId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(9)] 
		[RED("HighLevelBBId")] 
		public CHandle<redCallbackObject> HighLevelBBId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(10)] 
		[RED("CombatBBId")] 
		public CHandle<redCallbackObject> CombatBBId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(11)] 
		[RED("SwimmingBBId")] 
		public CHandle<redCallbackObject> SwimmingBBId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(12)] 
		[RED("IsContrDeviceBBId")] 
		public CHandle<redCallbackObject> IsContrDeviceBBId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(13)] 
		[RED("IsUIZoomDeviceBBId")] 
		public CHandle<redCallbackObject> IsUIZoomDeviceBBId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(14)] 
		[RED("PlayerAttachedCallbackID")] 
		public CUInt32 PlayerAttachedCallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(15)] 
		[RED("PlayerDetachedCallbackID")] 
		public CUInt32 PlayerDetachedCallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public PhoneSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
