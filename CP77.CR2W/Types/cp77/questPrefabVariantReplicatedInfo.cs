using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questPrefabVariantReplicatedInfo : CVariable
	{
		[Ordinal(0)] [RED("variantNameKey")] public CName VariantNameKey { get; set; }
		[Ordinal(1)] [RED("show")] public CBool Show { get; set; }

		public questPrefabVariantReplicatedInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
