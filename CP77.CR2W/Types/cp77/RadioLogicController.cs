using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RadioLogicController : IVehicleModuleController
	{
		[Ordinal(1)] [RED("radioTextWidget")] public inkTextWidgetReference RadioTextWidget { get; set; }
		[Ordinal(2)] [RED("radioEQWidget")] public inkCanvasWidgetReference RadioEQWidget { get; set; }
		[Ordinal(3)] [RED("radioStateBBConnectionId")] public CUInt32 RadioStateBBConnectionId { get; set; }
		[Ordinal(4)] [RED("radioNameBBConnectionId")] public CUInt32 RadioNameBBConnectionId { get; set; }
		[Ordinal(5)] [RED("vehBB")] public wCHandle<gameIBlackboard> VehBB { get; set; }
		[Ordinal(6)] [RED("eqLoopAnimProxy")] public CHandle<inkanimProxy> EqLoopAnimProxy { get; set; }
		[Ordinal(7)] [RED("radioTextWidgetSize")] public Vector2 RadioTextWidgetSize { get; set; }

		public RadioLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
