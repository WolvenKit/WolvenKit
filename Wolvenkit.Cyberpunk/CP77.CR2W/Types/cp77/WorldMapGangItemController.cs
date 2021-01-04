using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WorldMapGangItemController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("factionIconImage")] public inkImageWidgetReference FactionIconImage { get; set; }
		[Ordinal(1)]  [RED("factionNameText")] public inkTextWidgetReference FactionNameText { get; set; }

		public WorldMapGangItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
