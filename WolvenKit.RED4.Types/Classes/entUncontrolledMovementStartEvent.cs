using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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

		public entUncontrolledMovementStartEvent()
		{
			RagdollOnCollision = true;
		}
	}
}
