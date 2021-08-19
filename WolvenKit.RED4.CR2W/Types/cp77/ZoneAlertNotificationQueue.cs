using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ZoneAlertNotificationQueue : gameuiGenericNotificationGameController
	{
		private CFloat _duration;
		private CHandle<redCallbackObject> _securityBlackBoardID;
		private CHandle<redCallbackObject> _combatBlackBoardID;
		private CHandle<redCallbackObject> _wantedValueBlackboardID;
		private CHandle<redCallbackObject> _bountyAmountBlackboardID;
		private CHandle<redCallbackObject> _playerBlackboardID;
		private wCHandle<gameIBlackboard> _blackboard;
		private CInt32 _bountyPrice;
		private wCHandle<gameIBlackboard> _wantedBlackboard;
		private CHandle<UI_WantedBarDef> _wantedBlackboardDef;
		private CBool _playerInCombat;
		private wCHandle<gameObject> _playerPuppet;
		private CEnum<ESecurityAreaType> _currentSecurityZoneType;
		private wCHandle<gameIBlackboard> _vehicleZoneBlackboard;
		private CHandle<LocalPlayerDef> _vehicleZoneBlackboardDef;
		private CHandle<redCallbackObject> _vehicleZoneBlackboardID;
		private CInt32 _wANTED_TIER_SIZE;
		private CInt32 _wantedLevel;
		private CUInt32 _factListenerID;

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(3)] 
		[RED("securityBlackBoardID")] 
		public CHandle<redCallbackObject> SecurityBlackBoardID
		{
			get => GetProperty(ref _securityBlackBoardID);
			set => SetProperty(ref _securityBlackBoardID, value);
		}

		[Ordinal(4)] 
		[RED("combatBlackBoardID")] 
		public CHandle<redCallbackObject> CombatBlackBoardID
		{
			get => GetProperty(ref _combatBlackBoardID);
			set => SetProperty(ref _combatBlackBoardID, value);
		}

		[Ordinal(5)] 
		[RED("wantedValueBlackboardID")] 
		public CHandle<redCallbackObject> WantedValueBlackboardID
		{
			get => GetProperty(ref _wantedValueBlackboardID);
			set => SetProperty(ref _wantedValueBlackboardID, value);
		}

		[Ordinal(6)] 
		[RED("bountyAmountBlackboardID")] 
		public CHandle<redCallbackObject> BountyAmountBlackboardID
		{
			get => GetProperty(ref _bountyAmountBlackboardID);
			set => SetProperty(ref _bountyAmountBlackboardID, value);
		}

		[Ordinal(7)] 
		[RED("playerBlackboardID")] 
		public CHandle<redCallbackObject> PlayerBlackboardID
		{
			get => GetProperty(ref _playerBlackboardID);
			set => SetProperty(ref _playerBlackboardID, value);
		}

		[Ordinal(8)] 
		[RED("blackboard")] 
		public wCHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		[Ordinal(9)] 
		[RED("bountyPrice")] 
		public CInt32 BountyPrice
		{
			get => GetProperty(ref _bountyPrice);
			set => SetProperty(ref _bountyPrice, value);
		}

		[Ordinal(10)] 
		[RED("wantedBlackboard")] 
		public wCHandle<gameIBlackboard> WantedBlackboard
		{
			get => GetProperty(ref _wantedBlackboard);
			set => SetProperty(ref _wantedBlackboard, value);
		}

		[Ordinal(11)] 
		[RED("wantedBlackboardDef")] 
		public CHandle<UI_WantedBarDef> WantedBlackboardDef
		{
			get => GetProperty(ref _wantedBlackboardDef);
			set => SetProperty(ref _wantedBlackboardDef, value);
		}

		[Ordinal(12)] 
		[RED("playerInCombat")] 
		public CBool PlayerInCombat
		{
			get => GetProperty(ref _playerInCombat);
			set => SetProperty(ref _playerInCombat, value);
		}

		[Ordinal(13)] 
		[RED("playerPuppet")] 
		public wCHandle<gameObject> PlayerPuppet
		{
			get => GetProperty(ref _playerPuppet);
			set => SetProperty(ref _playerPuppet, value);
		}

		[Ordinal(14)] 
		[RED("currentSecurityZoneType")] 
		public CEnum<ESecurityAreaType> CurrentSecurityZoneType
		{
			get => GetProperty(ref _currentSecurityZoneType);
			set => SetProperty(ref _currentSecurityZoneType, value);
		}

		[Ordinal(15)] 
		[RED("vehicleZoneBlackboard")] 
		public wCHandle<gameIBlackboard> VehicleZoneBlackboard
		{
			get => GetProperty(ref _vehicleZoneBlackboard);
			set => SetProperty(ref _vehicleZoneBlackboard, value);
		}

		[Ordinal(16)] 
		[RED("vehicleZoneBlackboardDef")] 
		public CHandle<LocalPlayerDef> VehicleZoneBlackboardDef
		{
			get => GetProperty(ref _vehicleZoneBlackboardDef);
			set => SetProperty(ref _vehicleZoneBlackboardDef, value);
		}

		[Ordinal(17)] 
		[RED("vehicleZoneBlackboardID")] 
		public CHandle<redCallbackObject> VehicleZoneBlackboardID
		{
			get => GetProperty(ref _vehicleZoneBlackboardID);
			set => SetProperty(ref _vehicleZoneBlackboardID, value);
		}

		[Ordinal(18)] 
		[RED("WANTED_TIER_SIZE")] 
		public CInt32 WANTED_TIER_SIZE
		{
			get => GetProperty(ref _wANTED_TIER_SIZE);
			set => SetProperty(ref _wANTED_TIER_SIZE, value);
		}

		[Ordinal(19)] 
		[RED("wantedLevel")] 
		public CInt32 WantedLevel
		{
			get => GetProperty(ref _wantedLevel);
			set => SetProperty(ref _wantedLevel, value);
		}

		[Ordinal(20)] 
		[RED("factListenerID")] 
		public CUInt32 FactListenerID
		{
			get => GetProperty(ref _factListenerID);
			set => SetProperty(ref _factListenerID, value);
		}

		public ZoneAlertNotificationQueue(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
