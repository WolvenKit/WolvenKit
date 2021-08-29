using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamestateMachineSnapshotResult : RedBaseClass
	{
		private gamestateMachineStateSnapshot _snapshot;
		private CBool _valid;

		[Ordinal(0)] 
		[RED("snapshot")] 
		public gamestateMachineStateSnapshot Snapshot
		{
			get => GetProperty(ref _snapshot);
			set => SetProperty(ref _snapshot, value);
		}

		[Ordinal(1)] 
		[RED("valid")] 
		public CBool Valid
		{
			get => GetProperty(ref _valid);
			set => SetProperty(ref _valid, value);
		}
	}
}
