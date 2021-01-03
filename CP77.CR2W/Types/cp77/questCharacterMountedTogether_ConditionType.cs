using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questCharacterMountedTogether_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)]  [RED("characters")] public CArray<CHandle<questMountedObjectInfo>> Characters { get; set; }
		[Ordinal(1)]  [RED("vehicleOrigin")] public CEnum<questMountVehicleOrigin> VehicleOrigin { get; set; }
		[Ordinal(2)]  [RED("vehicleType")] public CEnum<questMountVehicleType> VehicleType { get; set; }

		public questCharacterMountedTogether_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
