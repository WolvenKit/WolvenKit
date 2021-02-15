using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ComputerDeviceBlackboardDef : MasterDeviceBaseBlackboardDef
	{
		[Ordinal(8)] [RED("MailThumbnailWidgetsData")] public gamebbScriptID_Variant MailThumbnailWidgetsData { get; set; }
		[Ordinal(9)] [RED("FileThumbnailWidgetsData")] public gamebbScriptID_Variant FileThumbnailWidgetsData { get; set; }
		[Ordinal(10)] [RED("MailWidgetsData")] public gamebbScriptID_Variant MailWidgetsData { get; set; }
		[Ordinal(11)] [RED("FileWidgetsData")] public gamebbScriptID_Variant FileWidgetsData { get; set; }
		[Ordinal(12)] [RED("MenuButtonWidgetsData")] public gamebbScriptID_Variant MenuButtonWidgetsData { get; set; }
		[Ordinal(13)] [RED("MainMenuButtonWidgetsData")] public gamebbScriptID_Variant MainMenuButtonWidgetsData { get; set; }
		[Ordinal(14)] [RED("BannerWidgetsData")] public gamebbScriptID_Variant BannerWidgetsData { get; set; }

		public ComputerDeviceBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
