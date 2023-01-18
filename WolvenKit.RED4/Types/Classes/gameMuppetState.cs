using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMuppetState : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("frameId")] 
		public CUInt32 FrameId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("highLevelState")] 
		public gameMuppetHighLevelState HighLevelState
		{
			get => GetPropertyValue<gameMuppetHighLevelState>();
			set => SetPropertyValue<gameMuppetHighLevelState>(value);
		}

		[Ordinal(2)] 
		[RED("healthState")] 
		public gameMuppetHealthState HealthState
		{
			get => GetPropertyValue<gameMuppetHealthState>();
			set => SetPropertyValue<gameMuppetHealthState>(value);
		}

		[Ordinal(3)] 
		[RED("physicalMoveState")] 
		public gameMuppetPhysicalState PhysicalMoveState
		{
			get => GetPropertyValue<gameMuppetPhysicalState>();
			set => SetPropertyValue<gameMuppetPhysicalState>(value);
		}

		[Ordinal(4)] 
		[RED("lookState")] 
		public gameMuppetLookState LookState
		{
			get => GetPropertyValue<gameMuppetLookState>();
			set => SetPropertyValue<gameMuppetLookState>(value);
		}

		[Ordinal(5)] 
		[RED("moveState")] 
		public gameMuppetMoveState MoveState
		{
			get => GetPropertyValue<gameMuppetMoveState>();
			set => SetPropertyValue<gameMuppetMoveState>(value);
		}

		[Ordinal(6)] 
		[RED("upperBodyState")] 
		public gameMuppetUpperBodyState UpperBodyState
		{
			get => GetPropertyValue<gameMuppetUpperBodyState>();
			set => SetPropertyValue<gameMuppetUpperBodyState>(value);
		}

		[Ordinal(7)] 
		[RED("scanningState")] 
		public gameMuppetScanningState ScanningState
		{
			get => GetPropertyValue<gameMuppetScanningState>();
			set => SetPropertyValue<gameMuppetScanningState>(value);
		}

		[Ordinal(8)] 
		[RED("inventoryState")] 
		public gameMuppetInventoryState InventoryState
		{
			get => GetPropertyValue<gameMuppetInventoryState>();
			set => SetPropertyValue<gameMuppetInventoryState>(value);
		}

		[Ordinal(9)] 
		[RED("abilities")] 
		public gameMuppetAbilities Abilities
		{
			get => GetPropertyValue<gameMuppetAbilities>();
			set => SetPropertyValue<gameMuppetAbilities>(value);
		}

		[Ordinal(10)] 
		[RED("stateMachinesSnapshot")] 
		public gameMuppetStateMachinesSnapshot StateMachinesSnapshot
		{
			get => GetPropertyValue<gameMuppetStateMachinesSnapshot>();
			set => SetPropertyValue<gameMuppetStateMachinesSnapshot>(value);
		}

		[Ordinal(11)] 
		[RED("controllersSnapshot")] 
		public gameMuppetControllersSnapshot ControllersSnapshot
		{
			get => GetPropertyValue<gameMuppetControllersSnapshot>();
			set => SetPropertyValue<gameMuppetControllersSnapshot>(value);
		}

		[Ordinal(12)] 
		[RED("snapFrameId")] 
		public CUInt32 SnapFrameId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameMuppetState()
		{
			FrameId = 4294967295;
			HighLevelState = new() { DeathFrameId = 4294967295 };
			HealthState = new();
			PhysicalMoveState = new() { Position = new(), Velocity = new(), IsOnGround = true, GroundNormal = new() { Z = 1.000000F } };
			LookState = new() { LookDir = new() };
			MoveState = new() { JumpStartFrameId = 4294967295, LandFrameId = 4294967295 };
			UpperBodyState = new() { CurrentWeapon = new(), WantedWeapon = new(), InProgressWeapon = new(), LogicWantedWeapon = new(), CurrentWeaponAmmo = 10, CurrentWeaponAmmoCapacity = 10, SelectedConsumable = new() };
			ScanningState = new();
			InventoryState = new() { Slots = new(), ActiveSlot = -1 };
			Abilities = new() { CanLook = new(), CanMove = new(), CanCrouch = new(), CanSprint = new(), CanSwitchWeapon = new(), CanHoldWeapon = new(), CanShoot = new(), CanAimDownSight = new() };
			StateMachinesSnapshot = new() { StateMachines = new() };
			ControllersSnapshot = new() { Controllers = new() };
			SnapFrameId = 4294967295;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
