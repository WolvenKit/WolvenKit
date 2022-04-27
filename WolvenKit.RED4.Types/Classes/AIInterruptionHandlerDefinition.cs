using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIInterruptionHandlerDefinition : LibTreeINodeDefinition
	{
		[Ordinal(0)] 
		[RED("signal")] 
		public AIInterruptionSignal Signal
		{
			get => GetPropertyValue<AIInterruptionSignal>();
			set => SetPropertyValue<AIInterruptionSignal>(value);
		}

		[Ordinal(1)] 
		[RED("supportLessImportantSignals")] 
		public CBool SupportLessImportantSignals
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIInterruptionHandlerDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
