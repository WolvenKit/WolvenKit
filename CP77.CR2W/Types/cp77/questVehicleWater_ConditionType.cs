using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questVehicleWater_ConditionType : questIVehicleConditionType
	{
		[Ordinal(0)] [RED("submergedOnly")] public CBool SubmergedOnly { get; set; }
		[Ordinal(1)] [RED("onEnter")] public CBool OnEnter { get; set; }

		public questVehicleWater_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
