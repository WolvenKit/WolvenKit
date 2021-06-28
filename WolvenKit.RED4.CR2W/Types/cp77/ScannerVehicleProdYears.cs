using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerVehicleProdYears : ScannerChunk
	{
		private CString _vehicleProdYears;

		[Ordinal(0)] 
		[RED("vehicleProdYears")] 
		public CString VehicleProdYears
		{
			get => GetProperty(ref _vehicleProdYears);
			set => SetProperty(ref _vehicleProdYears, value);
		}

		public ScannerVehicleProdYears(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
