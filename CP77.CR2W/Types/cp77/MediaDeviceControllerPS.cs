using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MediaDeviceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(103)] [RED("previousStation")] public CInt32 PreviousStation { get; set; }
		[Ordinal(104)] [RED("activeChannelName")] public CString ActiveChannelName { get; set; }
		[Ordinal(105)] [RED("dataInitialized")] public CBool DataInitialized { get; set; }
		[Ordinal(106)] [RED("amountOfStations")] public CInt32 AmountOfStations { get; set; }
		[Ordinal(107)] [RED("activeStation")] public CInt32 ActiveStation { get; set; }

		public MediaDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
