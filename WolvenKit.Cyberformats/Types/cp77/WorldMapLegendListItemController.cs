using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WorldMapLegendListItemController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(2)] [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(3)] [RED("variant")] public CEnum<gamedataMappinVariant> Variant { get; set; }

		public WorldMapLegendListItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
