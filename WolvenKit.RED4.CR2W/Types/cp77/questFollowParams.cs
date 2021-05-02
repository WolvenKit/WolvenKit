using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questFollowParams : questAICommandParams
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

		public questFollowParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
