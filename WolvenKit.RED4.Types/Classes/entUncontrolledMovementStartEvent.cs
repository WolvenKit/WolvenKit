using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entUncontrolledMovementStartEvent : redEvent
	{
		private CFloat _ragdollNoGroundThreshold;
		private CBool _ragdollOnCollision;

		[Ordinal(0)] 
		[RED("ragdollNoGroundThreshold")] 
		public CFloat RagdollNoGroundThreshold
		{
			get => GetProperty(ref _ragdollNoGroundThreshold);
			set => SetProperty(ref _ragdollNoGroundThreshold, value);
		}

		[Ordinal(1)] 
		[RED("ragdollOnCollision")] 
		public CBool RagdollOnCollision
		{
			get => GetProperty(ref _ragdollOnCollision);
			set => SetProperty(ref _ragdollOnCollision, value);
		}
	}
}
