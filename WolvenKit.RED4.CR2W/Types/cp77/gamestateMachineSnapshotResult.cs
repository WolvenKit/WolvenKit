using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineSnapshotResult : CVariable
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

		public gamestateMachineSnapshotResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
