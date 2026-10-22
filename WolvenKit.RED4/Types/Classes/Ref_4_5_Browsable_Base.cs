using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Ref_4_5_Browsable_Base : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("firstBaseVar")] 
		public CInt32 FirstBaseVar
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("secondBaseVar")] 
		public CInt32 SecondBaseVar
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("thirdBaseVar")] 
		public CInt32 ThirdBaseVar
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public Ref_4_5_Browsable_Base()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
