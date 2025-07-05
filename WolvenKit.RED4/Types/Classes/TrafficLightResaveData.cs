using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TrafficLightResaveData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("transitionDuration")] 
		public CFloat TransitionDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("playNotificationSounds")] 
		public CBool PlayNotificationSounds
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("invertTrafficEvents")] 
		public CBool InvertTrafficEvents
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public TrafficLightResaveData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
