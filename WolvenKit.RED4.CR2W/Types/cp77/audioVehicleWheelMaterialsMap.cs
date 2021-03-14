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
			get
			{
				if (_vehicleWheelMaterials == null)
				{
					_vehicleWheelMaterials = (CArray<audioVehicleWheelMaterialsMapItem>) CR2WTypeManager.Create("array:audioVehicleWheelMaterialsMapItem", "vehicleWheelMaterials", cr2w, this);
				}
				return _vehicleWheelMaterials;
			}
			set
			{
				if (_vehicleWheelMaterials == value)
				{
					return;
				}
				_vehicleWheelMaterials = value;
				PropertySet(this);
			}
		}

		public audioVehicleWheelMaterialsMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
