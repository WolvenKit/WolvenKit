using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetWantedLevel : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("wantedLevel")] 
		public CEnum<EPreventionHeatStage> WantedLevel
		{
			get => GetPropertyValue<CEnum<EPreventionHeatStage>>();
			set => SetPropertyValue<CEnum<EPreventionHeatStage>>(value);
		}

		[Ordinal(1)] 
		[RED("forcePlayerPositionAsLastCrimePoint")] 
		public CBool ForcePlayerPositionAsLastCrimePoint
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SetWantedLevel()
		{
			WantedLevel = Enums.EPreventionHeatStage.Heat_1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
