using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnlocLocStoreEmbedded : RedBaseClass
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
	}
}
