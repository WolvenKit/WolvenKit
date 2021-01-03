using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class instrumentPanelLogicController : IVehicleModuleController
	{
		[Ordinal(0)]  [RED("cautionStateBBConnectionId")] public CUInt32 CautionStateBBConnectionId { get; set; }
		[Ordinal(1)]  [RED("cautionStateImageWidget")] public inkImageWidgetReference CautionStateImageWidget { get; set; }
		[Ordinal(2)]  [RED("lightStateBBConnectionId")] public CUInt32 LightStateBBConnectionId { get; set; }
		[Ordinal(3)]  [RED("lightStateImageWidget")] public inkImageWidgetReference LightStateImageWidget { get; set; }
		[Ordinal(4)]  [RED("vehBB")] public wCHandle<gameIBlackboard> VehBB { get; set; }

		public instrumentPanelLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
