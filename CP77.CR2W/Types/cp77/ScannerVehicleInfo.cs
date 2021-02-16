using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScannerVehicleInfo : ScannerChunk
	{
		[Ordinal(0)] [RED("vehicleInfo")] public CString VehicleInfo { get; set; }

		public ScannerVehicleInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
