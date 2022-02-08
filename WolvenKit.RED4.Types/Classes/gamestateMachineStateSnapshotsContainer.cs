using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamestateMachineStateSnapshotsContainer : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("snapshot")] 
		public CArray<gamestateMachineStateSnapshot> Snapshot
		{
			get => GetPropertyValue<CArray<gamestateMachineStateSnapshot>>();
			set => SetPropertyValue<CArray<gamestateMachineStateSnapshot>>(value);
		}

		public gamestateMachineStateSnapshotsContainer()
		{
			Snapshot = new();
		}
	}
}
