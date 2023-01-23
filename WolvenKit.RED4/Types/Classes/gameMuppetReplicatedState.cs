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
			State = new() { FrameId = 4294967295, HighLevelState = new() { DeathFrameId = 4294967295 }, HealthState = new(), PhysicalMoveState = new() { Position = new(), Velocity = new(), IsOnGround = true, GroundNormal = new() { Z = 1.000000F } }, LookState = new() { LookDir = new() }, MoveState = new() { JumpStartFrameId = 4294967295, LandFrameId = 4294967295 }, UpperBodyState = new() { CurrentWeapon = new(), WantedWeapon = new(), InProgressWeapon = new(), LogicWantedWeapon = new(), CurrentWeaponAmmo = 10, CurrentWeaponAmmoCapacity = 10, SelectedConsumable = new() }, ScanningState = new(), InventoryState = new() { Slots = new(), ActiveSlot = -1 }, Abilities = new() { CanLook = new(), CanMove = new(), CanCrouch = new(), CanSprint = new(), CanSwitchWeapon = new(), CanHoldWeapon = new(), CanShoot = new(), CanAimDownSight = new() }, StateMachinesSnapshot = new() { StateMachines = new() }, ControllersSnapshot = new() { Controllers = new() }, SnapFrameId = 4294967295 };
			InitialOrientation = new();
			InitialLocation = new();
			Health = -1.000000F;
			Armor = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
