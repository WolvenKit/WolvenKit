using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkWidgetPath : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("names")] 
		public CArray<CName> Names
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public inkWidgetPath()
		{
			Names = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
