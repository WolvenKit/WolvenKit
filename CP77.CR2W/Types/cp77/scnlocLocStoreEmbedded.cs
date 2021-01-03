using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnlocLocStoreEmbedded : CVariable
	{
		[Ordinal(0)]  [RED("vdEntries")] public CArray<scnlocLocStoreEmbeddedVariantDescriptorEntry> VdEntries { get; set; }
		[Ordinal(1)]  [RED("vpEntries")] public CArray<scnlocLocStoreEmbeddedVariantPayloadEntry> VpEntries { get; set; }

		public scnlocLocStoreEmbedded(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
