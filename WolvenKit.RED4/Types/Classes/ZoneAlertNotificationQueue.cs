using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ZoneAlertNotificationQueue : gameuiGenericNotificationGameController
	{
		[Ordinal(4)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("securityBlackBoardID")] 
		public CHandle<redCallbackObject> SecurityBlackBoardID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(6)] 
		[RED("combatBlackBoardID")] 
		public CHandle<redCallbackObject> CombatBlackBoardID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(7)] 
		[RED("wantedValueBlackboardID")] 
		public CHandle<redCallbackObject> WantedValueBlackboardID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(8)] 
		[RED("playerBlackboardID")] 
		public CHandle<redCallbackObject> PlayerBlackboardID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(9)] 
		[RED("blackboard")] 
		public CWeakHandle<gameIBlackboard> Blackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(10)] 
		[RED("wantedBlackboard")] 
		public CWeakHandle<gameIBlackboard> WantedBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(11)] 
		[RED("wantedBlackboardDef")] 
		public CHandle<UI_WantedBarDef> WantedBlackboardDef
		{
			get => GetPropertyValue<CHandle<UI_WantedBarDef>>();
			set => SetPropertyValue<CHandle<UI_WantedBarDef>>(value);
		}

		[Ordinal(12)] 
		[RED("playerInCombat")] 
		public CBool PlayerInCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("playerPuppet")] 
		public CWeakHandle<gameObject> PlayerPuppet
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(14)] 
		[RED("currentSecurityZoneType")] 
		public CEnum<ESecurityAreaType> CurrentSecurityZoneType
		{
			get => GetPropertyValue<CEnum<ESecurityAreaType>>();
			set => SetPropertyValue<CEnum<ESecurityAreaType>>(value);
		}

		[Ordinal(15)] 
		[RED("vehicleZoneBlackboard")] 
		public CWeakHandle<gameIBlackboard> VehicleZoneBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(16)] 
		[RED("vehicleZoneBlackboardDef")] 
		public CHandle<LocalPlayerDef> VehicleZoneBlackboardDef
		{
			get => GetPropertyValue<CHandle<LocalPlayerDef>>();
			set => SetPropertyValue<CHandle<LocalPlayerDef>>(value);
		}

		[Ordinal(17)] 
		[RED("vehicleZoneBlackboardID")] 
		public CHandle<redCallbackObject> VehicleZoneBlackboardID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(18)] 
		[RED("WANTED_TIER_SIZE")] 
		public CInt32 WANTED_TIER_SIZE
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(19)] 
		[RED("wantedLevel")] 
		public CInt32 WantedLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(20)] 
		[RED("factListenerID")] 
		public CUInt32 FactListenerID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public ZoneAlertNotificationQueue()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
