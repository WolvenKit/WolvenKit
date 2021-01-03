using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class WorldMapGangItemController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("factionIconImage")] public inkImageWidgetReference FactionIconImage { get; set; }
		[Ordinal(1)]  [RED("factionNameText")] public inkTextWidgetReference FactionNameText { get; set; }

		public WorldMapGangItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
