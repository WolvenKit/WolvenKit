using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameReplicatedAnimControllerEventsState : CVariable
	{
		[Ordinal(0)]  [RED("items")] public CArray<gameReplicatedAnimEvent> Items { get; set; }
		[Ordinal(1)]  [RED("lastAppliedActionsTime")] public netTime LastAppliedActionsTime { get; set; }

		public gameReplicatedAnimControllerEventsState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
