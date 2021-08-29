using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamestateMachineStateSnapshotsContainer : RedBaseClass
	{
		private CArray<gamestateMachineStateSnapshot> _snapshot;

		[Ordinal(0)] 
		[RED("snapshot")] 
		public CArray<gamestateMachineStateSnapshot> Snapshot
		{
			get => GetProperty(ref _snapshot);
			set => SetProperty(ref _snapshot, value);
		}
	}
}
