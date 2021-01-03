using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineSnapshotResult : CVariable
	{
		[Ordinal(0)]  [RED("snapshot")] public gamestateMachineStateSnapshot Snapshot { get; set; }
		[Ordinal(1)]  [RED("valid")] public CBool Valid { get; set; }

		public gamestateMachineSnapshotResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
