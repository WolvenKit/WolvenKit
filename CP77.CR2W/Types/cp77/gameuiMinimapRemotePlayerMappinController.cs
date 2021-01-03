using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiMinimapRemotePlayerMappinController : gameuiBaseMinimapMappinController
	{
		[Ordinal(0)]  [RED("dataWidget")] public inkWidgetReference DataWidget { get; set; }
		[Ordinal(1)]  [RED("playerMappin")] public wCHandle<gamemappinsRemotePlayerMappin> PlayerMappin { get; set; }
		[Ordinal(2)]  [RED("rootWidget")] public inkWidgetReference RootWidget { get; set; }
		[Ordinal(3)]  [RED("shapeWidget")] public inkWidgetReference ShapeWidget { get; set; }

		public gameuiMinimapRemotePlayerMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
