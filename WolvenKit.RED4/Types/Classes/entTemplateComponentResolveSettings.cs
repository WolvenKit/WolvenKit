using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entTemplateComponentResolveSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("nameParam")] 
		public CName NameParam
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("mode")] 
		public CEnum<entTemplateComponentResolveMode> Mode
		{
			get => GetPropertyValue<CEnum<entTemplateComponentResolveMode>>();
			set => SetPropertyValue<CEnum<entTemplateComponentResolveMode>>(value);
		}

		public entTemplateComponentResolveSettings()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
