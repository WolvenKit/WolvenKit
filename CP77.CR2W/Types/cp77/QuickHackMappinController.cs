using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuickHackMappinController : gameuiInteractionMappinController
	{
		[Ordinal(0)]  [RED("animPlayerTrackedWidget")] public inkWidgetReference AnimPlayerTrackedWidget { get; set; }
		[Ordinal(1)]  [RED("animPlayerAboveBelowWidget")] public inkWidgetReference AnimPlayerAboveBelowWidget { get; set; }
		[Ordinal(2)]  [RED("taggedWidgets")] public CArray<inkWidgetReference> TaggedWidgets { get; set; }
		[Ordinal(3)]  [RED("bar")] public inkWidgetReference Bar { get; set; }
		[Ordinal(4)]  [RED("header")] public inkTextWidgetReference Header { get; set; }
		[Ordinal(5)]  [RED("iconWidgetActive")] public inkImageWidgetReference IconWidgetActive { get; set; }
		[Ordinal(6)]  [RED("rootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(7)]  [RED("mappin")] public wCHandle<gamemappinsIMappin> Mappin { get; set; }
		[Ordinal(8)]  [RED("data")] public CHandle<GameplayRoleMappinData> Data { get; set; }

		public QuickHackMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
