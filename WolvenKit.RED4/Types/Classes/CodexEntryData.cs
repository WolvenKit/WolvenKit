using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CodexEntryData : GenericCodexEntryData
	{
		[Ordinal(10)] 
		[RED("category")] 
		public CInt32 Category
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(11)] 
		[RED("imageType")] 
		public CEnum<CodexImageType> ImageType
		{
			get => GetPropertyValue<CEnum<CodexImageType>>();
			set => SetPropertyValue<CEnum<CodexImageType>>(value);
		}

		public CodexEntryData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
