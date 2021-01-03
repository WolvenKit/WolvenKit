using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CarHotkeyController : GenericHotkeyController
	{
		[Ordinal(0)]  [RED("bbListener")] public CUInt32 BbListener { get; set; }
		[Ordinal(1)]  [RED("carIconSlot")] public inkImageWidgetReference CarIconSlot { get; set; }
		[Ordinal(2)]  [RED("psmBB")] public CHandle<gameIBlackboard> PsmBB { get; set; }
		[Ordinal(3)]  [RED("vehicleSystem")] public wCHandle<gameVehicleSystem> VehicleSystem { get; set; }

		public CarHotkeyController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
