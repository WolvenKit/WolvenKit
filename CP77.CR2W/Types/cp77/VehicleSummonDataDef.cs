using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VehicleSummonDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("GarageState")] public gamebbScriptID_Uint32 GarageState { get; set; }
		[Ordinal(1)]  [RED("UnlockedVehiclesCount")] public gamebbScriptID_Uint32 UnlockedVehiclesCount { get; set; }
		[Ordinal(2)]  [RED("SummonState")] public gamebbScriptID_Uint32 SummonState { get; set; }
		[Ordinal(3)]  [RED("SummonedVehicleEntityID")] public gamebbScriptID_EntityID SummonedVehicleEntityID { get; set; }

		public VehicleSummonDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
