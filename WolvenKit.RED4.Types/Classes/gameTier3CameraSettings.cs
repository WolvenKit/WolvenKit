using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTier3CameraSettings : RedBaseClass
	{
		private CFloat _yawLeftLimit;
		private CFloat _yawRightLimit;
		private CFloat _pitchTopLimit;
		private CFloat _pitchBottomLimit;
		private CFloat _pitchSpeedMultiplier;
		private CFloat _yawSpeedMultiplier;

		[Ordinal(0)] 
		[RED("yawLeftLimit")] 
		public CFloat YawLeftLimit
		{
			get => GetProperty(ref _yawLeftLimit);
			set => SetProperty(ref _yawLeftLimit, value);
		}

		[Ordinal(1)] 
		[RED("yawRightLimit")] 
		public CFloat YawRightLimit
		{
			get => GetProperty(ref _yawRightLimit);
			set => SetProperty(ref _yawRightLimit, value);
		}

		[Ordinal(2)] 
		[RED("pitchTopLimit")] 
		public CFloat PitchTopLimit
		{
			get => GetProperty(ref _pitchTopLimit);
			set => SetProperty(ref _pitchTopLimit, value);
		}

		[Ordinal(3)] 
		[RED("pitchBottomLimit")] 
		public CFloat PitchBottomLimit
		{
			get => GetProperty(ref _pitchBottomLimit);
			set => SetProperty(ref _pitchBottomLimit, value);
		}

		[Ordinal(4)] 
		[RED("pitchSpeedMultiplier")] 
		public CFloat PitchSpeedMultiplier
		{
			get => GetProperty(ref _pitchSpeedMultiplier);
			set => SetProperty(ref _pitchSpeedMultiplier, value);
		}

		[Ordinal(5)] 
		[RED("yawSpeedMultiplier")] 
		public CFloat YawSpeedMultiplier
		{
			get => GetProperty(ref _yawSpeedMultiplier);
			set => SetProperty(ref _yawSpeedMultiplier, value);
		}

		public gameTier3CameraSettings()
		{
			_yawLeftLimit = 60.000000F;
			_yawRightLimit = 60.000000F;
			_pitchTopLimit = 60.000000F;
			_pitchBottomLimit = 45.000000F;
			_pitchSpeedMultiplier = 1.000000F;
			_yawSpeedMultiplier = 1.000000F;
		}
	}
}
