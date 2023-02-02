using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkStyleProperty : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("propertyPath")] 
		public CName PropertyPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CVariant Value
		{
			get => GetPropertyValue<CVariant>();
			set => SetPropertyValue<CVariant>(value);
		}

		public inkStyleProperty()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
