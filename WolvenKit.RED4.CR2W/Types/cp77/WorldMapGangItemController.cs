using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorldMapGangItemController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("factionNameText")] public inkTextWidgetReference FactionNameText { get; set; }
		[Ordinal(2)] [RED("factionIconImage")] public inkImageWidgetReference FactionIconImage { get; set; }

		public WorldMapGangItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
