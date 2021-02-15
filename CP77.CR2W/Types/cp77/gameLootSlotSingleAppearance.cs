using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameLootSlotSingleAppearance : gameLootSlotSingleItem
	{
		[Ordinal(54)] [RED("lootAppearance")] public CName LootAppearance { get; set; }

		public gameLootSlotSingleAppearance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
