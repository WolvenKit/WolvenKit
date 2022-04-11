using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIInterruptionSignal : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("importance")] 
		public CEnum<AIEInterruptionImportance> Importance
		{
			get => GetPropertyValue<CEnum<AIEInterruptionImportance>>();
			set => SetPropertyValue<CEnum<AIEInterruptionImportance>>(value);
		}

		[Ordinal(1)] 
		[RED("signal")] 
		public CName Signal
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public AIInterruptionSignal()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
