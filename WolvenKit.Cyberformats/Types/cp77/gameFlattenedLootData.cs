using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameFlattenedLootData : CVariable
	{
		[Ordinal(0)] [RED("lootID")] public TweakDBID LootID { get; set; }

		public gameFlattenedLootData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
