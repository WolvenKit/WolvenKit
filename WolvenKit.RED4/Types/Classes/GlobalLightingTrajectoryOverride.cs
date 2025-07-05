using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GlobalLightingTrajectoryOverride : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("overrideScale")] 
		public CFloat OverrideScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("latitude")] 
		public CFloat Latitude
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("sunRotationOffset")] 
		public CFloat SunRotationOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("moonRotationOffset")] 
		public CFloat MoonRotationOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("timeOfYearSeason")] 
		public CEnum<ETimeOfYearSeason> TimeOfYearSeason
		{
			get => GetPropertyValue<CEnum<ETimeOfYearSeason>>();
			set => SetPropertyValue<CEnum<ETimeOfYearSeason>>(value);
		}

		public GlobalLightingTrajectoryOverride()
		{
			TimeOfYearSeason = Enums.ETimeOfYearSeason.ETOYS_Summer;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
