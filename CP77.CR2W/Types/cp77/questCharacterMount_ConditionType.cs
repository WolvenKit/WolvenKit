using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questCharacterMount_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)]  [RED("parentRef")] public gameEntityReference ParentRef { get; set; }
		[Ordinal(1)]  [RED("parentIsPlayer")] public CBool ParentIsPlayer { get; set; }
		[Ordinal(2)]  [RED("condition")] public CEnum<questMountConditionType> Condition { get; set; }
		[Ordinal(3)]  [RED("role")] public CEnum<gameMountingSlotRole> Role { get; set; }
		[Ordinal(4)]  [RED("vehicleType")] public CEnum<questMountVehicleType> VehicleType { get; set; }
		[Ordinal(5)]  [RED("vehicleOrigin")] public CEnum<questMountVehicleOrigin> VehicleOrigin { get; set; }
		[Ordinal(6)]  [RED("playerVehicleName")] public CString PlayerVehicleName { get; set; }
		[Ordinal(7)]  [RED("usePlayersVehicle")] public CBool UsePlayersVehicle { get; set; }
		[Ordinal(8)]  [RED("anyParent")] public CBool AnyParent { get; set; }
		[Ordinal(9)]  [RED("anyChild")] public CBool AnyChild { get; set; }
		[Ordinal(10)]  [RED("enterAnimationFinished")] public CBool EnterAnimationFinished { get; set; }

        [Ordinal(998)] [RED("childRef")] public gameEntityReference ChildRef { get; set; }
		[Ordinal(999)] [RED("childIsPlayer")] public CBool ChildIsPlayer { get; set; }

		public questCharacterMount_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
