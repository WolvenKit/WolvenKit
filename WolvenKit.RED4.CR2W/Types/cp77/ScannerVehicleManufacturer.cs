using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerVehicleManufacturer : ScannerChunk
	{
		private CString _vehicleManufacturer;

		[Ordinal(0)] 
		[RED("vehicleManufacturer")] 
		public CString VehicleManufacturer
		{
			get => GetProperty(ref _vehicleManufacturer);
			set => SetProperty(ref _vehicleManufacturer, value);
		}

		public ScannerVehicleManufacturer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
