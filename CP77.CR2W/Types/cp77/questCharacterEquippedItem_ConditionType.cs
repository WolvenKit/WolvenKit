using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questCharacterEquippedItem_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)]  [RED("excludedTags")] public CArray<CName> ExcludedTags { get; set; }
		[Ordinal(1)]  [RED("excludedTweakDBIDs")] public CArray<TweakDBID> ExcludedTweakDBIDs { get; set; }
		[Ordinal(2)]  [RED("inverted")] public CBool Inverted { get; set; }
		[Ordinal(3)]  [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(4)]  [RED("itemID")] public TweakDBID ItemID { get; set; }
		[Ordinal(5)]  [RED("itemTag")] public CName ItemTag { get; set; }
		[Ordinal(6)]  [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }

		public questCharacterEquippedItem_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
