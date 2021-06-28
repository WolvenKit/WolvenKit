using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnlocLocStoreEmbedded : CVariable
	{
		private CArray<scnlocLocStoreEmbeddedVariantDescriptorEntry> _vdEntries;
		private CArray<scnlocLocStoreEmbeddedVariantPayloadEntry> _vpEntries;

		[Ordinal(0)] 
		[RED("vdEntries")] 
		public CArray<scnlocLocStoreEmbeddedVariantDescriptorEntry> VdEntries
		{
			get => GetProperty(ref _vdEntries);
			set => SetProperty(ref _vdEntries, value);
		}

		[Ordinal(1)] 
		[RED("vpEntries")] 
		public CArray<scnlocLocStoreEmbeddedVariantPayloadEntry> VpEntries
		{
			get => GetProperty(ref _vpEntries);
			set => SetProperty(ref _vpEntries, value);
		}

		public scnlocLocStoreEmbedded(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
