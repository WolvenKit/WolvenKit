using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TVDeviceBlackboardDef : DeviceBaseBlackboardDef
	{
		[Ordinal(0)]  [RED("ActionWidgetsData")] public gamebbScriptID_Variant ActionWidgetsData { get; set; }
		[Ordinal(1)]  [RED("DeviceWidgetsData")] public gamebbScriptID_Variant DeviceWidgetsData { get; set; }
		[Ordinal(2)]  [RED("UIupdate")] public gamebbScriptID_Bool UIupdate { get; set; }
		[Ordinal(3)]  [RED("BreadCrumbElement")] public gamebbScriptID_Variant BreadCrumbElement { get; set; }
		[Ordinal(4)]  [RED("GlitchData")] public gamebbScriptID_Variant GlitchData { get; set; }
		[Ordinal(5)]  [RED("UI_InteractivityBlocked")] public gamebbScriptID_Bool UI_InteractivityBlocked { get; set; }
		[Ordinal(6)]  [RED("IsInvestigated")] public gamebbScriptID_Bool IsInvestigated { get; set; }
		[Ordinal(7)]  [RED("PreviousChannel")] public gamebbScriptID_Int32 PreviousChannel { get; set; }
		[Ordinal(8)]  [RED("CurrentChannel")] public gamebbScriptID_Int32 CurrentChannel { get; set; }

		public TVDeviceBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
