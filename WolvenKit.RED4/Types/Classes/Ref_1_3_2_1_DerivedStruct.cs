using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Ref_1_3_2_1_DerivedStruct : Ref_1_3_2_1_BaseStruct
	{
		[Ordinal(1)] 
		[RED("derivedProp")] 
		public CFloat DerivedProp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public Ref_1_3_2_1_DerivedStruct()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
