using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questPlayEnv_OverrideGlobalLight : questIEnvironmentManagerNodeType
	{
		[Ordinal(0)] 
		[RED("params")] 
		public worldWorldGlobalLightOverrideWithColorParameters Params
		{
			get => GetPropertyValue<worldWorldGlobalLightOverrideWithColorParameters>();
			set => SetPropertyValue<worldWorldGlobalLightOverrideWithColorParameters>(value);
		}

		public questPlayEnv_OverrideGlobalLight()
		{
			Params = new worldWorldGlobalLightOverrideWithColorParameters { LightDirOverride = new GlobalLightingTrajectoryOverride { TimeOfYearSeason = Enums.ETimeOfYearSeason.ETOYS_Summer }, LightColorOverride = new HDRColor() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
