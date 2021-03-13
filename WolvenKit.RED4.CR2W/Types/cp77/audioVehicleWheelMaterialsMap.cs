using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehicleWheelMaterialsMap : audioAudioMetadata
	{
		[Ordinal(1)] [RED("vehicleWheelMaterials")] public CArray<audioVehicleWheelMaterialsMapItem> VehicleWheelMaterials { get; set; }

		public audioVehicleWheelMaterialsMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
