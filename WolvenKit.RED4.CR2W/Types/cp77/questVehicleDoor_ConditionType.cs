using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questVehicleDoor_ConditionType : questIVehicleConditionType
	{
		private gameEntityReference _vehicleRef;
		private CEnum<vehicleEVehicleDoor> _door;
		private CEnum<vehicleVehicleDoorState> _state;

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

		[Ordinal(2)] 
		[RED("state")] 
		public CEnum<vehicleVehicleDoorState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<vehicleVehicleDoorState>) CR2WTypeManager.Create("vehicleVehicleDoorState", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		public questVehicleDoor_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
