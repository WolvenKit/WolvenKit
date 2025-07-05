using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioVehicleGridDestruction : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("minGridCellRawChangeThreshold")] 
		public CFloat MinGridCellRawChangeThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("specificGridCellImpactCooldown")] 
		public CFloat SpecificGridCellImpactCooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("minGridCellValueToPlayDetailedEvent")] 
		public CFloat MinGridCellValueToPlayDetailedEvent
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("bottomLayer")] 
		public audioVehicleDestructionGridLayer BottomLayer
		{
			get => GetPropertyValue<audioVehicleDestructionGridLayer>();
			set => SetPropertyValue<audioVehicleDestructionGridLayer>(value);
		}

		[Ordinal(5)] 
		[RED("upperLayer")] 
		public audioVehicleDestructionGridLayer UpperLayer
		{
			get => GetPropertyValue<audioVehicleDestructionGridLayer>();
			set => SetPropertyValue<audioVehicleDestructionGridLayer>(value);
		}

		public audioVehicleGridDestruction()
		{
			BottomLayer = new audioVehicleDestructionGridLayer { BackLeft = new audioVehicleDestructionGridCell(), BackRight = new audioVehicleDestructionGridCell(), CenterBackLeft = new audioVehicleDestructionGridCell(), CenterBackRight = new audioVehicleDestructionGridCell(), CenterForwardLeft = new audioVehicleDestructionGridCell(), CenterForwardRight = new audioVehicleDestructionGridCell(), FrontLeft = new audioVehicleDestructionGridCell(), FrontRight = new audioVehicleDestructionGridCell() };
			UpperLayer = new audioVehicleDestructionGridLayer { BackLeft = new audioVehicleDestructionGridCell(), BackRight = new audioVehicleDestructionGridCell(), CenterBackLeft = new audioVehicleDestructionGridCell(), CenterBackRight = new audioVehicleDestructionGridCell(), CenterForwardLeft = new audioVehicleDestructionGridCell(), CenterForwardRight = new audioVehicleDestructionGridCell(), FrontLeft = new audioVehicleDestructionGridCell(), FrontRight = new audioVehicleDestructionGridCell() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
