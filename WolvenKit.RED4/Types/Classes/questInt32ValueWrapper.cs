using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questInt32ValueWrapper : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("valueProvider")] 
		public CHandle<questIInt32ValueProvider> ValueProvider
		{
			get => GetPropertyValue<CHandle<questIInt32ValueProvider>>();
			set => SetPropertyValue<CHandle<questIInt32ValueProvider>>(value);
		}

		public questInt32ValueWrapper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
