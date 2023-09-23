using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CompareBuilder : IScriptable
	{
		[Ordinal(0)] 
		[RED("FLOAT_EQUAL_EPSILON")] 
		public CFloat FLOAT_EQUAL_EPSILON
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CInt32 Value
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public CompareBuilder()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
