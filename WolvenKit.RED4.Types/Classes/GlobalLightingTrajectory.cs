using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GlobalLightingTrajectory : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("latitude")] 
		public CFloat Latitude
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("sunRotationOffset")] 
		public CFloat SunRotationOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("moonRotationOffset")] 
		public CFloat MoonRotationOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("timeOfYearSeason")] 
		public CEnum<ETimeOfYearSeason> TimeOfYearSeason
		{
			get => GetPropertyValue<CEnum<ETimeOfYearSeason>>();
			set => SetPropertyValue<CEnum<ETimeOfYearSeason>>(value);
		}

		public GlobalLightingTrajectory()
		{
			TimeOfYearSeason = Enums.ETimeOfYearSeason.ETOYS_Summer;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
