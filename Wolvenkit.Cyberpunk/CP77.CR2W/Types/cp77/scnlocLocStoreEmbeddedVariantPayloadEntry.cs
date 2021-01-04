using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnlocLocStoreEmbeddedVariantPayloadEntry : CVariable
	{
		[Ordinal(0)]  [RED("content")] public CString Content { get; set; }
		[Ordinal(1)]  [RED("variantId")] public scnlocVariantId VariantId { get; set; }

		public scnlocLocStoreEmbeddedVariantPayloadEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
