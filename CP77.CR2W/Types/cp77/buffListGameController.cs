using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class buffListGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("showAnimDef")] public CHandle<inkanimDefinition> ShowAnimDef { get; set; }
		[Ordinal(1)]  [RED("hideAnimDef")] public CHandle<inkanimDefinition> HideAnimDef { get; set; }
		[Ordinal(2)]  [RED("showAnimationName")] public CName ShowAnimationName { get; set; }
		[Ordinal(3)]  [RED("hideAnimationName")] public CName HideAnimationName { get; set; }
		[Ordinal(4)]  [RED("moduleShown")] public CBool ModuleShown { get; set; }
		[Ordinal(5)]  [RED("showAnimProxy")] public CHandle<inkanimProxy> ShowAnimProxy { get; set; }
		[Ordinal(6)]  [RED("hideAnimProxy")] public CHandle<inkanimProxy> HideAnimProxy { get; set; }
		[Ordinal(7)]  [RED("buffsList")] public inkHorizontalPanelWidgetReference BuffsList { get; set; }
		[Ordinal(8)]  [RED("bbBuffList")] public CUInt32 BbBuffList { get; set; }
		[Ordinal(9)]  [RED("bbDeBuffList")] public CUInt32 BbDeBuffList { get; set; }
		[Ordinal(10)]  [RED("uiBlackboard")] public CHandle<gameIBlackboard> UiBlackboard { get; set; }
		[Ordinal(11)]  [RED("buffDataList")] public CArray<gameuiBuffInfo> BuffDataList { get; set; }
		[Ordinal(12)]  [RED("debuffDataList")] public CArray<gameuiBuffInfo> DebuffDataList { get; set; }
		[Ordinal(13)]  [RED("buffWidgets")] public CArray<wCHandle<inkWidget>> BuffWidgets { get; set; }
		[Ordinal(14)]  [RED("UISystem")] public wCHandle<gameuiGameSystemUI> UISystem { get; set; }

		public buffListGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
