using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameLootObject : gameObject
	{
		[Ordinal(40)] [RED("lootID")] public TweakDBID LootID { get; set; }
		[Ordinal(41)] [RED("isInIconForcedVisibilityRange")] public CBool IsInIconForcedVisibilityRange { get; set; }
		[Ordinal(42)] [RED("activeQualityRangeInteraction")] public CName ActiveQualityRangeInteraction { get; set; }

		public gameLootObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
