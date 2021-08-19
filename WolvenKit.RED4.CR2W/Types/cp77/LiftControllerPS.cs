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

		[Ordinal(105)] 
		[RED("liftSetup")] 
		public LiftSetup LiftSetup
		{
			get => GetProperty(ref _liftSetup);
			set => SetProperty(ref _liftSetup, value);
		}

		[Ordinal(106)] 
		[RED("activeFloor")] 
		public CInt32 ActiveFloor
		{
			get => GetProperty(ref _activeFloor);
			set => SetProperty(ref _activeFloor, value);
		}

		[Ordinal(107)] 
		[RED("targetFloor")] 
		public CInt32 TargetFloor
		{
			get => GetProperty(ref _targetFloor);
			set => SetProperty(ref _targetFloor, value);
		}

		[Ordinal(108)] 
		[RED("movementState")] 
		public CEnum<gamePlatformMovementState> MovementState
		{
			get => GetProperty(ref _movementState);
			set => SetProperty(ref _movementState, value);
		}

		[Ordinal(109)] 
		[RED("floors")] 
		public CArray<ElevatorFloorSetup> Floors
		{
			get => GetProperty(ref _floors);
			set => SetProperty(ref _floors, value);
		}

		[Ordinal(110)] 
		[RED("floorIDs")] 
		public CArray<entEntityID> FloorIDs
		{
			get => GetProperty(ref _floorIDs);
			set => SetProperty(ref _floorIDs, value);
		}

		[Ordinal(111)] 
		[RED("floorPSIDs")] 
		public CArray<gamePersistentID> FloorPSIDs
		{
			get => GetProperty(ref _floorPSIDs);
			set => SetProperty(ref _floorPSIDs, value);
		}

		[Ordinal(112)] 
		[RED("floorsAuthorization")] 
		public CArray<CBool> FloorsAuthorization
		{
			get => GetProperty(ref _floorsAuthorization);
			set => SetProperty(ref _floorsAuthorization, value);
		}

		[Ordinal(113)] 
		[RED("timeOnPause")] 
		public CFloat TimeOnPause
		{
			get => GetProperty(ref _timeOnPause);
			set => SetProperty(ref _timeOnPause, value);
		}

		[Ordinal(114)] 
		[RED("isPlayerInsideLift")] 
		public CBool IsPlayerInsideLift
		{
			get => GetProperty(ref _isPlayerInsideLift);
			set => SetProperty(ref _isPlayerInsideLift, value);
		}

		[Ordinal(115)] 
		[RED("isSpeakerDestroyed")] 
		public CBool IsSpeakerDestroyed
		{
			get => GetProperty(ref _isSpeakerDestroyed);
			set => SetProperty(ref _isSpeakerDestroyed, value);
		}

		[Ordinal(116)] 
		[RED("hasSpeaker")] 
		public CBool HasSpeaker
		{
			get => GetProperty(ref _hasSpeaker);
			set => SetProperty(ref _hasSpeaker, value);
		}

		[Ordinal(117)] 
		[RED("stations")] 
		public CArray<RadioStationsMap> Stations
		{
			get => GetProperty(ref _stations);
			set => SetProperty(ref _stations, value);
		}

		[Ordinal(118)] 
		[RED("cachedGoToFloorAction")] 
		public CInt32 CachedGoToFloorAction
		{
			get => GetProperty(ref _cachedGoToFloorAction);
			set => SetProperty(ref _cachedGoToFloorAction, value);
		}

		[Ordinal(119)] 
		[RED("isAllDoorsClosed")] 
		public CBool IsAllDoorsClosed
		{
			get => GetProperty(ref _isAllDoorsClosed);
			set => SetProperty(ref _isAllDoorsClosed, value);
		}

		[Ordinal(120)] 
		[RED("isAdsDisabled")] 
		public CBool IsAdsDisabled
		{
			get => GetProperty(ref _isAdsDisabled);
			set => SetProperty(ref _isAdsDisabled, value);
		}

		public LiftControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
