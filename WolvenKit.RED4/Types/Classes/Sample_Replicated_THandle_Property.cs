using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Sample_Replicated_THandle_Property : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("property")] 
		public CHandle<Sample_Replicated_Serializable> Property
		{
			get => GetPropertyValue<CHandle<Sample_Replicated_Serializable>>();
			set => SetPropertyValue<CHandle<Sample_Replicated_Serializable>>(value);
		}

		public Sample_Replicated_THandle_Property()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
