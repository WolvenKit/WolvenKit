using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerVehicleInfo : ScannerChunk
	{
		[Ordinal(0)] [RED("vehicleInfo")] public CString VehicleInfo { get; set; }

		public ScannerVehicleInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
