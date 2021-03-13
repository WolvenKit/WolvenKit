using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterKilled_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
		[Ordinal(1)] [RED("comparisonParams")] public CHandle<questComparisonParam> ComparisonParams { get; set; }
		[Ordinal(2)] [RED("killed")] public CBool Killed { get; set; }
		[Ordinal(3)] [RED("unconscious")] public CBool Unconscious { get; set; }
		[Ordinal(4)] [RED("defeated")] public CBool Defeated { get; set; }

		public questCharacterKilled_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
