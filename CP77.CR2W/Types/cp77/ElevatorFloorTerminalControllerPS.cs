using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ElevatorFloorTerminalControllerPS : TerminalControllerPS
	{
		[Ordinal(113)] [RED("elevatorFloorSetup")] public ElevatorFloorSetup ElevatorFloorSetup { get; set; }
		[Ordinal(114)] [RED("hasDirectInteration")] public CBool HasDirectInteration { get; set; }
		[Ordinal(115)] [RED("isElevatorAtThisFloor")] public CBool IsElevatorAtThisFloor { get; set; }

		public ElevatorFloorTerminalControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
