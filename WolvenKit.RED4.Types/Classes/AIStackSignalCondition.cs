using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIStackSignalCondition : AIbehaviorStackScriptPassiveExpressionDefinition
	{
		[Ordinal(0)] 
		[RED("signalName")] 
		public CName SignalName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public AIStackSignalCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
