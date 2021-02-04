using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questVehicleTrunk_ConditionType : questIVehicleConditionType
	{
		[Ordinal(0)]  [RED("anyVehicle")] public CBool AnyVehicle { get; set; }
		[Ordinal(1)]  [RED("playerVehicle")] public CBool PlayerVehicle { get; set; }
		[Ordinal(2)]  [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
		[Ordinal(3)]  [RED("anyObject")] public CBool AnyObject { get; set; }
		[Ordinal(4)]  [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
		[Ordinal(5)]  [RED("inverted")] public CBool Inverted { get; set; }
		[Ordinal(6)]  [RED("isInside")] public CBool IsInside { get; set; }

		public questVehicleTrunk_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
