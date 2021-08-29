using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioVehicleGridDestruction : audioAudioMetadata
	{
		private CFloat _minGridCellRawChangeThreshold;
		private CFloat _specificGridCellImpactCooldown;
		private CFloat _minGridCellValueToPlayDetailedEvent;
		private audioVehicleDestructionGridLayer _bottomLayer;
		private audioVehicleDestructionGridLayer _upperLayer;

		[Ordinal(1)] 
		[RED("minGridCellRawChangeThreshold")] 
		public CFloat MinGridCellRawChangeThreshold
		{
			get => GetProperty(ref _minGridCellRawChangeThreshold);
			set => SetProperty(ref _minGridCellRawChangeThreshold, value);
		}

		[Ordinal(2)] 
		[RED("specificGridCellImpactCooldown")] 
		public CFloat SpecificGridCellImpactCooldown
		{
			get => GetProperty(ref _specificGridCellImpactCooldown);
			set => SetProperty(ref _specificGridCellImpactCooldown, value);
		}

		[Ordinal(3)] 
		[RED("minGridCellValueToPlayDetailedEvent")] 
		public CFloat MinGridCellValueToPlayDetailedEvent
		{
			get => GetProperty(ref _minGridCellValueToPlayDetailedEvent);
			set => SetProperty(ref _minGridCellValueToPlayDetailedEvent, value);
		}

		[Ordinal(4)] 
		[RED("bottomLayer")] 
		public audioVehicleDestructionGridLayer BottomLayer
		{
			get => GetProperty(ref _bottomLayer);
			set => SetProperty(ref _bottomLayer, value);
		}

		[Ordinal(5)] 
		[RED("upperLayer")] 
		public audioVehicleDestructionGridLayer UpperLayer
		{
			get => GetProperty(ref _upperLayer);
			set => SetProperty(ref _upperLayer, value);
		}
	}
}
