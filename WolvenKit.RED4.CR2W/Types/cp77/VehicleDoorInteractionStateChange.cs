using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleDoorInteractionStateChange : ActionBool
	{
		private CEnum<vehicleEVehicleDoor> _door;
		private CEnum<vehicleVehicleDoorInteractionState> _newState;
		private CString _source;

		[Ordinal(25)] 
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

		[Ordinal(26)] 
		[RED("newState")] 
		public CEnum<vehicleVehicleDoorInteractionState> NewState
		{
			get
			{
				if (_newState == null)
				{
					_newState = (CEnum<vehicleVehicleDoorInteractionState>) CR2WTypeManager.Create("vehicleVehicleDoorInteractionState", "newState", cr2w, this);
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

		[Ordinal(27)] 
		[RED("source")] 
		public CString Source
		{
			get
			{
				if (_source == null)
				{
					_source = (CString) CR2WTypeManager.Create("String", "source", cr2w, this);
				}
				return _source;
			}
			set
			{
				if (_source == value)
				{
					return;
				}
				_source = value;
				PropertySet(this);
			}
		}

		public VehicleDoorInteractionStateChange(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
