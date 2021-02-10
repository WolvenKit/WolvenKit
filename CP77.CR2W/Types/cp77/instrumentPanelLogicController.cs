using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class instrumentPanelLogicController : IVehicleModuleController
	{
		[Ordinal(0)]  [RED("lightStateImageWidget")] public inkImageWidgetReference LightStateImageWidget { get; set; }
		[Ordinal(1)]  [RED("cautionStateImageWidget")] public inkImageWidgetReference CautionStateImageWidget { get; set; }
		[Ordinal(2)]  [RED("lightStateBBConnectionId")] public CUInt32 LightStateBBConnectionId { get; set; }
		[Ordinal(3)]  [RED("cautionStateBBConnectionId")] public CUInt32 CautionStateBBConnectionId { get; set; }
		[Ordinal(4)]  [RED("vehBB")] public wCHandle<gameIBlackboard> VehBB { get; set; }

		public instrumentPanelLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
