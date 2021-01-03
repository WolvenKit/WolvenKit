using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ElevatorFloorTerminalControllerPS : TerminalControllerPS
	{
		[Ordinal(0)]  [RED("elevatorFloorSetup")] public ElevatorFloorSetup ElevatorFloorSetup { get; set; }
		[Ordinal(1)]  [RED("hasDirectInteration")] public CBool HasDirectInteration { get; set; }
		[Ordinal(2)]  [RED("isElevatorAtThisFloor")] public CBool IsElevatorAtThisFloor { get; set; }

		public ElevatorFloorTerminalControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
