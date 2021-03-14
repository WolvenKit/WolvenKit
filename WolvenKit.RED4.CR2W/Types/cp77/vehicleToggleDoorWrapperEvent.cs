using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleToggleDoorWrapperEvent : redEvent
	{
		private CEnum<vehicleEQuestVehicleDoorState> _action;
		private CEnum<vehicleEVehicleDoor> _door;

		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<vehicleEQuestVehicleDoorState> Action
		{
			get
			{
				if (_action == null)
				{
					_action = (CEnum<vehicleEQuestVehicleDoorState>) CR2WTypeManager.Create("vehicleEQuestVehicleDoorState", "action", cr2w, this);
				}
				return _action;
			}
			set
			{
				if (_action == value)
				{
					return;
				}
				_action = value;
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

		public vehicleToggleDoorWrapperEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
