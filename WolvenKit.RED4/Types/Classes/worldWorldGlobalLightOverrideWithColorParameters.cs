using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldWorldGlobalLightOverrideWithColorParameters : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("lightDirOverride")] 
		public GlobalLightingTrajectoryOverride LightDirOverride
		{
			get => GetPropertyValue<GlobalLightingTrajectoryOverride>();
			set => SetPropertyValue<GlobalLightingTrajectoryOverride>(value);
		}

		[Ordinal(1)] 
		[RED("lightColorOverride")] 
		public HDRColor LightColorOverride
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		public worldWorldGlobalLightOverrideWithColorParameters()
		{
			LightDirOverride = new GlobalLightingTrajectoryOverride { TimeOfYearSeason = Enums.ETimeOfYearSeason.ETOYS_Summer };
			LightColorOverride = new HDRColor();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
