using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Ref_1_3_2_1_BottomDerivedStruct : Ref_1_3_2_1_DerivedStruct
	{
		[Ordinal(2)] 
		[RED("bottomDerivedProp")] 
		public CBool BottomDerivedProp
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public Ref_1_3_2_1_BottomDerivedStruct()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
