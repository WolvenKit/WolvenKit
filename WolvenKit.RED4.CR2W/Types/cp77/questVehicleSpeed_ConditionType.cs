using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questVehicleSpeed_ConditionType : questIVehicleConditionType
	{
		private gameEntityReference _vehicleRef;
		private CFloat _speed;
		private CEnum<vehicleEVehicleSpeedConditionType> _comparisonType;

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
		[RED("speed")] 
		public CFloat Speed
		{
			get
			{
				if (_speed == null)
				{
					_speed = (CFloat) CR2WTypeManager.Create("Float", "speed", cr2w, this);
				}
				return _speed;
			}
			set
			{
				if (_speed == value)
				{
					return;
				}
				_speed = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("comparisonType")] 
		public CEnum<vehicleEVehicleSpeedConditionType> ComparisonType
		{
			get
			{
				if (_comparisonType == null)
				{
					_comparisonType = (CEnum<vehicleEVehicleSpeedConditionType>) CR2WTypeManager.Create("vehicleEVehicleSpeedConditionType", "comparisonType", cr2w, this);
				}
				return _comparisonType;
			}
			set
			{
				if (_comparisonType == value)
				{
					return;
				}
				_comparisonType = value;
				PropertySet(this);
			}
		}

		public questVehicleSpeed_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
