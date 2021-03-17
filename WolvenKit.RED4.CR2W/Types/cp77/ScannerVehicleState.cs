using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerVehicleState : ScannerChunk
	{
		private CString _vehicleState;

		[Ordinal(0)] 
		[RED("vehicleState")] 
		public CString VehicleState
		{
			get => GetProperty(ref _vehicleState);
			set => SetProperty(ref _vehicleState, value);
		}

		public ScannerVehicleState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
