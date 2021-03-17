using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerVehicleDriveLayout : ScannerChunk
	{
		private CString _vehicleDriveLayout;

		[Ordinal(0)] 
		[RED("vehicleDriveLayout")] 
		public CString VehicleDriveLayout
		{
			get => GetProperty(ref _vehicleDriveLayout);
			set => SetProperty(ref _vehicleDriveLayout, value);
		}

		public ScannerVehicleDriveLayout(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
