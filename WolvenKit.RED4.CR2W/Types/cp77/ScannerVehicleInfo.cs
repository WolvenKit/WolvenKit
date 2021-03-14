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
			get
			{
				if (_vehicleInfo == null)
				{
					_vehicleInfo = (CString) CR2WTypeManager.Create("String", "vehicleInfo", cr2w, this);
				}
				return _vehicleInfo;
			}
			set
			{
				if (_vehicleInfo == value)
				{
					return;
				}
				_vehicleInfo = value;
				PropertySet(this);
			}
		}

		public ScannerVehicleInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
