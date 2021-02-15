using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioVehicleWheelData : CVariable
	{
		[Ordinal(0)] [RED("wheelStartEvents")] public CArray<CName> WheelStartEvents { get; set; }
		[Ordinal(1)] [RED("wheelStopEvents")] public CArray<CName> WheelStopEvents { get; set; }
		[Ordinal(2)] [RED("wheelRegularSuspensionImpacts")] public CArray<CName> WheelRegularSuspensionImpacts { get; set; }
		[Ordinal(3)] [RED("wheelLandingSuspensionImpacts")] public CArray<CName> WheelLandingSuspensionImpacts { get; set; }
		[Ordinal(4)] [RED("suspensionPressureMultiplier")] public CFloat SuspensionPressureMultiplier { get; set; }
		[Ordinal(5)] [RED("landingSuspensionPressureMultiplier")] public CFloat LandingSuspensionPressureMultiplier { get; set; }
		[Ordinal(6)] [RED("suspensionPressureLimit")] public CFloat SuspensionPressureLimit { get; set; }
		[Ordinal(7)] [RED("minSuspensionPressureThreshold")] public CFloat MinSuspensionPressureThreshold { get; set; }
		[Ordinal(8)] [RED("suspensionImpactCooldown")] public CFloat SuspensionImpactCooldown { get; set; }
		[Ordinal(9)] [RED("minWheelTimeInAirBeforeLanding")] public CFloat MinWheelTimeInAirBeforeLanding { get; set; }

		public audioVehicleWheelData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
