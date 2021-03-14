using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetState : CVariable
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
			get
			{
				if (_frameId == null)
				{
					_frameId = (CUInt32) CR2WTypeManager.Create("Uint32", "frameId", cr2w, this);
				}
				return _frameId;
			}
			set
			{
				if (_frameId == value)
				{
					return;
				}
				_frameId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("highLevelState")] 
		public gameMuppetHighLevelState HighLevelState
		{
			get
			{
				if (_highLevelState == null)
				{
					_highLevelState = (gameMuppetHighLevelState) CR2WTypeManager.Create("gameMuppetHighLevelState", "highLevelState", cr2w, this);
				}
				return _highLevelState;
			}
			set
			{
				if (_highLevelState == value)
				{
					return;
				}
				_highLevelState = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("healthState")] 
		public gameMuppetHealthState HealthState
		{
			get
			{
				if (_healthState == null)
				{
					_healthState = (gameMuppetHealthState) CR2WTypeManager.Create("gameMuppetHealthState", "healthState", cr2w, this);
				}
				return _healthState;
			}
			set
			{
				if (_healthState == value)
				{
					return;
				}
				_healthState = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("physicalMoveState")] 
		public gameMuppetPhysicalState PhysicalMoveState
		{
			get
			{
				if (_physicalMoveState == null)
				{
					_physicalMoveState = (gameMuppetPhysicalState) CR2WTypeManager.Create("gameMuppetPhysicalState", "physicalMoveState", cr2w, this);
				}
				return _physicalMoveState;
			}
			set
			{
				if (_physicalMoveState == value)
				{
					return;
				}
				_physicalMoveState = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("lookState")] 
		public gameMuppetLookState LookState
		{
			get
			{
				if (_lookState == null)
				{
					_lookState = (gameMuppetLookState) CR2WTypeManager.Create("gameMuppetLookState", "lookState", cr2w, this);
				}
				return _lookState;
			}
			set
			{
				if (_lookState == value)
				{
					return;
				}
				_lookState = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("moveState")] 
		public gameMuppetMoveState MoveState
		{
			get
			{
				if (_moveState == null)
				{
					_moveState = (gameMuppetMoveState) CR2WTypeManager.Create("gameMuppetMoveState", "moveState", cr2w, this);
				}
				return _moveState;
			}
			set
			{
				if (_moveState == value)
				{
					return;
				}
				_moveState = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("upperBodyState")] 
		public gameMuppetUpperBodyState UpperBodyState
		{
			get
			{
				if (_upperBodyState == null)
				{
					_upperBodyState = (gameMuppetUpperBodyState) CR2WTypeManager.Create("gameMuppetUpperBodyState", "upperBodyState", cr2w, this);
				}
				return _upperBodyState;
			}
			set
			{
				if (_upperBodyState == value)
				{
					return;
				}
				_upperBodyState = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("scanningState")] 
		public gameMuppetScanningState ScanningState
		{
			get
			{
				if (_scanningState == null)
				{
					_scanningState = (gameMuppetScanningState) CR2WTypeManager.Create("gameMuppetScanningState", "scanningState", cr2w, this);
				}
				return _scanningState;
			}
			set
			{
				if (_scanningState == value)
				{
					return;
				}
				_scanningState = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("inventoryState")] 
		public gameMuppetInventoryState InventoryState
		{
			get
			{
				if (_inventoryState == null)
				{
					_inventoryState = (gameMuppetInventoryState) CR2WTypeManager.Create("gameMuppetInventoryState", "inventoryState", cr2w, this);
				}
				return _inventoryState;
			}
			set
			{
				if (_inventoryState == value)
				{
					return;
				}
				_inventoryState = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("abilities")] 
		public gameMuppetAbilities Abilities
		{
			get
			{
				if (_abilities == null)
				{
					_abilities = (gameMuppetAbilities) CR2WTypeManager.Create("gameMuppetAbilities", "abilities", cr2w, this);
				}
				return _abilities;
			}
			set
			{
				if (_abilities == value)
				{
					return;
				}
				_abilities = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("stateMachinesSnapshot")] 
		public gameMuppetStateMachinesSnapshot StateMachinesSnapshot
		{
			get
			{
				if (_stateMachinesSnapshot == null)
				{
					_stateMachinesSnapshot = (gameMuppetStateMachinesSnapshot) CR2WTypeManager.Create("gameMuppetStateMachinesSnapshot", "stateMachinesSnapshot", cr2w, this);
				}
				return _stateMachinesSnapshot;
			}
			set
			{
				if (_stateMachinesSnapshot == value)
				{
					return;
				}
				_stateMachinesSnapshot = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("controllersSnapshot")] 
		public gameMuppetControllersSnapshot ControllersSnapshot
		{
			get
			{
				if (_controllersSnapshot == null)
				{
					_controllersSnapshot = (gameMuppetControllersSnapshot) CR2WTypeManager.Create("gameMuppetControllersSnapshot", "controllersSnapshot", cr2w, this);
				}
				return _controllersSnapshot;
			}
			set
			{
				if (_controllersSnapshot == value)
				{
					return;
				}
				_controllersSnapshot = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("snapFrameId")] 
		public CUInt32 SnapFrameId
		{
			get
			{
				if (_snapFrameId == null)
				{
					_snapFrameId = (CUInt32) CR2WTypeManager.Create("Uint32", "snapFrameId", cr2w, this);
				}
				return _snapFrameId;
			}
			set
			{
				if (_snapFrameId == value)
				{
					return;
				}
				_snapFrameId = value;
				PropertySet(this);
			}
		}

		public gameMuppetState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
