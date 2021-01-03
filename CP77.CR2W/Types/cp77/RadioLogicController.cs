using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RadioLogicController : IVehicleModuleController
	{
		[Ordinal(0)]  [RED("eqLoopAnimProxy")] public CHandle<inkanimProxy> EqLoopAnimProxy { get; set; }
		[Ordinal(1)]  [RED("radioEQWidget")] public inkCanvasWidgetReference RadioEQWidget { get; set; }
		[Ordinal(2)]  [RED("radioNameBBConnectionId")] public CUInt32 RadioNameBBConnectionId { get; set; }
		[Ordinal(3)]  [RED("radioStateBBConnectionId")] public CUInt32 RadioStateBBConnectionId { get; set; }
		[Ordinal(4)]  [RED("radioTextWidget")] public inkTextWidgetReference RadioTextWidget { get; set; }
		[Ordinal(5)]  [RED("radioTextWidgetSize")] public Vector2 RadioTextWidgetSize { get; set; }
		[Ordinal(6)]  [RED("vehBB")] public wCHandle<gameIBlackboard> VehBB { get; set; }

		public RadioLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
