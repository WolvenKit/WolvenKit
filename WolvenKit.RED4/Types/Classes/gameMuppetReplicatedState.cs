using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMuppetReplicatedState : netIEntityState
	{
		[Ordinal(2)] 
		[RED("state")] 
		public gameMuppetState State
		{
			get => GetPropertyValue<gameMuppetState>();
			set => SetPropertyValue<gameMuppetState>(value);
		}

		[Ordinal(3)] 
		[RED("initialOrientation")] 
		public EulerAngles InitialOrientation
		{
			get => GetPropertyValue<EulerAngles>();
			set => SetPropertyValue<EulerAngles>(value);
		}

		[Ordinal(4)] 
		[RED("initialLocation")] 
		public Vector3 InitialLocation
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(5)] 
		[RED("health")] 
		public CFloat Health
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("armor")] 
		public CFloat Armor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameMuppetReplicatedState()
		{
			State = new gameMuppetState { FrameId = uint.MaxValue, HighLevelState = new gameMuppetHighLevelState { DeathFrameId = uint.MaxValue }, HealthState = new gameMuppetHealthState(), PhysicalMoveState = new gameMuppetPhysicalState { Position = new Vector4(), Velocity = new Vector4(), IsOnGround = true, GroundNormal = new Vector4 { Z = 1.000000F } }, LookState = new gameMuppetLookState { LookDir = new EulerAngles() }, MoveState = new gameMuppetMoveState { JumpStartFrameId = uint.MaxValue, LandFrameId = uint.MaxValue }, UpperBodyState = new gameMuppetUpperBodyState { CurrentWeapon = new gameItemID(), WantedWeapon = new gameItemID(), InProgressWeapon = new gameItemID(), LogicWantedWeapon = new gameItemID(), CurrentWeaponAmmo = 10, CurrentWeaponAmmoCapacity = 10, SelectedConsumable = new gameItemID() }, ScanningState = new gameMuppetScanningState(), InventoryState = new gameMuppetInventoryState { Slots = new(), ActiveSlot = -1 }, Abilities = new gameMuppetAbilities { CanLook = new gameMuppetAbility(), CanMove = new gameMuppetAbility(), CanCrouch = new gameMuppetAbility(), CanSprint = new gameMuppetAbility(), CanSwitchWeapon = new gameMuppetAbility(), CanHoldWeapon = new gameMuppetAbility(), CanShoot = new gameMuppetAbility(), CanAimDownSight = new gameMuppetAbility() }, StateMachinesSnapshot = new gameMuppetStateMachinesSnapshot { StateMachines = new() }, ControllersSnapshot = new gameMuppetControllersSnapshot { Controllers = new() }, SnapFrameId = uint.MaxValue };
			InitialOrientation = new EulerAngles();
			InitialLocation = new Vector3();
			Health = -1.000000F;
			Armor = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
