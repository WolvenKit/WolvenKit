using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnlocLocStoreEmbeddedVariantDescriptorEntry : CVariable
	{
		[Ordinal(0)]  [RED("localeId")] public CEnum<scnlocLocaleId> LocaleId { get; set; }
		[Ordinal(1)]  [RED("locstringId")] public scnlocLocstringId LocstringId { get; set; }
		[Ordinal(2)]  [RED("signature")] public scnlocSignature Signature { get; set; }
		[Ordinal(3)]  [RED("variantId")] public scnlocVariantId VariantId { get; set; }
		[Ordinal(4)]  [RED("vpeIndex")] public CUInt32 VpeIndex { get; set; }

		public scnlocLocStoreEmbeddedVariantDescriptorEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
