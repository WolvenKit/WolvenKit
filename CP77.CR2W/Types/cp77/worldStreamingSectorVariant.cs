using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldStreamingSectorVariant : CVariable
	{
		[Ordinal(0)]  [RED("enabledByDefault")] public CBool EnabledByDefault { get; set; }
		[Ordinal(1)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(2)]  [RED("nodeRef")] public NodeRef NodeRef { get; set; }
		[Ordinal(3)]  [RED("parentVariantID")] public CUInt32 ParentVariantID { get; set; }
		[Ordinal(4)]  [RED("rangeIndex")] public CUInt32 RangeIndex { get; set; }
		[Ordinal(5)]  [RED("variantId")] public CUInt32 VariantId { get; set; }

		public worldStreamingSectorVariant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
