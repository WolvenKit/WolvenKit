using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PreventionDelayedSpawnRequest : gameScriptableSystemRequest
	{
		private CEnum<EPreventionHeatStage> _heatStage;

		[Ordinal(0)] 
		[RED("heatStage")] 
		public CEnum<EPreventionHeatStage> HeatStage
		{
			get => GetProperty(ref _heatStage);
			set => SetProperty(ref _heatStage, value);
		}
	}
}
