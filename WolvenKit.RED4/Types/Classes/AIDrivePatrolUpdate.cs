using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIDrivePatrolUpdate : AIDriveCommandUpdate
	{
		[Ordinal(3)] 
		[RED("numPatrolLoops")] 
		public CUInt32 NumPatrolLoops
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("emergencyPatrol")] 
		public CBool EmergencyPatrol
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIDrivePatrolUpdate()
		{
			NumPatrolLoops = uint.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
