using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class analogSpeedometerLogicController : IVehicleModuleController
	{
		[Ordinal(0)]  [RED("analogSpeedNeedleWidget")] public inkWidgetReference AnalogSpeedNeedleWidget { get; set; }
		[Ordinal(1)]  [RED("analogSpeedNeedleMinRotation")] public CFloat AnalogSpeedNeedleMinRotation { get; set; }
		[Ordinal(2)]  [RED("analogSpeedNeedleMaxRotation")] public CFloat AnalogSpeedNeedleMaxRotation { get; set; }
		[Ordinal(3)]  [RED("analogSpeedNeedleMaxValue")] public CFloat AnalogSpeedNeedleMaxValue { get; set; }
		[Ordinal(4)]  [RED("speedBBConnectionId")] public CUInt32 SpeedBBConnectionId { get; set; }
		[Ordinal(5)]  [RED("vehBB")] public wCHandle<gameIBlackboard> VehBB { get; set; }
		[Ordinal(6)]  [RED("vehicle")] public wCHandle<vehicleBaseObject> Vehicle { get; set; }

		public analogSpeedometerLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
