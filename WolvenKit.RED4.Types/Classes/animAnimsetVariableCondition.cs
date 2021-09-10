using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimsetVariableCondition : animIRuntimeCondition
	{
		[Ordinal(0)] 
		[RED("variableToCompare")] 
		public CName VariableToCompare
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("valueToCompare")] 
		public CFloat ValueToCompare
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animAnimsetVariableCondition()
		{
			ValueToCompare = 0.500000F;
		}
	}
}
