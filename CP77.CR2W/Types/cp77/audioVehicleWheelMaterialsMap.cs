using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioVehicleWheelMaterialsMap : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("vehicleWheelMaterials")] public CArray<audioVehicleWheelMaterialsMapItem> VehicleWheelMaterials { get; set; }

		public audioVehicleWheelMaterialsMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
