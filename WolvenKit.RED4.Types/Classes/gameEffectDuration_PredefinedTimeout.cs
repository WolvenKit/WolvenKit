using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectDuration_PredefinedTimeout : gameEffectDurationModifier
	{
		[Ordinal(0)] 
		[RED("timeToLive")] 
		public CFloat TimeToLive
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameEffectDuration_PredefinedTimeout()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
