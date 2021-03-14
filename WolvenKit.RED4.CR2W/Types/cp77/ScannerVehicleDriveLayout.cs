using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerVehicleDriveLayout : ScannerChunk
	{
		private CString _vehicleDriveLayout;

		[Ordinal(0)] 
		[RED("vehicleDriveLayout")] 
		public CString VehicleDriveLayout
		{
			get
			{
				if (_vehicleDriveLayout == null)
				{
					_vehicleDriveLayout = (CString) CR2WTypeManager.Create("String", "vehicleDriveLayout", cr2w, this);
				}
				return _vehicleDriveLayout;
			}
			set
			{
				if (_vehicleDriveLayout == value)
				{
					return;
				}
				_vehicleDriveLayout = value;
				PropertySet(this);
			}
		}

		public ScannerVehicleDriveLayout(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
