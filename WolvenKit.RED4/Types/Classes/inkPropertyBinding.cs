using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkPropertyBinding : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("propertyName")] 
		public CName PropertyName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("stylePath")] 
		public CName StylePath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public inkPropertyBinding()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
