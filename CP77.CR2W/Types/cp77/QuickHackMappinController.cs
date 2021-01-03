using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class QuickHackMappinController : gameuiInteractionMappinController
	{
		[Ordinal(0)]  [RED("bar")] public inkWidgetReference Bar { get; set; }
		[Ordinal(1)]  [RED("data")] public CHandle<GameplayRoleMappinData> Data { get; set; }
		[Ordinal(2)]  [RED("header")] public inkTextWidgetReference Header { get; set; }
		[Ordinal(3)]  [RED("iconWidgetActive")] public inkImageWidgetReference IconWidgetActive { get; set; }
		[Ordinal(4)]  [RED("mappin")] public wCHandle<gamemappinsIMappin> Mappin { get; set; }
		[Ordinal(5)]  [RED("rootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }

		public QuickHackMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
