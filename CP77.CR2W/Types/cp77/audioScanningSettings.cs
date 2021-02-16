using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioScanningSettings : CVariable
	{
		[Ordinal(0)] [RED("scanningStartEvent")] public CName ScanningStartEvent { get; set; }
		[Ordinal(1)] [RED("scanningStopEvent")] public CName ScanningStopEvent { get; set; }
		[Ordinal(2)] [RED("scanningCompleteEvent")] public CName ScanningCompleteEvent { get; set; }
		[Ordinal(3)] [RED("scanningAvailableEvent")] public CName ScanningAvailableEvent { get; set; }

		public audioScanningSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
