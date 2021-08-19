using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ElevatorFloorTerminalControllerPS : TerminalControllerPS
	{
		private ElevatorFloorSetup _elevatorFloorSetup;
		private CBool _hasDirectInteration;
		private CBool _isElevatorAtThisFloor;

		[Ordinal(114)] 
		[RED("elevatorFloorSetup")] 
		public ElevatorFloorSetup ElevatorFloorSetup
		{
			get => GetProperty(ref _elevatorFloorSetup);
			set => SetProperty(ref _elevatorFloorSetup, value);
		}

		[Ordinal(115)] 
		[RED("hasDirectInteration")] 
		public CBool HasDirectInteration
		{
			get => GetProperty(ref _hasDirectInteration);
			set => SetProperty(ref _hasDirectInteration, value);
		}

		[Ordinal(116)] 
		[RED("isElevatorAtThisFloor")] 
		public CBool IsElevatorAtThisFloor
		{
			get => GetProperty(ref _isElevatorAtThisFloor);
			set => SetProperty(ref _isElevatorAtThisFloor, value);
		}

		public ElevatorFloorTerminalControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
