using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuickHackMappinController : gameuiInteractionMappinController
	{
		[Ordinal(11)] [RED("bar")] public inkWidgetReference Bar { get; set; }
		[Ordinal(12)] [RED("header")] public inkTextWidgetReference Header { get; set; }
		[Ordinal(13)] [RED("iconWidgetActive")] public inkImageWidgetReference IconWidgetActive { get; set; }
		[Ordinal(14)] [RED("rootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(15)] [RED("mappin")] public wCHandle<gamemappinsIMappin> Mappin { get; set; }
		[Ordinal(16)] [RED("data")] public CHandle<GameplayRoleMappinData> Data { get; set; }

		public QuickHackMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
