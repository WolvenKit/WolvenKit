using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldWeatherStateTransition : ISerializable
	{
		[Ordinal(0)] 
		[RED("probability")] 
		public CLegacySingleChannelCurve<CFloat> Probability
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(1)] 
		[RED("transitionDuration")] 
		public CLegacySingleChannelCurve<CFloat> TransitionDuration
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(2)] 
		[RED("sourceWeatherState")] 
		public CHandle<worldWeatherState> SourceWeatherState
		{
			get => GetPropertyValue<CHandle<worldWeatherState>>();
			set => SetPropertyValue<CHandle<worldWeatherState>>(value);
		}

		[Ordinal(3)] 
		[RED("targetWeatherState")] 
		public CHandle<worldWeatherState> TargetWeatherState
		{
			get => GetPropertyValue<CHandle<worldWeatherState>>();
			set => SetPropertyValue<CHandle<worldWeatherState>>(value);
		}

		public worldWeatherStateTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
