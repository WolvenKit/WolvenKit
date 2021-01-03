using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineStateContext : CVariable
	{
		[Ordinal(0)]  [RED("permanentParameters")] public gamestateMachineStateContextParameters PermanentParameters { get; set; }
		[Ordinal(1)]  [RED("snapshot")] public gamestateMachineStateSnapshotsContainer Snapshot { get; set; }

		public gamestateMachineStateContext(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
