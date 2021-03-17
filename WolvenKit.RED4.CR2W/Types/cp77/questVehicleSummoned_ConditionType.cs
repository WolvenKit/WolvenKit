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
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		public questVehicleSummoned_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
