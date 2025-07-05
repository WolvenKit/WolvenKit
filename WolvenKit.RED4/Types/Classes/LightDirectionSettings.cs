using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LightDirectionSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("direction")] 
		public GlobalLightingTrajectoryOverride Direction
		{
			get => GetPropertyValue<GlobalLightingTrajectoryOverride>();
			set => SetPropertyValue<GlobalLightingTrajectoryOverride>(value);
		}

		public LightDirectionSettings()
		{
			Enable = true;
			Direction = new GlobalLightingTrajectoryOverride { TimeOfYearSeason = Enums.ETimeOfYearSeason.ETOYS_Summer };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
