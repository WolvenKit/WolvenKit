using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Ref_1_4_1_Class : IScriptable
	{
		[Ordinal(0)] 
		[RED("intProp")] 
		public CInt32 IntProp
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public Ref_1_4_1_Class()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
