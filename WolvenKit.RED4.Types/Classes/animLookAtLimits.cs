using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animLookAtLimits : RedBaseClass
	{
		private CFloat _softLimitDegrees;
		private CFloat _hardLimitDegrees;
		private CFloat _hardLimitDistance;
		private CFloat _backLimitDegrees;

		[Ordinal(0)] 
		[RED("softLimitDegrees")] 
		public CFloat SoftLimitDegrees
		{
			get => GetProperty(ref _softLimitDegrees);
			set => SetProperty(ref _softLimitDegrees, value);
		}

		[Ordinal(1)] 
		[RED("hardLimitDegrees")] 
		public CFloat HardLimitDegrees
		{
			get => GetProperty(ref _hardLimitDegrees);
			set => SetProperty(ref _hardLimitDegrees, value);
		}

		[Ordinal(2)] 
		[RED("hardLimitDistance")] 
		public CFloat HardLimitDistance
		{
			get => GetProperty(ref _hardLimitDistance);
			set => SetProperty(ref _hardLimitDistance, value);
		}

		[Ordinal(3)] 
		[RED("backLimitDegrees")] 
		public CFloat BackLimitDegrees
		{
			get => GetProperty(ref _backLimitDegrees);
			set => SetProperty(ref _backLimitDegrees, value);
		}

		public animLookAtLimits()
		{
			_softLimitDegrees = 360.000000F;
			_hardLimitDegrees = 360.000000F;
			_hardLimitDistance = 1000000.000000F;
			_backLimitDegrees = 180.000000F;
		}
	}
}
