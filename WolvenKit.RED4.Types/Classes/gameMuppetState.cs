using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetState : RedBaseClass
	{
		private CUInt32 _frameId;
		private gameMuppetHighLevelState _highLevelState;
		private gameMuppetHealthState _healthState;
		private gameMuppetPhysicalState _physicalMoveState;
		private gameMuppetLookState _lookState;
		private gameMuppetMoveState _moveState;
		private gameMuppetUpperBodyState _upperBodyState;
		private gameMuppetScanningState _scanningState;
		private gameMuppetInventoryState _inventoryState;
		private gameMuppetAbilities _abilities;
		private gameMuppetStateMachinesSnapshot _stateMachinesSnapshot;
		private gameMuppetControllersSnapshot _controllersSnapshot;
		private CUInt32 _snapFrameId;

		[Ordinal(0)] 
		[RED("frameId")] 
		public CUInt32 FrameId
		{
			get => GetProperty(ref _frameId);
			set => SetProperty(ref _frameId, value);
		}

		[Ordinal(1)] 
		[RED("highLevelState")] 
		public gameMuppetHighLevelState HighLevelState
		{
			get => GetProperty(ref _highLevelState);
			set => SetProperty(ref _highLevelState, value);
		}

		[Ordinal(2)] 
		[RED("healthState")] 
		public gameMuppetHealthState HealthState
		{
			get => GetProperty(ref _healthState);
			set => SetProperty(ref _healthState, value);
		}

		[Ordinal(3)] 
		[RED("physicalMoveState")] 
		public gameMuppetPhysicalState PhysicalMoveState
		{
			get => GetProperty(ref _physicalMoveState);
			set => SetProperty(ref _physicalMoveState, value);
		}

		[Ordinal(4)] 
		[RED("lookState")] 
		public gameMuppetLookState LookState
		{
			get => GetProperty(ref _lookState);
			set => SetProperty(ref _lookState, value);
		}

		[Ordinal(5)] 
		[RED("moveState")] 
		public gameMuppetMoveState MoveState
		{
			get => GetProperty(ref _moveState);
			set => SetProperty(ref _moveState, value);
		}

		[Ordinal(6)] 
		[RED("upperBodyState")] 
		public gameMuppetUpperBodyState UpperBodyState
		{
			get => GetProperty(ref _upperBodyState);
			set => SetProperty(ref _upperBodyState, value);
		}

		[Ordinal(7)] 
		[RED("scanningState")] 
		public gameMuppetScanningState ScanningState
		{
			get => GetProperty(ref _scanningState);
			set => SetProperty(ref _scanningState, value);
		}

		[Ordinal(8)] 
		[RED("inventoryState")] 
		public gameMuppetInventoryState InventoryState
		{
			get => GetProperty(ref _inventoryState);
			set => SetProperty(ref _inventoryState, value);
		}

		[Ordinal(9)] 
		[RED("abilities")] 
		public gameMuppetAbilities Abilities
		{
			get => GetProperty(ref _abilities);
			set => SetProperty(ref _abilities, value);
		}

		[Ordinal(10)] 
		[RED("stateMachinesSnapshot")] 
		public gameMuppetStateMachinesSnapshot StateMachinesSnapshot
		{
			get => GetProperty(ref _stateMachinesSnapshot);
			set => SetProperty(ref _stateMachinesSnapshot, value);
		}

		[Ordinal(11)] 
		[RED("controllersSnapshot")] 
		public gameMuppetControllersSnapshot ControllersSnapshot
		{
			get => GetProperty(ref _controllersSnapshot);
			set => SetProperty(ref _controllersSnapshot, value);
		}

		[Ordinal(12)] 
		[RED("snapFrameId")] 
		public CUInt32 SnapFrameId
		{
			get => GetProperty(ref _snapFrameId);
			set => SetProperty(ref _snapFrameId, value);
		}
	}
}
