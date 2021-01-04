using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ComputerDeviceBlackboardDef : MasterDeviceBaseBlackboardDef
	{
		[Ordinal(0)]  [RED("BannerWidgetsData")] public gamebbScriptID_Variant BannerWidgetsData { get; set; }
		[Ordinal(1)]  [RED("FileThumbnailWidgetsData")] public gamebbScriptID_Variant FileThumbnailWidgetsData { get; set; }
		[Ordinal(2)]  [RED("FileWidgetsData")] public gamebbScriptID_Variant FileWidgetsData { get; set; }
		[Ordinal(3)]  [RED("MailThumbnailWidgetsData")] public gamebbScriptID_Variant MailThumbnailWidgetsData { get; set; }
		[Ordinal(4)]  [RED("MailWidgetsData")] public gamebbScriptID_Variant MailWidgetsData { get; set; }
		[Ordinal(5)]  [RED("MainMenuButtonWidgetsData")] public gamebbScriptID_Variant MainMenuButtonWidgetsData { get; set; }
		[Ordinal(6)]  [RED("MenuButtonWidgetsData")] public gamebbScriptID_Variant MenuButtonWidgetsData { get; set; }

		public ComputerDeviceBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
