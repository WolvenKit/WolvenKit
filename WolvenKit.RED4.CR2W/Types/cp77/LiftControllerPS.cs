using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LiftControllerPS : MasterControllerPS
	{
		private LiftSetup _liftSetup;
		private CInt32 _activeFloor;
		private CInt32 _targetFloor;
		private CEnum<gamePlatformMovementState> _movementState;
		private CArray<ElevatorFloorSetup> _floors;
		private CArray<entEntityID> _floorIDs;
		private CArray<gamePersistentID> _floorPSIDs;
		private CArray<CBool> _floorsAuthorization;
		private CFloat _timeOnPause;
		private CBool _isPlayerInsideLift;
		private CBool _isSpeakerDestroyed;
		private CBool _hasSpeaker;
		private CArray<RadioStationsMap> _stations;
		private CInt32 _cachedGoToFloorAction;
		private CBool _isAllDoorsClosed;
		private CBool _isAdsDisabled;

		[Ordinal(104)] 
		[RED("liftSetup")] 
		public LiftSetup LiftSetup
		{
			get
			{
				if (_liftSetup == null)
				{
					_liftSetup = (LiftSetup) CR2WTypeManager.Create("LiftSetup", "liftSetup", cr2w, this);
				}
				return _liftSetup;
			}
			set
			{
				if (_liftSetup == value)
				{
					return;
				}
				_liftSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("activeFloor")] 
		public CInt32 ActiveFloor
		{
			get
			{
				if (_activeFloor == null)
				{
					_activeFloor = (CInt32) CR2WTypeManager.Create("Int32", "activeFloor", cr2w, this);
				}
				return _activeFloor;
			}
			set
			{
				if (_activeFloor == value)
				{
					return;
				}
				_activeFloor = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("targetFloor")] 
		public CInt32 TargetFloor
		{
			get
			{
				if (_targetFloor == null)
				{
					_targetFloor = (CInt32) CR2WTypeManager.Create("Int32", "targetFloor", cr2w, this);
				}
				return _targetFloor;
			}
			set
			{
				if (_targetFloor == value)
				{
					return;
				}
				_targetFloor = value;
				PropertySet(this);
			}
		}

		[Ordinal(107)] 
		[RED("movementState")] 
		public CEnum<gamePlatformMovementState> MovementState
		{
			get
			{
				if (_movementState == null)
				{
					_movementState = (CEnum<gamePlatformMovementState>) CR2WTypeManager.Create("gamePlatformMovementState", "movementState", cr2w, this);
				}
				return _movementState;
			}
			set
			{
				if (_movementState == value)
				{
					return;
				}
				_movementState = value;
				PropertySet(this);
			}
		}

		[Ordinal(108)] 
		[RED("floors")] 
		public CArray<ElevatorFloorSetup> Floors
		{
			get
			{
				if (_floors == null)
				{
					_floors = (CArray<ElevatorFloorSetup>) CR2WTypeManager.Create("array:ElevatorFloorSetup", "floors", cr2w, this);
				}
				return _floors;
			}
			set
			{
				if (_floors == value)
				{
					return;
				}
				_floors = value;
				PropertySet(this);
			}
		}

		[Ordinal(109)] 
		[RED("floorIDs")] 
		public CArray<entEntityID> FloorIDs
		{
			get
			{
				if (_floorIDs == null)
				{
					_floorIDs = (CArray<entEntityID>) CR2WTypeManager.Create("array:entEntityID", "floorIDs", cr2w, this);
				}
				return _floorIDs;
			}
			set
			{
				if (_floorIDs == value)
				{
					return;
				}
				_floorIDs = value;
				PropertySet(this);
			}
		}

		[Ordinal(110)] 
		[RED("floorPSIDs")] 
		public CArray<gamePersistentID> FloorPSIDs
		{
			get
			{
				if (_floorPSIDs == null)
				{
					_floorPSIDs = (CArray<gamePersistentID>) CR2WTypeManager.Create("array:gamePersistentID", "floorPSIDs", cr2w, this);
				}
				return _floorPSIDs;
			}
			set
			{
				if (_floorPSIDs == value)
				{
					return;
				}
				_floorPSIDs = value;
				PropertySet(this);
			}
		}

		[Ordinal(111)] 
		[RED("floorsAuthorization")] 
		public CArray<CBool> FloorsAuthorization
		{
			get
			{
				if (_floorsAuthorization == null)
				{
					_floorsAuthorization = (CArray<CBool>) CR2WTypeManager.Create("array:Bool", "floorsAuthorization", cr2w, this);
				}
				return _floorsAuthorization;
			}
			set
			{
				if (_floorsAuthorization == value)
				{
					return;
				}
				_floorsAuthorization = value;
				PropertySet(this);
			}
		}

		[Ordinal(112)] 
		[RED("timeOnPause")] 
		public CFloat TimeOnPause
		{
			get
			{
				if (_timeOnPause == null)
				{
					_timeOnPause = (CFloat) CR2WTypeManager.Create("Float", "timeOnPause", cr2w, this);
				}
				return _timeOnPause;
			}
			set
			{
				if (_timeOnPause == value)
				{
					return;
				}
				_timeOnPause = value;
				PropertySet(this);
			}
		}

		[Ordinal(113)] 
		[RED("isPlayerInsideLift")] 
		public CBool IsPlayerInsideLift
		{
			get
			{
				if (_isPlayerInsideLift == null)
				{
					_isPlayerInsideLift = (CBool) CR2WTypeManager.Create("Bool", "isPlayerInsideLift", cr2w, this);
				}
				return _isPlayerInsideLift;
			}
			set
			{
				if (_isPlayerInsideLift == value)
				{
					return;
				}
				_isPlayerInsideLift = value;
				PropertySet(this);
			}
		}

		[Ordinal(114)] 
		[RED("isSpeakerDestroyed")] 
		public CBool IsSpeakerDestroyed
		{
			get
			{
				if (_isSpeakerDestroyed == null)
				{
					_isSpeakerDestroyed = (CBool) CR2WTypeManager.Create("Bool", "isSpeakerDestroyed", cr2w, this);
				}
				return _isSpeakerDestroyed;
			}
			set
			{
				if (_isSpeakerDestroyed == value)
				{
					return;
				}
				_isSpeakerDestroyed = value;
				PropertySet(this);
			}
		}

		[Ordinal(115)] 
		[RED("hasSpeaker")] 
		public CBool HasSpeaker
		{
			get
			{
				if (_hasSpeaker == null)
				{
					_hasSpeaker = (CBool) CR2WTypeManager.Create("Bool", "hasSpeaker", cr2w, this);
				}
				return _hasSpeaker;
			}
			set
			{
				if (_hasSpeaker == value)
				{
					return;
				}
				_hasSpeaker = value;
				PropertySet(this);
			}
		}

		[Ordinal(116)] 
		[RED("stations")] 
		public CArray<RadioStationsMap> Stations
		{
			get
			{
				if (_stations == null)
				{
					_stations = (CArray<RadioStationsMap>) CR2WTypeManager.Create("array:RadioStationsMap", "stations", cr2w, this);
				}
				return _stations;
			}
			set
			{
				if (_stations == value)
				{
					return;
				}
				_stations = value;
				PropertySet(this);
			}
		}

		[Ordinal(117)] 
		[RED("cachedGoToFloorAction")] 
		public CInt32 CachedGoToFloorAction
		{
			get
			{
				if (_cachedGoToFloorAction == null)
				{
					_cachedGoToFloorAction = (CInt32) CR2WTypeManager.Create("Int32", "cachedGoToFloorAction", cr2w, this);
				}
				return _cachedGoToFloorAction;
			}
			set
			{
				if (_cachedGoToFloorAction == value)
				{
					return;
				}
				_cachedGoToFloorAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(118)] 
		[RED("isAllDoorsClosed")] 
		public CBool IsAllDoorsClosed
		{
			get
			{
				if (_isAllDoorsClosed == null)
				{
					_isAllDoorsClosed = (CBool) CR2WTypeManager.Create("Bool", "isAllDoorsClosed", cr2w, this);
				}
				return _isAllDoorsClosed;
			}
			set
			{
				if (_isAllDoorsClosed == value)
				{
					return;
				}
				_isAllDoorsClosed = value;
				PropertySet(this);
			}
		}

		[Ordinal(119)] 
		[RED("isAdsDisabled")] 
		public CBool IsAdsDisabled
		{
			get
			{
				if (_isAdsDisabled == null)
				{
					_isAdsDisabled = (CBool) CR2WTypeManager.Create("Bool", "isAdsDisabled", cr2w, this);
				}
				return _isAdsDisabled;
			}
			set
			{
				if (_isAdsDisabled == value)
				{
					return;
				}
				_isAdsDisabled = value;
				PropertySet(this);
			}
		}

		public LiftControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
