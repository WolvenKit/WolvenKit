using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
