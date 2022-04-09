using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AISetSoloModeHandler : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("inCommand")] 
		public CHandle<AIArgumentMapping> InCommand
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AISetSoloModeHandler()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
