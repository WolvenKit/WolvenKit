using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questToggleDoor_NodeType : questIVehicleManagerNodeType
	{
		private gameEntityReference _vehicleRef;
		private CEnum<vehicleEQuestVehicleDoorState> _doorAction;
		private CEnum<vehicleEVehicleDoor> _door;
		private CBool _toOpen;
		private CName _doorID;

		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get
			{
				if (_vehicleRef == null)
				{
					_vehicleRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "vehicleRef", cr2w, this);
				}
				return _vehicleRef;
			}
			set
			{
				if (_vehicleRef == value)
				{
					return;
				}
				_vehicleRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("doorAction")] 
		public CEnum<vehicleEQuestVehicleDoorState> DoorAction
		{
			get
			{
				if (_doorAction == null)
				{
					_doorAction = (CEnum<vehicleEQuestVehicleDoorState>) CR2WTypeManager.Create("vehicleEQuestVehicleDoorState", "doorAction", cr2w, this);
				}
				return _doorAction;
			}
			set
			{
				if (_doorAction == value)
				{
					return;
				}
				_doorAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("door")] 
		public CEnum<vehicleEVehicleDoor> Door
		{
			get
			{
				if (_door == null)
				{
					_door = (CEnum<vehicleEVehicleDoor>) CR2WTypeManager.Create("vehicleEVehicleDoor", "door", cr2w, this);
				}
				return _door;
			}
			set
			{
				if (_door == value)
				{
					return;
				}
				_door = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("toOpen")] 
		public CBool ToOpen
		{
			get
			{
				if (_toOpen == null)
				{
					_toOpen = (CBool) CR2WTypeManager.Create("Bool", "toOpen", cr2w, this);
				}
				return _toOpen;
			}
			set
			{
				if (_toOpen == value)
				{
					return;
				}
				_toOpen = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("doorID")] 
		public CName DoorID
		{
			get
			{
				if (_doorID == null)
				{
					_doorID = (CName) CR2WTypeManager.Create("CName", "doorID", cr2w, this);
				}
				return _doorID;
			}
			set
			{
				if (_doorID == value)
				{
					return;
				}
				_doorID = value;
				PropertySet(this);
			}
		}

		public questToggleDoor_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
