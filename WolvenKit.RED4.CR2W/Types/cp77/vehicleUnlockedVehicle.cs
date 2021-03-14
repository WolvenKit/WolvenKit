using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleUnlockedVehicle : CVariable
	{
		private vehicleGarageVehicleID _vehicleID;
		private CFloat _health;

		[Ordinal(0)] 
		[RED("vehicleID")] 
		public vehicleGarageVehicleID VehicleID
		{
			get
			{
				if (_vehicleID == null)
				{
					_vehicleID = (vehicleGarageVehicleID) CR2WTypeManager.Create("vehicleGarageVehicleID", "vehicleID", cr2w, this);
				}
				return _vehicleID;
			}
			set
			{
				if (_vehicleID == value)
				{
					return;
				}
				_vehicleID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("health")] 
		public CFloat Health
		{
			get
			{
				if (_health == null)
				{
					_health = (CFloat) CR2WTypeManager.Create("Float", "health", cr2w, this);
				}
				return _health;
			}
			set
			{
				if (_health == value)
				{
					return;
				}
				_health = value;
				PropertySet(this);
			}
		}

		public vehicleUnlockedVehicle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
