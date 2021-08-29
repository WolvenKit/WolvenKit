using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnCameraAnimationLOD : RedBaseClass
	{
		private CStatic<scnAnimationMotionSample> _trajectory;
		private CStatic<CStatic<CFloat>> _tracks;

		[Ordinal(0)] 
		[RED("trajectory", 3)] 
		public CStatic<scnAnimationMotionSample> Trajectory
		{
			get => GetProperty(ref _trajectory);
			set => SetProperty(ref _trajectory, value);
		}

		[Ordinal(1)] 
		[RED("tracks", 3, 7)] 
		public CStatic<CStatic<CFloat>> Tracks
		{
			get => GetProperty(ref _tracks);
			set => SetProperty(ref _tracks, value);
		}
	}
}
