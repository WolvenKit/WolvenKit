using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleQuestChangeDoorStateEvent : redEvent
	{
		private CEnum<vehicleEVehicleDoor> _door;
		private CEnum<vehicleEQuestVehicleDoorState> _newState;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("newState")] 
		public CEnum<vehicleEQuestVehicleDoorState> NewState
		{
			get
			{
				if (_newState == null)
				{
					_newState = (CEnum<vehicleEQuestVehicleDoorState>) CR2WTypeManager.Create("vehicleEQuestVehicleDoorState", "newState", cr2w, this);
				}
				return _newState;
			}
			set
			{
				if (_newState == value)
				{
					return;
				}
				_newState = value;
				PropertySet(this);
			}
		}

		public VehicleQuestChangeDoorStateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
