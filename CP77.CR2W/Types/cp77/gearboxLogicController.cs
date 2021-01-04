using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gearboxLogicController : IVehicleModuleController
	{
		[Ordinal(0)]  [RED("gearboxBBConnectionId")] public CUInt32 GearboxBBConnectionId { get; set; }
		[Ordinal(1)]  [RED("gearboxDImageWidget")] public inkImageWidgetReference GearboxDImageWidget { get; set; }
		[Ordinal(2)]  [RED("gearboxNImageWidget")] public inkImageWidgetReference GearboxNImageWidget { get; set; }
		[Ordinal(3)]  [RED("gearboxRImageWidget")] public inkImageWidgetReference GearboxRImageWidget { get; set; }
		[Ordinal(4)]  [RED("vehBB")] public wCHandle<gameIBlackboard> VehBB { get; set; }

		public gearboxLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
