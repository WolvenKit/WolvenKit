using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entTemplateAppearance : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("appearanceResource")] 
		public CResourceAsyncReference<appearanceAppearanceResource> AppearanceResource
		{
			get => GetPropertyValue<CResourceAsyncReference<appearanceAppearanceResource>>();
			set => SetPropertyValue<CResourceAsyncReference<appearanceAppearanceResource>>(value);
		}

		[Ordinal(2)] 
		[RED("appearanceName")] 
		public CName AppearanceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public entTemplateAppearance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
