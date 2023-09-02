using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnlocLocStoreEmbeddedVariantDescriptorEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("variantId")] 
		public scnlocVariantId VariantId
		{
			get => GetPropertyValue<scnlocVariantId>();
			set => SetPropertyValue<scnlocVariantId>(value);
		}

		[Ordinal(1)] 
		[RED("locstringId")] 
		public scnlocLocstringId LocstringId
		{
			get => GetPropertyValue<scnlocLocstringId>();
			set => SetPropertyValue<scnlocLocstringId>(value);
		}

		[Ordinal(2)] 
		[RED("localeId")] 
		public CEnum<scnlocLocaleId> LocaleId
		{
			get => GetPropertyValue<CEnum<scnlocLocaleId>>();
			set => SetPropertyValue<CEnum<scnlocLocaleId>>(value);
		}

		[Ordinal(3)] 
		[RED("signature")] 
		public scnlocSignature Signature
		{
			get => GetPropertyValue<scnlocSignature>();
			set => SetPropertyValue<scnlocSignature>(value);
		}

		[Ordinal(4)] 
		[RED("vpeIndex")] 
		public CUInt32 VpeIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public scnlocLocStoreEmbeddedVariantDescriptorEntry()
		{
			VariantId = new scnlocVariantId();
			LocstringId = new scnlocLocstringId();
			Signature = new scnlocSignature();
			VpeIndex = uint.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
