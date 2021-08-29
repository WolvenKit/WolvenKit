using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamestateMachineStateContext : RedBaseClass
	{
		private gamestateMachineStateSnapshotsContainer _snapshot;
		private gamestateMachineStateContextParameters _permanentParameters;

		[Ordinal(0)] 
		[RED("snapshot")] 
		public gamestateMachineStateSnapshotsContainer Snapshot
		{
			get => GetProperty(ref _snapshot);
			set => SetProperty(ref _snapshot, value);
		}

		[Ordinal(1)] 
		[RED("permanentParameters")] 
		public gamestateMachineStateContextParameters PermanentParameters
		{
			get => GetProperty(ref _permanentParameters);
			set => SetProperty(ref _permanentParameters, value);
		}
	}
}
