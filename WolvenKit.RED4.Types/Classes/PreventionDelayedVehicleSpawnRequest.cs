using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PreventionDelayedVehicleSpawnRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("heatStage")] 
		public CEnum<EPreventionHeatStage> HeatStage
		{
			get => GetPropertyValue<CEnum<EPreventionHeatStage>>();
			set => SetPropertyValue<CEnum<EPreventionHeatStage>>(value);
		}

		public PreventionDelayedVehicleSpawnRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
