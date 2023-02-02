using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Sample_Replicated_Dynamic_Map_Array_Property : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("property")] 
		public CArray<SampleMapArrayElement> Property
		{
			get => GetPropertyValue<CArray<SampleMapArrayElement>>();
			set => SetPropertyValue<CArray<SampleMapArrayElement>>(value);
		}

		public Sample_Replicated_Dynamic_Map_Array_Property()
		{
			Property = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
