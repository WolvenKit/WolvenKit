using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameprojectileSlideTrajectoryParams : gameprojectileTrajectoryParams
	{
		private CFloat _stickiness;
		private Vector4 _constAccel;

		[Ordinal(0)] 
		[RED("stickiness")] 
		public CFloat Stickiness
		{
			get => GetProperty(ref _stickiness);
			set => SetProperty(ref _stickiness, value);
		}

		[Ordinal(1)] 
		[RED("constAccel")] 
		public Vector4 ConstAccel
		{
			get => GetProperty(ref _constAccel);
			set => SetProperty(ref _constAccel, value);
		}

		public gameprojectileSlideTrajectoryParams()
		{
			_stickiness = 0.500000F;
		}
	}
}
