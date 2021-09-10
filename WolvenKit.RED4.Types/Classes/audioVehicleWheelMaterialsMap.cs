using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioVehicleWheelMaterialsMap : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("vehicleWheelMaterials")] 
		public CArray<audioVehicleWheelMaterialsMapItem> VehicleWheelMaterials
		{
			get => GetPropertyValue<CArray<audioVehicleWheelMaterialsMapItem>>();
			set => SetPropertyValue<CArray<audioVehicleWheelMaterialsMapItem>>(value);
		}

		public audioVehicleWheelMaterialsMap()
		{
			VehicleWheelMaterials = new();
		}
	}
}
