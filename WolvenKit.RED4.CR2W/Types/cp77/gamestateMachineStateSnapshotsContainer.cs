using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineStateSnapshotsContainer : CVariable
	{
		private CArray<gamestateMachineStateSnapshot> _snapshot;

		[Ordinal(0)] 
		[RED("snapshot")] 
		public CArray<gamestateMachineStateSnapshot> Snapshot
		{
			get => GetProperty(ref _snapshot);
			set => SetProperty(ref _snapshot, value);
		}

		public gamestateMachineStateSnapshotsContainer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
