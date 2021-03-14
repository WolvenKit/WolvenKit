using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleControllerPS : gameComponentPS
	{
		private CStatic<vehicleVehicleSlotsState> _vehicleDoors;
		private CEnum<vehicleEState> _state;
		private CEnum<vehicleELightMode> _lightMode;
		private CBool _isAlarmOn;

		[Ordinal(0)] 
		[RED("vehicleDoors", 6)] 
		public CStatic<vehicleVehicleSlotsState> VehicleDoors
		{
			get
			{
				if (_vehicleDoors == null)
				{
					_vehicleDoors = (CStatic<vehicleVehicleSlotsState>) CR2WTypeManager.Create("static:6,vehicleVehicleSlotsState", "vehicleDoors", cr2w, this);
				}
				return _vehicleDoors;
			}
			set
			{
				if (_vehicleDoors == value)
				{
					return;
				}
				_vehicleDoors = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<vehicleEState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<vehicleEState>) CR2WTypeManager.Create("vehicleEState", "state", cr2w, this);
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

		[Ordinal(2)] 
		[RED("lightMode")] 
		public CEnum<vehicleELightMode> LightMode
		{
			get
			{
				if (_lightMode == null)
				{
					_lightMode = (CEnum<vehicleELightMode>) CR2WTypeManager.Create("vehicleELightMode", "lightMode", cr2w, this);
				}
				return _lightMode;
			}
			set
			{
				if (_lightMode == value)
				{
					return;
				}
				_lightMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isAlarmOn")] 
		public CBool IsAlarmOn
		{
			get
			{
				if (_isAlarmOn == null)
				{
					_isAlarmOn = (CBool) CR2WTypeManager.Create("Bool", "isAlarmOn", cr2w, this);
				}
				return _isAlarmOn;
			}
			set
			{
				if (_isAlarmOn == value)
				{
					return;
				}
				_isAlarmOn = value;
				PropertySet(this);
			}
		}

		public vehicleControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
