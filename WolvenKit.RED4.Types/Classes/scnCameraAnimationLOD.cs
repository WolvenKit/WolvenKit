using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnCameraAnimationLOD : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("trajectory", 3)] 
		public CStatic<scnAnimationMotionSample> Trajectory
		{
			get => GetPropertyValue<CStatic<scnAnimationMotionSample>>();
			set => SetPropertyValue<CStatic<scnAnimationMotionSample>>(value);
		}

		[Ordinal(1)] 
		[RED("tracks", 3, 7)] 
		public CStatic<CStatic<CFloat>> Tracks
		{
			get => GetPropertyValue<CStatic<CStatic<CFloat>>>();
			set => SetPropertyValue<CStatic<CStatic<CFloat>>>(value);
		}

		public scnCameraAnimationLOD()
		{
			Trajectory = new(0);
			Tracks = new(0);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
