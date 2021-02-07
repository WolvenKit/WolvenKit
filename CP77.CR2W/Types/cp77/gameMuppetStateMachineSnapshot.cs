using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameMuppetStateMachineSnapshot : CVariable
	{
		[Ordinal(0)]  [RED("stateMachineId")] public CName StateMachineId { get; set; }
		[Ordinal(1)]  [RED("stateId")] public CName StateId { get; set; }

		public gameMuppetStateMachineSnapshot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
