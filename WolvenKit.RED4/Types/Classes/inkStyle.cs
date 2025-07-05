using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkStyle : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("styleID")] 
		public CName StyleID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CName State
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("properties")] 
		public CArray<inkStyleProperty> Properties
		{
			get => GetPropertyValue<CArray<inkStyleProperty>>();
			set => SetPropertyValue<CArray<inkStyleProperty>>(value);
		}

		public inkStyle()
		{
			Properties = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
