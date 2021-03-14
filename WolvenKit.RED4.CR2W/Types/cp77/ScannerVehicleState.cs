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
			get
			{
				if (_vehicleState == null)
				{
					_vehicleState = (CString) CR2WTypeManager.Create("String", "vehicleState", cr2w, this);
				}
				return _vehicleState;
			}
			set
			{
				if (_vehicleState == value)
				{
					return;
				}
				_vehicleState = value;
				PropertySet(this);
			}
		}

		public ScannerVehicleState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
