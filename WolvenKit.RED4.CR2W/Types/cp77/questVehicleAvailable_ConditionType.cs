using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questVehicleAvailable_ConditionType : questIVehicleConditionType
	{
		private CEnum<questAvailableVehicleType> _vehicleType;
		private CString _vehicleName;

		[Ordinal(0)] 
		[RED("vehicleType")] 
		public CEnum<questAvailableVehicleType> VehicleType
		{
			get
			{
				if (_vehicleType == null)
				{
					_vehicleType = (CEnum<questAvailableVehicleType>) CR2WTypeManager.Create("questAvailableVehicleType", "vehicleType", cr2w, this);
				}
				return _vehicleType;
			}
			set
			{
				if (_vehicleType == value)
				{
					return;
				}
				_vehicleType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("vehicleName")] 
		public CString VehicleName
		{
			get
			{
				if (_vehicleName == null)
				{
					_vehicleName = (CString) CR2WTypeManager.Create("String", "vehicleName", cr2w, this);
				}
				return _vehicleName;
			}
			set
			{
				if (_vehicleName == value)
				{
					return;
				}
				_vehicleName = value;
				PropertySet(this);
			}
		}

		public questVehicleAvailable_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
