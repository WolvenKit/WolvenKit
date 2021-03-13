using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CarHotkeyController : GenericHotkeyController
	{
		[Ordinal(19)] [RED("carIconSlot")] public inkImageWidgetReference CarIconSlot { get; set; }
		[Ordinal(20)] [RED("vehicleSystem")] public wCHandle<gameVehicleSystem> VehicleSystem { get; set; }
		[Ordinal(21)] [RED("psmBB")] public CHandle<gameIBlackboard> PsmBB { get; set; }
		[Ordinal(22)] [RED("bbListener")] public CUInt32 BbListener { get; set; }

		public CarHotkeyController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
