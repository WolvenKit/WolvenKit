using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMuppetSubStepData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("frameId")] 
		public CUInt32 FrameId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("parentFrameId")] 
		public CUInt32 ParentFrameId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("parentFramePrimaryColor")] 
		public CBool ParentFramePrimaryColor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("inputState")] 
		public gameMuppetInputState InputState
		{
			get => GetPropertyValue<gameMuppetInputState>();
			set => SetPropertyValue<gameMuppetInputState>(value);
		}

		[Ordinal(4)] 
		[RED("state")] 
		public gameMuppetState State
		{
			get => GetPropertyValue<gameMuppetState>();
			set => SetPropertyValue<gameMuppetState>(value);
		}

		[Ordinal(5)] 
		[RED("resimulationSubsteps")] 
		public CArray<gameMuppetSubStepData> ResimulationSubsteps
		{
			get => GetPropertyValue<CArray<gameMuppetSubStepData>>();
			set => SetPropertyValue<CArray<gameMuppetSubStepData>>(value);
		}

		public gameMuppetSubStepData()
		{
			InputState = new() { FrameId = 4294967295 };
			State = new() { FrameId = 4294967295, HighLevelState = new() { DeathFrameId = 4294967295 }, HealthState = new(), PhysicalMoveState = new() { Position = new(), Velocity = new(), IsOnGround = true, GroundNormal = new() { Z = 1.000000F } }, LookState = new() { LookDir = new() }, MoveState = new() { JumpStartFrameId = 4294967295, LandFrameId = 4294967295 }, UpperBodyState = new() { CurrentWeapon = new(), WantedWeapon = new(), InProgressWeapon = new(), LogicWantedWeapon = new(), CurrentWeaponAmmo = 10, CurrentWeaponAmmoCapacity = 10, SelectedConsumable = new() }, ScanningState = new(), InventoryState = new() { Slots = new(), ActiveSlot = -1 }, Abilities = new() { CanLook = new(), CanMove = new(), CanCrouch = new(), CanSprint = new(), CanSwitchWeapon = new(), CanHoldWeapon = new(), CanShoot = new(), CanAimDownSight = new() }, StateMachinesSnapshot = new() { StateMachines = new() }, ControllersSnapshot = new() { Controllers = new() }, SnapFrameId = 4294967295 };
			ResimulationSubsteps = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
