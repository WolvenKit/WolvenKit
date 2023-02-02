using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entTemplateBindingOverride : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("propertyName")] 
		public CName PropertyName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("binding")] 
		public CHandle<entIBinding> Binding
		{
			get => GetPropertyValue<CHandle<entIBinding>>();
			set => SetPropertyValue<CHandle<entIBinding>>(value);
		}

		public entTemplateBindingOverride()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
