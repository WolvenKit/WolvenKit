using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Ref_2_3_4_Struct : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("val")] 
		public CInt32 Val
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public Ref_2_3_4_Struct()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
