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
			get
			{
				if (_vehicleProdYears == null)
				{
					_vehicleProdYears = (CString) CR2WTypeManager.Create("String", "vehicleProdYears", cr2w, this);
				}
				return _vehicleProdYears;
			}
			set
			{
				if (_vehicleProdYears == value)
				{
					return;
				}
				_vehicleProdYears = value;
				PropertySet(this);
			}
		}

		public ScannerVehicleProdYears(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
