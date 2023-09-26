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
		[RED("forceGreyStars")] 
		public CBool ForceGreyStars
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("resetGreyStars")] 
		public CBool ResetGreyStars
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("forcePlayerPositionAsLastCrimePoint")] 
		public CBool ForcePlayerPositionAsLastCrimePoint
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("forceIgnoreSecurityAreas")] 
		public CBool ForceIgnoreSecurityAreas
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SetWantedLevel()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
