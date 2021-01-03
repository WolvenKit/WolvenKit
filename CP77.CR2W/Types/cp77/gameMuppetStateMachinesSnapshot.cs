using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameMuppetStateMachinesSnapshot : CVariable
	{
		[Ordinal(0)]  [RED("stateMachines")] public CArray<gameMuppetStateMachineSnapshot> StateMachines { get; set; }

		public gameMuppetStateMachinesSnapshot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
