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
			get
			{
				if (_vehicleName == null)
				{
					_vehicleName = (CString) CR2WTypeManager.Create("String", "vehicleName", cr2w, this);
				}
				return _vehicleName;
			}
			set
			{
				if (_vehicleName == value)
				{
					return;
				}
				_vehicleName = value;
				PropertySet(this);
			}
		}

		public ScannerVehicleName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
