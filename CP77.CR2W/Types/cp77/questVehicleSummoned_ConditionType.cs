using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questVehicleSummoned_ConditionType : questIVehicleConditionType
	{
		[Ordinal(0)]  [RED("type")] public CEnum<vehicleESummonedVehicleType> Type { get; set; }

		public questVehicleSummoned_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
