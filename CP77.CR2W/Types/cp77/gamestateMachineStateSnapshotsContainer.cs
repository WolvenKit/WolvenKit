using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineStateSnapshotsContainer : CVariable
	{
		[Ordinal(0)] [RED("snapshot")] public CArray<gamestateMachineStateSnapshot> Snapshot { get; set; }

		public gamestateMachineStateSnapshotsContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
