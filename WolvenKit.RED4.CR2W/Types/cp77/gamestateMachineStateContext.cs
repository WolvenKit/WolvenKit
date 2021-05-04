using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineStateContext : CVariable
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

		public gamestateMachineStateContext(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
