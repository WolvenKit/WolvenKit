using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class buffListGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("UISystem")] public wCHandle<gameuiGameSystemUI> UISystem { get; set; }
		[Ordinal(1)]  [RED("bbBuffList")] public CUInt32 BbBuffList { get; set; }
		[Ordinal(2)]  [RED("bbDeBuffList")] public CUInt32 BbDeBuffList { get; set; }
		[Ordinal(3)]  [RED("buffDataList")] public CArray<gameuiBuffInfo> BuffDataList { get; set; }
		[Ordinal(4)]  [RED("buffWidgets")] public CArray<wCHandle<inkWidget>> BuffWidgets { get; set; }
		[Ordinal(5)]  [RED("buffsList")] public inkHorizontalPanelWidgetReference BuffsList { get; set; }
		[Ordinal(6)]  [RED("debuffDataList")] public CArray<gameuiBuffInfo> DebuffDataList { get; set; }
		[Ordinal(7)]  [RED("uiBlackboard")] public CHandle<gameIBlackboard> UiBlackboard { get; set; }

		public buffListGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
