using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HighestPrioritySignalCondition : AIbehaviorexpressionScript
	{
		[Ordinal(0)] 
		[RED("signalName")] 
		public CName SignalName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("cbId")] 
		public CUInt32 CbId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("lastValue")] 
		public CBool LastValue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public HighestPrioritySignalCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
