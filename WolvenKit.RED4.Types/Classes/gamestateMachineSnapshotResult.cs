using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineSnapshotResult : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("snapshot")] 
		public gamestateMachineStateSnapshot Snapshot
		{
			get => GetPropertyValue<gamestateMachineStateSnapshot>();
			set => SetPropertyValue<gamestateMachineStateSnapshot>(value);
		}

		[Ordinal(1)] 
		[RED("valid")] 
		public CBool Valid
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gamestateMachineSnapshotResult()
		{
			Snapshot = new() { InstanceData = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
