using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Ref_1_3_2_2_BaseStruct : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("prop1")] 
		public CInt32 Prop1
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public Ref_1_3_2_2_BaseStruct()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
