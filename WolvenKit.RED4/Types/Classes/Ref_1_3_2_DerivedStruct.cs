using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Ref_1_3_2_DerivedStruct : Ref_1_3_2_NonTrivialStruct
	{
		[Ordinal(2)] 
		[RED("prop3")] 
		public CBool Prop3
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public Ref_1_3_2_DerivedStruct()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
