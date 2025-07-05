using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkBinkLanguageDescriptor : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("bink")] 
		public CResourceAsyncReference<Bink> Bink
		{
			get => GetPropertyValue<CResourceAsyncReference<Bink>>();
			set => SetPropertyValue<CResourceAsyncReference<Bink>>(value);
		}

		[Ordinal(1)] 
		[RED("languageId")] 
		public CEnum<inkLanguageId> LanguageId
		{
			get => GetPropertyValue<CEnum<inkLanguageId>>();
			set => SetPropertyValue<CEnum<inkLanguageId>>(value);
		}

		public inkBinkLanguageDescriptor()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
