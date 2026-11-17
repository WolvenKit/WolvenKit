using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Ref_1_3_2_2_DerivedStruct : Ref_1_3_2_2_BaseStruct
	{
		[Ordinal(1)] 
		[RED("prop2")] 
		public CInt32 Prop2
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public Ref_1_3_2_2_DerivedStruct()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
