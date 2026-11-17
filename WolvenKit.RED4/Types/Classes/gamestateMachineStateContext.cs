using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineStateContext : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("snapshot")] 
		public gamestateMachineStateSnapshotsContainer Snapshot
		{
			get => GetPropertyValue<gamestateMachineStateSnapshotsContainer>();
			set => SetPropertyValue<gamestateMachineStateSnapshotsContainer>(value);
		}

		[Ordinal(1)] 
		[RED("permanentParameters")] 
		public gamestateMachineStateContextParameters PermanentParameters
		{
			get => GetPropertyValue<gamestateMachineStateContextParameters>();
			set => SetPropertyValue<gamestateMachineStateContextParameters>(value);
		}

		public gamestateMachineStateContext()
		{
			Snapshot = new gamestateMachineStateSnapshotsContainer();
			PermanentParameters = new gamestateMachineStateContextParameters();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
