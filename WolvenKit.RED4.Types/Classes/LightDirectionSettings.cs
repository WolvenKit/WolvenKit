using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			Direction = new() { TimeOfYearSeason = Enums.ETimeOfYearSeason.ETOYS_Summer };
		}
	}
}
