using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnlocLocStoreEmbeddedVariantPayloadEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("variantId")] 
		public scnlocVariantId VariantId
		{
			get => GetPropertyValue<scnlocVariantId>();
			set => SetPropertyValue<scnlocVariantId>(value);
		}

		[Ordinal(1)] 
		[RED("content")] 
		public CString Content
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public scnlocLocStoreEmbeddedVariantPayloadEntry()
		{
			VariantId = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
