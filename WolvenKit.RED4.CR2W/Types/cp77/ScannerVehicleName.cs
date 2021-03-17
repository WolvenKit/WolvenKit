using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerVehicleName : ScannerChunk
	{
		private CString _vehicleName;

		[Ordinal(0)] 
		[RED("vehicleName")] 
		public CString VehicleName
		{
			get => GetProperty(ref _vehicleName);
			set => SetProperty(ref _vehicleName, value);
		}

		public ScannerVehicleName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
