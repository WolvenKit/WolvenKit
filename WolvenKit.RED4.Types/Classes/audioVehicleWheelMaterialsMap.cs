using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioVehicleWheelMaterialsMap : audioAudioMetadata
	{
		private CArray<audioVehicleWheelMaterialsMapItem> _vehicleWheelMaterials;

		[Ordinal(1)] 
		[RED("vehicleWheelMaterials")] 
		public CArray<audioVehicleWheelMaterialsMapItem> VehicleWheelMaterials
		{
			get => GetProperty(ref _vehicleWheelMaterials);
			set => SetProperty(ref _vehicleWheelMaterials, value);
		}
	}
}
