using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entUncontrolledMovementStartEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("ragdollNoGroundThreshold")] 
		public CFloat RagdollNoGroundThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("ragdollOnCollision")] 
		public CBool RagdollOnCollision
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("calculateEarlyPositionGroundHeight")] 
		public CBool CalculateEarlyPositionGroundHeight
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public entUncontrolledMovementStartEvent()
		{
			RagdollOnCollision = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
