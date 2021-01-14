using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameLootObject : gameObject
	{
		[Ordinal(0)]  [RED("activeQualityRangeInteraction")] public CName ActiveQualityRangeInteraction { get; set; }
		[Ordinal(1)]  [RED("isInIconForcedVisibilityRange")] public CBool IsInIconForcedVisibilityRange { get; set; }
		[Ordinal(2)]  [RED("lootID")] public TweakDBID LootID { get; set; }

		public gameLootObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
