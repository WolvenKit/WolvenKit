using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Ref_4_2_1_Class : IScriptable
	{
		[Ordinal(0)] 
		[RED("constValue")] 
		public CInt32 ConstValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public Ref_4_2_1_Class()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
