using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questPrefabVariantReplicatedInfo : CVariable
	{
		[Ordinal(0)]  [RED("show")] public CBool Show { get; set; }
		[Ordinal(1)]  [RED("variantNameKey")] public CName VariantNameKey { get; set; }

		public questPrefabVariantReplicatedInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
