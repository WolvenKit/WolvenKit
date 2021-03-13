using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterEquippedItem_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(1)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
		[Ordinal(2)] [RED("itemID")] public TweakDBID ItemID { get; set; }
		[Ordinal(3)] [RED("itemTag")] public CName ItemTag { get; set; }
		[Ordinal(4)] [RED("excludedTweakDBIDs")] public CArray<TweakDBID> ExcludedTweakDBIDs { get; set; }
		[Ordinal(5)] [RED("excludedTags")] public CArray<CName> ExcludedTags { get; set; }
		[Ordinal(6)] [RED("inverted")] public CBool Inverted { get; set; }

		public questCharacterEquippedItem_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
