using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehicleWheelMaterialsMap : audioAudioMetadata
	{
		private CArray<audioVehicleWheelMaterialsMapItem> _vehicleWheelMaterials;

		[Ordinal(1)] 
		[RED("vehicleWheelMaterials")] 
		public CArray<audioVehicleWheelMaterialsMapItem> VehicleWheelMaterials
		{
			get => GetProperty(ref _vehicleWheelMaterials);
			set => SetProperty(ref _vehicleWheelMaterials, value);
		}

		public audioVehicleWheelMaterialsMap(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
