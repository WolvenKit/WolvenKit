using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class hudDroneController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("showAnimDef")] public CHandle<inkanimDefinition> ShowAnimDef { get; set; }
		[Ordinal(1)]  [RED("hideAnimDef")] public CHandle<inkanimDefinition> HideAnimDef { get; set; }
		[Ordinal(2)]  [RED("showAnimationName")] public CName ShowAnimationName { get; set; }
		[Ordinal(3)]  [RED("hideAnimationName")] public CName HideAnimationName { get; set; }
		[Ordinal(4)]  [RED("moduleShown")] public CBool ModuleShown { get; set; }
		[Ordinal(5)]  [RED("showAnimProxy")] public CHandle<inkanimProxy> ShowAnimProxy { get; set; }
		[Ordinal(6)]  [RED("hideAnimProxy")] public CHandle<inkanimProxy> HideAnimProxy { get; set; }
		[Ordinal(7)]  [RED("Date")] public inkTextWidgetReference Date { get; set; }
		[Ordinal(8)]  [RED("Timer")] public inkTextWidgetReference Timer { get; set; }
		[Ordinal(9)]  [RED("CameraID")] public inkTextWidgetReference CameraID { get; set; }
		[Ordinal(10)]  [RED("scanBlackboard")] public CHandle<gameIBlackboard> ScanBlackboard { get; set; }
		[Ordinal(11)]  [RED("psmBlackboard")] public CHandle<gameIBlackboard> PsmBlackboard { get; set; }
		[Ordinal(12)]  [RED("PSM_BBID")] public CUInt32 PSM_BBID { get; set; }
		[Ordinal(13)]  [RED("root")] public wCHandle<inkCompoundWidget> Root { get; set; }
		[Ordinal(14)]  [RED("currentZoom")] public CFloat CurrentZoom { get; set; }
		[Ordinal(15)]  [RED("currentTime")] public GameTime CurrentTime { get; set; }

		public hudDroneController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
