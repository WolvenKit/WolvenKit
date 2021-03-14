using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnlocLocStoreEmbeddedVariantDescriptorEntry : CVariable
	{
		[Ordinal(0)] [RED("variantId")] public scnlocVariantId VariantId { get; set; }
		[Ordinal(1)] [RED("locstringId")] public scnlocLocstringId LocstringId { get; set; }
		[Ordinal(2)] [RED("localeId")] public CEnum<scnlocLocaleId> LocaleId { get; set; }
		[Ordinal(3)] [RED("signature")] public scnlocSignature Signature { get; set; }
		[Ordinal(4)] [RED("vpeIndex")] public CUInt32 VpeIndex { get; set; }

		public scnlocLocStoreEmbeddedVariantDescriptorEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
