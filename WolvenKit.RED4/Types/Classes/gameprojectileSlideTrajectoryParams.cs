using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameprojectileSlideTrajectoryParams : gameprojectileTrajectoryParams
	{
		[Ordinal(0)] 
		[RED("stickiness")] 
		public CFloat Stickiness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("constAccel")] 
		public Vector4 ConstAccel
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public gameprojectileSlideTrajectoryParams()
		{
			Stickiness = 0.500000F;
			ConstAccel = new Vector4 { Z = -0.500000F, W = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
