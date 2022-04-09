using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Sample_Replicated_Double_Property : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("property")] 
		public CDouble Property
		{
			get => GetPropertyValue<CDouble>();
			set => SetPropertyValue<CDouble>(value);
		}

		public Sample_Replicated_Double_Property()
		{
			Property = 0.000000;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
