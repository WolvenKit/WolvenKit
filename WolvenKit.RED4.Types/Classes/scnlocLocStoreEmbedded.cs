using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnlocLocStoreEmbedded : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("vdEntries")] 
		public CArray<scnlocLocStoreEmbeddedVariantDescriptorEntry> VdEntries
		{
			get => GetPropertyValue<CArray<scnlocLocStoreEmbeddedVariantDescriptorEntry>>();
			set => SetPropertyValue<CArray<scnlocLocStoreEmbeddedVariantDescriptorEntry>>(value);
		}

		[Ordinal(1)] 
		[RED("vpEntries")] 
		public CArray<scnlocLocStoreEmbeddedVariantPayloadEntry> VpEntries
		{
			get => GetPropertyValue<CArray<scnlocLocStoreEmbeddedVariantPayloadEntry>>();
			set => SetPropertyValue<CArray<scnlocLocStoreEmbeddedVariantPayloadEntry>>(value);
		}

		public scnlocLocStoreEmbedded()
		{
			VdEntries = new();
			VpEntries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
