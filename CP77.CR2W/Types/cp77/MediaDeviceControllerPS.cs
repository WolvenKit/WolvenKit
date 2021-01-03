using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MediaDeviceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(0)]  [RED("activeChannelName")] public CString ActiveChannelName { get; set; }
		[Ordinal(1)]  [RED("activeStation")] public CInt32 ActiveStation { get; set; }
		[Ordinal(2)]  [RED("amountOfStations")] public CInt32 AmountOfStations { get; set; }
		[Ordinal(3)]  [RED("dataInitialized")] public CBool DataInitialized { get; set; }
		[Ordinal(4)]  [RED("previousStation")] public CInt32 PreviousStation { get; set; }

		public MediaDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
