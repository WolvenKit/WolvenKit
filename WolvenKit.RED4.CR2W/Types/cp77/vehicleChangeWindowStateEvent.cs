using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleChangeWindowStateEvent : redEvent
	{
		private CEnum<vehicleEQuestVehicleWindowState> _state;
		private CEnum<vehicleEVehicleDoor> _door;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<vehicleEQuestVehicleWindowState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<vehicleEQuestVehicleWindowState>) CR2WTypeManager.Create("vehicleEQuestVehicleWindowState", "state", cr2w, this);
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

		public vehicleChangeWindowStateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
