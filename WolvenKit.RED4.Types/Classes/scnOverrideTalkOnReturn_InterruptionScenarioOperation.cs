using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnOverrideTalkOnReturn_InterruptionScenarioOperation : scnIInterruptionScenarioOperation
	{
		[Ordinal(0)] 
		[RED("talkOnReturn")] 
		public CBool TalkOnReturn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scnOverrideTalkOnReturn_InterruptionScenarioOperation()
		{
			TalkOnReturn = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
