using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameprojectileSpiralParams : IScriptable
	{
		private CBool _enabled;
		private CFloat _radius;
		private CFloat _cycleTimeMin;
		private CFloat _cycleTimeMax;
		private CFloat _rampUpDistanceStart;
		private CFloat _rampUpDistanceEnd;
		private CFloat _rampDownDistanceStart;
		private CFloat _rampDownDistanceEnd;
		private CFloat _rampDownFactor;
		private CBool _randomizePhase;
		private CBool _randomizeDirection;

		[Ordinal(0)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetProperty(ref _enabled);
			set => SetProperty(ref _enabled, value);
		}

		[Ordinal(1)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		[Ordinal(2)] 
		[RED("cycleTimeMin")] 
		public CFloat CycleTimeMin
		{
			get => GetProperty(ref _cycleTimeMin);
			set => SetProperty(ref _cycleTimeMin, value);
		}

		[Ordinal(3)] 
		[RED("cycleTimeMax")] 
		public CFloat CycleTimeMax
		{
			get => GetProperty(ref _cycleTimeMax);
			set => SetProperty(ref _cycleTimeMax, value);
		}

		[Ordinal(4)] 
		[RED("rampUpDistanceStart")] 
		public CFloat RampUpDistanceStart
		{
			get => GetProperty(ref _rampUpDistanceStart);
			set => SetProperty(ref _rampUpDistanceStart, value);
		}

		[Ordinal(5)] 
		[RED("rampUpDistanceEnd")] 
		public CFloat RampUpDistanceEnd
		{
			get => GetProperty(ref _rampUpDistanceEnd);
			set => SetProperty(ref _rampUpDistanceEnd, value);
		}

		[Ordinal(6)] 
		[RED("rampDownDistanceStart")] 
		public CFloat RampDownDistanceStart
		{
			get => GetProperty(ref _rampDownDistanceStart);
			set => SetProperty(ref _rampDownDistanceStart, value);
		}

		[Ordinal(7)] 
		[RED("rampDownDistanceEnd")] 
		public CFloat RampDownDistanceEnd
		{
			get => GetProperty(ref _rampDownDistanceEnd);
			set => SetProperty(ref _rampDownDistanceEnd, value);
		}

		[Ordinal(8)] 
		[RED("rampDownFactor")] 
		public CFloat RampDownFactor
		{
			get => GetProperty(ref _rampDownFactor);
			set => SetProperty(ref _rampDownFactor, value);
		}

		[Ordinal(9)] 
		[RED("randomizePhase")] 
		public CBool RandomizePhase
		{
			get => GetProperty(ref _randomizePhase);
			set => SetProperty(ref _randomizePhase, value);
		}

		[Ordinal(10)] 
		[RED("randomizeDirection")] 
		public CBool RandomizeDirection
		{
			get => GetProperty(ref _randomizeDirection);
			set => SetProperty(ref _randomizeDirection, value);
		}

		public gameprojectileSpiralParams()
		{
			_cycleTimeMin = 0.100000F;
			_cycleTimeMax = 0.100000F;
			_rampUpDistanceEnd = 1.000000F;
			_rampDownDistanceStart = 1.000000F;
			_rampDownDistanceEnd = 2.000000F;
		}
	}
}
