using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuickSlotsManagerPS : gameComponentPS
	{
		[Ordinal(0)] [RED("activeVehicleType")] public CEnum<gamedataVehicleType> ActiveVehicleType { get; set; }

		public QuickSlotsManagerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
