using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Sample_Replicated_Int_Property : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("property")] 
		public CInt32 Property
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public Sample_Replicated_Int_Property()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
