using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CarHotkeyController : GenericHotkeyController
	{
		[Ordinal(17)]  [RED("carIconSlot")] public inkImageWidgetReference CarIconSlot { get; set; }
		[Ordinal(18)]  [RED("vehicleSystem")] public wCHandle<gameVehicleSystem> VehicleSystem { get; set; }
		[Ordinal(19)]  [RED("psmBB")] public CHandle<gameIBlackboard> PsmBB { get; set; }
		[Ordinal(20)]  [RED("bbListener")] public CUInt32 BbListener { get; set; }

		public CarHotkeyController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
