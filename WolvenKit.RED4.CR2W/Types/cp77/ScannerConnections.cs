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
			get => GetProperty(ref _deviceConnections);
			set => SetProperty(ref _deviceConnections, value);
		}

		public ScannerConnections(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
