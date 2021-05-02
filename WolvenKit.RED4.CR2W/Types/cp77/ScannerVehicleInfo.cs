using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerVehicleInfo : ScannerChunk
	{
		private CString _vehicleInfo;

		[Ordinal(0)] 
		[RED("vehicleInfo")] 
		public CString VehicleInfo
		{
			get => GetProperty(ref _vehicleInfo);
			set => SetProperty(ref _vehicleInfo, value);
		}

		public ScannerVehicleInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
