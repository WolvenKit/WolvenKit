
namespace WolvenKit.RED4.Types
{
	public partial class Ref_4_3_DerivedStruct_Defaults : Ref_4_3_Defaults
	{
		public Ref_4_3_DerivedStruct_Defaults()
		{
			I = 999;
			F = 10.000000F;
			B = false;
			S = "text2";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
