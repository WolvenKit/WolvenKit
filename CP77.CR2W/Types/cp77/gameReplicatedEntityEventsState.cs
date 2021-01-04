using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameReplicatedEntityEventsState : CVariable
	{
		[Ordinal(0)]  [RED("items")] public CArray<gameReplicatedEntityEvent> Items { get; set; }
		[Ordinal(1)]  [RED("lastAppliedActionsTime")] public netTime LastAppliedActionsTime { get; set; }

		public gameReplicatedEntityEventsState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
