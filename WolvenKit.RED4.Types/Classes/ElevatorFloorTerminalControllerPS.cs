using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ElevatorFloorTerminalControllerPS : TerminalControllerPS
	{
		[Ordinal(114)] 
		[RED("elevatorFloorSetup")] 
		public ElevatorFloorSetup ElevatorFloorSetup
		{
			get => GetPropertyValue<ElevatorFloorSetup>();
			set => SetPropertyValue<ElevatorFloorSetup>(value);
		}

		[Ordinal(115)] 
		[RED("hasDirectInteration")] 
		public CBool HasDirectInteration
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(116)] 
		[RED("isElevatorAtThisFloor")] 
		public CBool IsElevatorAtThisFloor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ElevatorFloorTerminalControllerPS()
		{
			DeviceName = "LocKey#88";
			TweakDBRecord = 127337775259;
			TweakDBDescriptionRecord = 179291460156;
			ElevatorFloorSetup = new() { DoorShouldOpenFrontLeftRight = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
