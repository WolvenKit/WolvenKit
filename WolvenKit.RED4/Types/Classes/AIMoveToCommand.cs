using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIMoveToCommand : AIMoveCommand
	{
		[Ordinal(7)] 
		[RED("movementTarget")] 
		public AIPositionSpec MovementTarget
		{
			get => GetPropertyValue<AIPositionSpec>();
			set => SetPropertyValue<AIPositionSpec>(value);
		}

		[Ordinal(8)] 
		[RED("rotateEntityTowardsFacingTarget")] 
		public CBool RotateEntityTowardsFacingTarget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("facingTarget")] 
		public AIPositionSpec FacingTarget
		{
			get => GetPropertyValue<AIPositionSpec>();
			set => SetPropertyValue<AIPositionSpec>(value);
		}

		[Ordinal(10)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get => GetPropertyValue<CEnum<moveMovementType>>();
			set => SetPropertyValue<CEnum<moveMovementType>>(value);
		}

		[Ordinal(11)] 
		[RED("ignoreNavigation")] 
		public CBool IgnoreNavigation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("useStart")] 
		public CBool UseStart
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("useStop")] 
		public CBool UseStop
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("desiredDistanceFromTarget")] 
		public CFloat DesiredDistanceFromTarget
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("finishWhenDestinationReached")] 
		public CBool FinishWhenDestinationReached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIMoveToCommand()
		{
			MovementTarget = new() { WorldPosition = new() { X = new(), Y = new(), Z = new() } };
			FacingTarget = new() { WorldPosition = new() { X = new(), Y = new(), Z = new() } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
