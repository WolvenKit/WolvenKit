using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleVehicleSlotsState : ISerializable
	{
		private CEnum<vehicleVehicleDoorState> _vehicleDoorState;
		private CEnum<vehicleEVehicleWindowState> _vehicleWindowState;
		private CEnum<vehicleVehicleDoorInteractionState> _vehicleInteractionState;

		[Ordinal(0)] 
		[RED("vehicleDoorState")] 
		public CEnum<vehicleVehicleDoorState> VehicleDoorState
		{
			get
			{
				if (_vehicleDoorState == null)
				{
					_vehicleDoorState = (CEnum<vehicleVehicleDoorState>) CR2WTypeManager.Create("vehicleVehicleDoorState", "vehicleDoorState", cr2w, this);
				}
				return _vehicleDoorState;
			}
			set
			{
				if (_vehicleDoorState == value)
				{
					return;
				}
				_vehicleDoorState = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("vehicleWindowState")] 
		public CEnum<vehicleEVehicleWindowState> VehicleWindowState
		{
			get
			{
				if (_vehicleWindowState == null)
				{
					_vehicleWindowState = (CEnum<vehicleEVehicleWindowState>) CR2WTypeManager.Create("vehicleEVehicleWindowState", "vehicleWindowState", cr2w, this);
				}
				return _vehicleWindowState;
			}
			set
			{
				if (_vehicleWindowState == value)
				{
					return;
				}
				_vehicleWindowState = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("vehicleInteractionState")] 
		public CEnum<vehicleVehicleDoorInteractionState> VehicleInteractionState
		{
			get
			{
				if (_vehicleInteractionState == null)
				{
					_vehicleInteractionState = (CEnum<vehicleVehicleDoorInteractionState>) CR2WTypeManager.Create("vehicleVehicleDoorInteractionState", "vehicleInteractionState", cr2w, this);
				}
				return _vehicleInteractionState;
			}
			set
			{
				if (_vehicleInteractionState == value)
				{
					return;
				}
				_vehicleInteractionState = value;
				PropertySet(this);
			}
		}

		public vehicleVehicleSlotsState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
