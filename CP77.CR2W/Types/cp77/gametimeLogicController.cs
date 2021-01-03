using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gametimeLogicController : IVehicleModuleController
	{
		[Ordinal(0)]  [RED("gametimeBBConnectionId")] public CUInt32 GametimeBBConnectionId { get; set; }
		[Ordinal(1)]  [RED("gametimeTextWidget")] public inkTextWidgetReference GametimeTextWidget { get; set; }
		[Ordinal(2)]  [RED("parent")] public wCHandle<vehicleUIGameController> Parent { get; set; }
		[Ordinal(3)]  [RED("vehBB")] public wCHandle<gameIBlackboard> VehBB { get; set; }
		[Ordinal(4)]  [RED("vehicle")] public wCHandle<vehicleBaseObject> Vehicle { get; set; }

		public gametimeLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
