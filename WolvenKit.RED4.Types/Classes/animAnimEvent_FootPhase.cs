using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimEvent_FootPhase : animAnimEvent
	{
		[Ordinal(3)] 
		[RED("phase")] 
		public CEnum<animEFootPhase> Phase
		{
			get => GetPropertyValue<CEnum<animEFootPhase>>();
			set => SetPropertyValue<CEnum<animEFootPhase>>(value);
		}

		public animAnimEvent_FootPhase()
		{
			DurationInFrames = 15;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
