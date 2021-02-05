using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questToggleWeaponEnabled_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)]  [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
		[Ordinal(1)]  [RED("playerVehicle")] public CBool PlayerVehicle { get; set; }
		[Ordinal(2)]  [RED("val")] public CBool Val { get; set; }
		[Ordinal(3)]  [RED("weapon")] public CEnum<questVehicleWeaponQuestID> Weapon { get; set; }

		public questToggleWeaponEnabled_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
