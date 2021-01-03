using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineStateSnapshotsContainer : CVariable
	{
		[Ordinal(0)]  [RED("snapshot")] public CArray<gamestateMachineStateSnapshot> Snapshot { get; set; }

		public gamestateMachineStateSnapshotsContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
