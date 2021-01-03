using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class speedometerLogicController : IVehicleModuleController
	{
		[Ordinal(0)]  [RED("speedBBConnectionId")] public CUInt32 SpeedBBConnectionId { get; set; }
		[Ordinal(1)]  [RED("speedTextWidget")] public inkTextWidgetReference SpeedTextWidget { get; set; }
		[Ordinal(2)]  [RED("vehBB")] public wCHandle<gameIBlackboard> VehBB { get; set; }
		[Ordinal(3)]  [RED("vehicle")] public wCHandle<vehicleBaseObject> Vehicle { get; set; }

		public speedometerLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
