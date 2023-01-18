using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimsetVariableCondition : animIRuntimeCondition
	{
		[Ordinal(0)] 
		[RED("variableToCompare")] 
		public CName VariableToCompare
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animAnimsetVariableCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
