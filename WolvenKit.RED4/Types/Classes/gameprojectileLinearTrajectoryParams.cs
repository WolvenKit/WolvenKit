using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameprojectileLinearTrajectoryParams : gameprojectileTrajectoryParams
	{
		[Ordinal(0)] 
		[RED("startVel")] 
		public CFloat StartVel
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("acceleration")] 
		public CFloat Acceleration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameprojectileLinearTrajectoryParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
