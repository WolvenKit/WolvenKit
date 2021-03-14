using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerConnections : ScannerChunk
	{
		private CArray<DeviceConnectionScannerData> _deviceConnections;

		[Ordinal(0)] 
		[RED("deviceConnections")] 
		public CArray<DeviceConnectionScannerData> DeviceConnections
		{
			get
			{
				if (_deviceConnections == null)
				{
					_deviceConnections = (CArray<DeviceConnectionScannerData>) CR2WTypeManager.Create("array:DeviceConnectionScannerData", "deviceConnections", cr2w, this);
				}
				return _deviceConnections;
			}
			set
			{
				if (_deviceConnections == value)
				{
					return;
				}
				_deviceConnections = value;
				PropertySet(this);
			}
		}

		public ScannerConnections(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
