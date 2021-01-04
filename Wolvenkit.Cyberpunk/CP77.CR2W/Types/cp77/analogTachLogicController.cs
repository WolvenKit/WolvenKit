using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class analogTachLogicController : IVehicleModuleController
	{
		[Ordinal(0)]  [RED("analogTachNeedleMaxRotation")] public CFloat AnalogTachNeedleMaxRotation { get; set; }
		[Ordinal(1)]  [RED("analogTachNeedleMinRotation")] public CFloat AnalogTachNeedleMinRotation { get; set; }
		[Ordinal(2)]  [RED("analogTachNeedleWidget")] public inkWidgetReference AnalogTachNeedleWidget { get; set; }
		[Ordinal(3)]  [RED("rpmMaxValue")] public CFloat RpmMaxValue { get; set; }
		[Ordinal(4)]  [RED("rpmMinValue")] public CFloat RpmMinValue { get; set; }
		[Ordinal(5)]  [RED("rpmValueBBConnectionId")] public CUInt32 RpmValueBBConnectionId { get; set; }
		[Ordinal(6)]  [RED("vehBB")] public wCHandle<gameIBlackboard> VehBB { get; set; }

		public analogTachLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
