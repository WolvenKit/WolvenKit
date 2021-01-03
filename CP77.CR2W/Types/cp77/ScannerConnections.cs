using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ScannerConnections : ScannerChunk
	{
		[Ordinal(0)]  [RED("deviceConnections")] public CArray<DeviceConnectionScannerData> DeviceConnections { get; set; }

		public ScannerConnections(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
