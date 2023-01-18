using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldWeatherState : ISerializable
	{
		[Ordinal(0)] 
		[RED("minDuration")] 
		public CLegacySingleChannelCurve<CFloat> MinDuration
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(1)] 
		[RED("maxDuration")] 
		public CLegacySingleChannelCurve<CFloat> MaxDuration
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(2)] 
		[RED("environmentAreaParameters")] 
		public CResourceReference<worldEnvironmentAreaParameters> EnvironmentAreaParameters
		{
			get => GetPropertyValue<CResourceReference<worldEnvironmentAreaParameters>>();
			set => SetPropertyValue<CResourceReference<worldEnvironmentAreaParameters>>(value);
		}

		[Ordinal(3)] 
		[RED("effect")] 
		public CResourceAsyncReference<worldEffect> Effect
		{
			get => GetPropertyValue<CResourceAsyncReference<worldEffect>>();
			set => SetPropertyValue<CResourceAsyncReference<worldEffect>>(value);
		}

		[Ordinal(4)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("probability")] 
		public CLegacySingleChannelCurve<CFloat> Probability
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(6)] 
		[RED("transitionDuration")] 
		public CLegacySingleChannelCurve<CFloat> TransitionDuration
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		public worldWeatherState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
