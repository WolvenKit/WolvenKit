using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questVehicleSummoned_ConditionType : questIVehicleConditionType
	{
		private CEnum<vehicleESummonedVehicleType> _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<vehicleESummonedVehicleType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<vehicleESummonedVehicleType>) CR2WTypeManager.Create("vehicleESummonedVehicleType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		public questVehicleSummoned_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
