using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkLocalizedBink : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("binks")] 
		public CArray<inkBinkLanguageDescriptor> Binks
		{
			get => GetPropertyValue<CArray<inkBinkLanguageDescriptor>>();
			set => SetPropertyValue<CArray<inkBinkLanguageDescriptor>>(value);
		}

		public inkLocalizedBink()
		{
			Binks = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
