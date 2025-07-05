using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Sample_Replicated_Float_Property : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("property")] 
		public CFloat Property
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public Sample_Replicated_Float_Property()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
