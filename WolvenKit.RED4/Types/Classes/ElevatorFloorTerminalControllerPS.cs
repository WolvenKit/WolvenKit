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
			TweakDBDescriptionRecord = "device_descriptions.ElevatorFloorTerminal";
			ElevatorFloorSetup = new ElevatorFloorSetup();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
