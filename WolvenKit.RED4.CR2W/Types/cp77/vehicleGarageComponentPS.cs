using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleGarageComponentPS : gameComponentPS
	{
		[Ordinal(0)] [RED("spawnedVehiclesData")] public CArray<vehicleGarageComponentVehicleData> SpawnedVehiclesData { get; set; }
		[Ordinal(1)] [RED("unlockedVehicles")] public CArray<vehicleGarageVehicleID> UnlockedVehicles { get; set; }
		[Ordinal(2)] [RED("unlockedVehicleArray")] public CArray<vehicleUnlockedVehicle> UnlockedVehicleArray { get; set; }
		[Ordinal(3)] [RED("activeVehicles", 3)] public CStatic<vehicleGarageVehicleID> ActiveVehicles { get; set; }
		[Ordinal(4)] [RED("mountedVehicleData")] public vehicleGarageComponentVehicleData MountedVehicleData { get; set; }
		[Ordinal(5)] [RED("mountedVehicleStolen")] public CBool MountedVehicleStolen { get; set; }

		public vehicleGarageComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
