using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineStateContext : CVariable
	{
		[Ordinal(0)] [RED("snapshot")] public gamestateMachineStateSnapshotsContainer Snapshot { get; set; }
		[Ordinal(1)] [RED("permanentParameters")] public gamestateMachineStateContextParameters PermanentParameters { get; set; }

		public gamestateMachineStateContext(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
