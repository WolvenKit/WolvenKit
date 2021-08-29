using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldWeatherState : RedBaseClass
	{
		private CLegacySingleChannelCurve<CFloat> _probability;
		private CLegacySingleChannelCurve<CFloat> _minDuration;
		private CLegacySingleChannelCurve<CFloat> _maxDuration;
		private CLegacySingleChannelCurve<CFloat> _transitionDuration;
		private CResourceReference<worldEnvironmentAreaParameters> _environmentAreaParameters;
		private CResourceAsyncReference<worldEffect> _effect;
		private CName _name;

		[Ordinal(0)] 
		[RED("probability")] 
		public CLegacySingleChannelCurve<CFloat> Probability
		{
			get => GetProperty(ref _probability);
			set => SetProperty(ref _probability, value);
		}

		[Ordinal(1)] 
		[RED("minDuration")] 
		public CLegacySingleChannelCurve<CFloat> MinDuration
		{
			get => GetProperty(ref _minDuration);
			set => SetProperty(ref _minDuration, value);
		}

		[Ordinal(2)] 
		[RED("maxDuration")] 
		public CLegacySingleChannelCurve<CFloat> MaxDuration
		{
			get => GetProperty(ref _maxDuration);
			set => SetProperty(ref _maxDuration, value);
		}

		[Ordinal(3)] 
		[RED("transitionDuration")] 
		public CLegacySingleChannelCurve<CFloat> TransitionDuration
		{
			get => GetProperty(ref _transitionDuration);
			set => SetProperty(ref _transitionDuration, value);
		}

		[Ordinal(4)] 
		[RED("environmentAreaParameters")] 
		public CResourceReference<worldEnvironmentAreaParameters> EnvironmentAreaParameters
		{
			get => GetProperty(ref _environmentAreaParameters);
			set => SetProperty(ref _environmentAreaParameters, value);
		}

		[Ordinal(5)] 
		[RED("effect")] 
		public CResourceAsyncReference<worldEffect> Effect
		{
			get => GetProperty(ref _effect);
			set => SetProperty(ref _effect, value);
		}

		[Ordinal(6)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}
	}
}
