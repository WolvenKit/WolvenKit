using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questFollowParams : questAICommandParams
	{
		private CHandle<questUniversalRef> _companionRef;
		private CFloat _companionDistance;
		private CFloat _destinationPointTolerance;
		private CBool _stopWhenDestinationReached;
		private CEnum<moveMovementType> _movementType;
		private CBool _matchSpeed;
		private CBool _useTeleport;
		private CBool _repeatCommandOnInterrupt;

		[Ordinal(0)] 
		[RED("companionRef")] 
		public CHandle<questUniversalRef> CompanionRef
		{
			get => GetProperty(ref _companionRef);
			set => SetProperty(ref _companionRef, value);
		}

		[Ordinal(1)] 
		[RED("companionDistance")] 
		public CFloat CompanionDistance
		{
			get => GetProperty(ref _companionDistance);
			set => SetProperty(ref _companionDistance, value);
		}

		[Ordinal(2)] 
		[RED("destinationPointTolerance")] 
		public CFloat DestinationPointTolerance
		{
			get => GetProperty(ref _destinationPointTolerance);
			set => SetProperty(ref _destinationPointTolerance, value);
		}

		[Ordinal(3)] 
		[RED("stopWhenDestinationReached")] 
		public CBool StopWhenDestinationReached
		{
			get => GetProperty(ref _stopWhenDestinationReached);
			set => SetProperty(ref _stopWhenDestinationReached, value);
		}

		[Ordinal(4)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get => GetProperty(ref _movementType);
			set => SetProperty(ref _movementType, value);
		}

		[Ordinal(5)] 
		[RED("matchSpeed")] 
		public CBool MatchSpeed
		{
			get => GetProperty(ref _matchSpeed);
			set => SetProperty(ref _matchSpeed, value);
		}

		[Ordinal(6)] 
		[RED("useTeleport")] 
		public CBool UseTeleport
		{
			get => GetProperty(ref _useTeleport);
			set => SetProperty(ref _useTeleport, value);
		}

		[Ordinal(7)] 
		[RED("repeatCommandOnInterrupt")] 
		public CBool RepeatCommandOnInterrupt
		{
			get => GetProperty(ref _repeatCommandOnInterrupt);
			set => SetProperty(ref _repeatCommandOnInterrupt, value);
		}

		public questFollowParams()
		{
			_companionDistance = 5.000000F;
			_destinationPointTolerance = 2.000000F;
			_matchSpeed = true;
			_useTeleport = true;
			_repeatCommandOnInterrupt = true;
		}
	}
}
