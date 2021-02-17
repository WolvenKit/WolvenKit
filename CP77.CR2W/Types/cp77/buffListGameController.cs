using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class buffListGameController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("buffsList")] public inkHorizontalPanelWidgetReference BuffsList { get; set; }
		[Ordinal(10)] [RED("bbBuffList")] public CUInt32 BbBuffList { get; set; }
		[Ordinal(11)] [RED("bbDeBuffList")] public CUInt32 BbDeBuffList { get; set; }
		[Ordinal(12)] [RED("uiBlackboard")] public CHandle<gameIBlackboard> UiBlackboard { get; set; }
		[Ordinal(13)] [RED("buffDataList")] public CArray<gameuiBuffInfo> BuffDataList { get; set; }
		[Ordinal(14)] [RED("debuffDataList")] public CArray<gameuiBuffInfo> DebuffDataList { get; set; }
		[Ordinal(15)] [RED("buffWidgets")] public CArray<wCHandle<inkWidget>> BuffWidgets { get; set; }
		[Ordinal(16)] [RED("UISystem")] public wCHandle<gameuiGameSystemUI> UISystem { get; set; }

		public buffListGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
