using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class speedometerLogicController : IVehicleModuleController
	{
		[Ordinal(1)] [RED("speedTextWidget")] public inkTextWidgetReference SpeedTextWidget { get; set; }
		[Ordinal(2)] [RED("speedBBConnectionId")] public CUInt32 SpeedBBConnectionId { get; set; }
		[Ordinal(3)] [RED("vehBB")] public wCHandle<gameIBlackboard> VehBB { get; set; }
		[Ordinal(4)] [RED("vehicle")] public wCHandle<vehicleBaseObject> Vehicle { get; set; }

		public speedometerLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
