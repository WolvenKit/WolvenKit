using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Ref_1_3_2_1_BaseStruct : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("baseProp")] 
		public CInt32 BaseProp
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public Ref_1_3_2_1_BaseStruct()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
