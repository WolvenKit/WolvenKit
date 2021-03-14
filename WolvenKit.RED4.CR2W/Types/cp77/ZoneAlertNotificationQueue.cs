using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ZoneAlertNotificationQueue : gameuiGenericNotificationGameController
	{
		private CFloat _duration;
		private CUInt32 _securityBlackBoardID;
		private CUInt32 _combatBlackBoardID;
		private CUInt32 _wantedValueBlackboardID;
		private CUInt32 _bountyAmountBlackboardID;
		private CUInt32 _playerBlackboardID;
		private CHandle<gameIBlackboard> _blackboard;
		private CInt32 _bountyPrice;
		private CHandle<gameIBlackboard> _wantedBlackboard;
		private CHandle<UI_WantedBarDef> _wantedBlackboardDef;
		private CBool _playerInCombat;
		private wCHandle<gameObject> _playerPuppet;
		private CEnum<ESecurityAreaType> _currentSecurityZoneType;
		private CHandle<gameIBlackboard> _vehicleZoneBlackboard;
		private CHandle<LocalPlayerDef> _vehicleZoneBlackboardDef;
		private CUInt32 _vehicleZoneBlackboardID;
		private CInt32 _wANTED_TIER_SIZE;
		private CInt32 _wantedLevel;
		private CUInt32 _factListenerID;

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("securityBlackBoardID")] 
		public CUInt32 SecurityBlackBoardID
		{
			get
			{
				if (_securityBlackBoardID == null)
				{
					_securityBlackBoardID = (CUInt32) CR2WTypeManager.Create("Uint32", "securityBlackBoardID", cr2w, this);
				}
				return _securityBlackBoardID;
			}
			set
			{
				if (_securityBlackBoardID == value)
				{
					return;
				}
				_securityBlackBoardID = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("combatBlackBoardID")] 
		public CUInt32 CombatBlackBoardID
		{
			get
			{
				if (_combatBlackBoardID == null)
				{
					_combatBlackBoardID = (CUInt32) CR2WTypeManager.Create("Uint32", "combatBlackBoardID", cr2w, this);
				}
				return _combatBlackBoardID;
			}
			set
			{
				if (_combatBlackBoardID == value)
				{
					return;
				}
				_combatBlackBoardID = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("wantedValueBlackboardID")] 
		public CUInt32 WantedValueBlackboardID
		{
			get
			{
				if (_wantedValueBlackboardID == null)
				{
					_wantedValueBlackboardID = (CUInt32) CR2WTypeManager.Create("Uint32", "wantedValueBlackboardID", cr2w, this);
				}
				return _wantedValueBlackboardID;
			}
			set
			{
				if (_wantedValueBlackboardID == value)
				{
					return;
				}
				_wantedValueBlackboardID = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("bountyAmountBlackboardID")] 
		public CUInt32 BountyAmountBlackboardID
		{
			get
			{
				if (_bountyAmountBlackboardID == null)
				{
					_bountyAmountBlackboardID = (CUInt32) CR2WTypeManager.Create("Uint32", "bountyAmountBlackboardID", cr2w, this);
				}
				return _bountyAmountBlackboardID;
			}
			set
			{
				if (_bountyAmountBlackboardID == value)
				{
					return;
				}
				_bountyAmountBlackboardID = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("playerBlackboardID")] 
		public CUInt32 PlayerBlackboardID
		{
			get
			{
				if (_playerBlackboardID == null)
				{
					_playerBlackboardID = (CUInt32) CR2WTypeManager.Create("Uint32", "playerBlackboardID", cr2w, this);
				}
				return _playerBlackboardID;
			}
			set
			{
				if (_playerBlackboardID == value)
				{
					return;
				}
				_playerBlackboardID = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("blackboard")] 
		public CHandle<gameIBlackboard> Blackboard
		{
			get
			{
				if (_blackboard == null)
				{
					_blackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "blackboard", cr2w, this);
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

		[Ordinal(9)] 
		[RED("bountyPrice")] 
		public CInt32 BountyPrice
		{
			get
			{
				if (_bountyPrice == null)
				{
					_bountyPrice = (CInt32) CR2WTypeManager.Create("Int32", "bountyPrice", cr2w, this);
				}
				return _bountyPrice;
			}
			set
			{
				if (_bountyPrice == value)
				{
					return;
				}
				_bountyPrice = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("wantedBlackboard")] 
		public CHandle<gameIBlackboard> WantedBlackboard
		{
			get
			{
				if (_wantedBlackboard == null)
				{
					_wantedBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "wantedBlackboard", cr2w, this);
				}
				return _wantedBlackboard;
			}
			set
			{
				if (_wantedBlackboard == value)
				{
					return;
				}
				_wantedBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("wantedBlackboardDef")] 
		public CHandle<UI_WantedBarDef> WantedBlackboardDef
		{
			get
			{
				if (_wantedBlackboardDef == null)
				{
					_wantedBlackboardDef = (CHandle<UI_WantedBarDef>) CR2WTypeManager.Create("handle:UI_WantedBarDef", "wantedBlackboardDef", cr2w, this);
				}
				return _wantedBlackboardDef;
			}
			set
			{
				if (_wantedBlackboardDef == value)
				{
					return;
				}
				_wantedBlackboardDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("playerInCombat")] 
		public CBool PlayerInCombat
		{
			get
			{
				if (_playerInCombat == null)
				{
					_playerInCombat = (CBool) CR2WTypeManager.Create("Bool", "playerInCombat", cr2w, this);
				}
				return _playerInCombat;
			}
			set
			{
				if (_playerInCombat == value)
				{
					return;
				}
				_playerInCombat = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("playerPuppet")] 
		public wCHandle<gameObject> PlayerPuppet
		{
			get
			{
				if (_playerPuppet == null)
				{
					_playerPuppet = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "playerPuppet", cr2w, this);
				}
				return _playerPuppet;
			}
			set
			{
				if (_playerPuppet == value)
				{
					return;
				}
				_playerPuppet = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("currentSecurityZoneType")] 
		public CEnum<ESecurityAreaType> CurrentSecurityZoneType
		{
			get
			{
				if (_currentSecurityZoneType == null)
				{
					_currentSecurityZoneType = (CEnum<ESecurityAreaType>) CR2WTypeManager.Create("ESecurityAreaType", "currentSecurityZoneType", cr2w, this);
				}
				return _currentSecurityZoneType;
			}
			set
			{
				if (_currentSecurityZoneType == value)
				{
					return;
				}
				_currentSecurityZoneType = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("vehicleZoneBlackboard")] 
		public CHandle<gameIBlackboard> VehicleZoneBlackboard
		{
			get
			{
				if (_vehicleZoneBlackboard == null)
				{
					_vehicleZoneBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "vehicleZoneBlackboard", cr2w, this);
				}
				return _vehicleZoneBlackboard;
			}
			set
			{
				if (_vehicleZoneBlackboard == value)
				{
					return;
				}
				_vehicleZoneBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("vehicleZoneBlackboardDef")] 
		public CHandle<LocalPlayerDef> VehicleZoneBlackboardDef
		{
			get
			{
				if (_vehicleZoneBlackboardDef == null)
				{
					_vehicleZoneBlackboardDef = (CHandle<LocalPlayerDef>) CR2WTypeManager.Create("handle:LocalPlayerDef", "vehicleZoneBlackboardDef", cr2w, this);
				}
				return _vehicleZoneBlackboardDef;
			}
			set
			{
				if (_vehicleZoneBlackboardDef == value)
				{
					return;
				}
				_vehicleZoneBlackboardDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("vehicleZoneBlackboardID")] 
		public CUInt32 VehicleZoneBlackboardID
		{
			get
			{
				if (_vehicleZoneBlackboardID == null)
				{
					_vehicleZoneBlackboardID = (CUInt32) CR2WTypeManager.Create("Uint32", "vehicleZoneBlackboardID", cr2w, this);
				}
				return _vehicleZoneBlackboardID;
			}
			set
			{
				if (_vehicleZoneBlackboardID == value)
				{
					return;
				}
				_vehicleZoneBlackboardID = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("WANTED_TIER_SIZE")] 
		public CInt32 WANTED_TIER_SIZE
		{
			get
			{
				if (_wANTED_TIER_SIZE == null)
				{
					_wANTED_TIER_SIZE = (CInt32) CR2WTypeManager.Create("Int32", "WANTED_TIER_SIZE", cr2w, this);
				}
				return _wANTED_TIER_SIZE;
			}
			set
			{
				if (_wANTED_TIER_SIZE == value)
				{
					return;
				}
				_wANTED_TIER_SIZE = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("wantedLevel")] 
		public CInt32 WantedLevel
		{
			get
			{
				if (_wantedLevel == null)
				{
					_wantedLevel = (CInt32) CR2WTypeManager.Create("Int32", "wantedLevel", cr2w, this);
				}
				return _wantedLevel;
			}
			set
			{
				if (_wantedLevel == value)
				{
					return;
				}
				_wantedLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("factListenerID")] 
		public CUInt32 FactListenerID
		{
			get
			{
				if (_factListenerID == null)
				{
					_factListenerID = (CUInt32) CR2WTypeManager.Create("Uint32", "factListenerID", cr2w, this);
				}
				return _factListenerID;
			}
			set
			{
				if (_factListenerID == value)
				{
					return;
				}
				_factListenerID = value;
				PropertySet(this);
			}
		}

		public ZoneAlertNotificationQueue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
