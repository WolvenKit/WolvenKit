using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ElevatorFloorTerminalControllerPS : TerminalControllerPS
	{
		[Ordinal(117)] 
		[RED("elevatorFloorSetup")] 
		public ElevatorFloorSetup ElevatorFloorSetup
		{
			get => GetPropertyValue<ElevatorFloorSetup>();
			set => SetPropertyValue<ElevatorFloorSetup>(value);
		}

		[Ordinal(118)] 
		[RED("hasDirectInteration")] 
		public CBool HasDirectInteration
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(119)] 
		[RED("isElevatorAtThisFloor")] 
		public CBool IsElevatorAtThisFloor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ElevatorFloorTerminalControllerPS()
		{
			DeviceName = "LocKey#88";
			TweakDBRecord = "Devices.ElevatorFloorTerminal";
			TweakDBDescriptionRecord = 179291460156;
			ElevatorFloorSetup = new ElevatorFloorSetup { DoorShouldOpenFrontLeftRight = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
