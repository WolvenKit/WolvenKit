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
			InputState = new gameMuppetInputState { FrameId = uint.MaxValue };
			State = new gameMuppetState { FrameId = uint.MaxValue, HighLevelState = new gameMuppetHighLevelState { DeathFrameId = uint.MaxValue }, HealthState = new gameMuppetHealthState(), PhysicalMoveState = new gameMuppetPhysicalState { Position = new Vector4(), Velocity = new Vector4(), IsOnGround = true, GroundNormal = new Vector4 { Z = 1.000000F } }, LookState = new gameMuppetLookState { LookDir = new EulerAngles() }, MoveState = new gameMuppetMoveState { JumpStartFrameId = uint.MaxValue, LandFrameId = uint.MaxValue }, UpperBodyState = new gameMuppetUpperBodyState { CurrentWeapon = new gameItemID(), WantedWeapon = new gameItemID(), InProgressWeapon = new gameItemID(), LogicWantedWeapon = new gameItemID(), CurrentWeaponAmmo = 10, CurrentWeaponAmmoCapacity = 10, SelectedConsumable = new gameItemID() }, ScanningState = new gameMuppetScanningState(), InventoryState = new gameMuppetInventoryState { Slots = new(), ActiveSlot = -1 }, Abilities = new gameMuppetAbilities { CanLook = new gameMuppetAbility(), CanMove = new gameMuppetAbility(), CanCrouch = new gameMuppetAbility(), CanSprint = new gameMuppetAbility(), CanSwitchWeapon = new gameMuppetAbility(), CanHoldWeapon = new gameMuppetAbility(), CanShoot = new gameMuppetAbility(), CanAimDownSight = new gameMuppetAbility() }, StateMachinesSnapshot = new gameMuppetStateMachinesSnapshot { StateMachines = new() }, ControllersSnapshot = new gameMuppetControllersSnapshot { Controllers = new() }, SnapFrameId = uint.MaxValue };
			ResimulationSubsteps = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
