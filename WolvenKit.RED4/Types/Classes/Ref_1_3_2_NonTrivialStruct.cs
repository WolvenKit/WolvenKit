using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Ref_1_3_2_NonTrivialStruct : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("prop1")] 
		public CFloat Prop1
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("prop2")] 
		public Ref_1_3_2_TrivialStruct Prop2
		{
			get => GetPropertyValue<Ref_1_3_2_TrivialStruct>();
			set => SetPropertyValue<Ref_1_3_2_TrivialStruct>(value);
		}

		public Ref_1_3_2_NonTrivialStruct()
		{
			Prop2 = new Ref_1_3_2_TrivialStruct();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
