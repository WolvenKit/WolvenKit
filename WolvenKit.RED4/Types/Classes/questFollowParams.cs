using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questFollowParams : questAICommandParams
	{
		[Ordinal(0)] 
		[RED("companionRef")] 
		public CHandle<questUniversalRef> CompanionRef
		{
			get => GetPropertyValue<CHandle<questUniversalRef>>();
			set => SetPropertyValue<CHandle<questUniversalRef>>(value);
		}

		[Ordinal(1)] 
		[RED("companionDistance")] 
		public CFloat CompanionDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("destinationPointTolerance")] 
		public CFloat DestinationPointTolerance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("stopWhenDestinationReached")] 
		public CBool StopWhenDestinationReached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get => GetPropertyValue<CEnum<moveMovementType>>();
			set => SetPropertyValue<CEnum<moveMovementType>>(value);
		}

		[Ordinal(5)] 
		[RED("matchSpeed")] 
		public CBool MatchSpeed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("useTeleport")] 
		public CBool UseTeleport
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("repeatCommandOnInterrupt")] 
		public CBool RepeatCommandOnInterrupt
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questFollowParams()
		{
			CompanionDistance = 5.000000F;
			DestinationPointTolerance = 2.000000F;
			MatchSpeed = true;
			UseTeleport = true;
			RepeatCommandOnInterrupt = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
