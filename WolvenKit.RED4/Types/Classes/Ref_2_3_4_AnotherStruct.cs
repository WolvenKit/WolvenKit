using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Ref_2_3_4_AnotherStruct : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("val")] 
		public CFloat Val
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public Ref_2_3_4_AnotherStruct()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
