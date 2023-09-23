using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PreventionDelayedSpawnBaseRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("heatStage")] 
		public CEnum<EPreventionHeatStage> HeatStage
		{
			get => GetPropertyValue<CEnum<EPreventionHeatStage>>();
			set => SetPropertyValue<CEnum<EPreventionHeatStage>>(value);
		}

		public PreventionDelayedSpawnBaseRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
