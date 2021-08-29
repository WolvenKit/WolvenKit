using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HeatHazeAreaSettings : IAreaSettings
	{
		private CLegacySingleChannelCurve<CFloat> _effectStrength;
		private CLegacySingleChannelCurve<CFloat> _startDistance;
		private CLegacySingleChannelCurve<CFloat> _maxDistance;
		private CLegacySingleChannelCurve<CFloat> _patternScale;
		private CLegacySingleChannelCurve<CFloat> _movementSpeedScale;

		[Ordinal(2)] 
		[RED("effectStrength")] 
		public CLegacySingleChannelCurve<CFloat> EffectStrength
		{
			get => GetProperty(ref _effectStrength);
			set => SetProperty(ref _effectStrength, value);
		}

		[Ordinal(3)] 
		[RED("startDistance")] 
		public CLegacySingleChannelCurve<CFloat> StartDistance
		{
			get => GetProperty(ref _startDistance);
			set => SetProperty(ref _startDistance, value);
		}

		[Ordinal(4)] 
		[RED("maxDistance")] 
		public CLegacySingleChannelCurve<CFloat> MaxDistance
		{
			get => GetProperty(ref _maxDistance);
			set => SetProperty(ref _maxDistance, value);
		}

		[Ordinal(5)] 
		[RED("patternScale")] 
		public CLegacySingleChannelCurve<CFloat> PatternScale
		{
			get => GetProperty(ref _patternScale);
			set => SetProperty(ref _patternScale, value);
		}

		[Ordinal(6)] 
		[RED("movementSpeedScale")] 
		public CLegacySingleChannelCurve<CFloat> MovementSpeedScale
		{
			get => GetProperty(ref _movementSpeedScale);
			set => SetProperty(ref _movementSpeedScale, value);
		}
	}
}
