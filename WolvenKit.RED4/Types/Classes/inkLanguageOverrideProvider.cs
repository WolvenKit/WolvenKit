using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkLanguageOverrideProvider : inkUserData
	{
		[Ordinal(0)] 
		[RED("languageId")] 
		public CEnum<inkLanguageId> LanguageId
		{
			get => GetPropertyValue<CEnum<inkLanguageId>>();
			set => SetPropertyValue<CEnum<inkLanguageId>>(value);
		}

		public inkLanguageOverrideProvider()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
