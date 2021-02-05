using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiScannerGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("currentTarget")] public entEntityID CurrentTarget { get; set; }
		[Ordinal(1)]  [RED("scanLock")] public CBool ScanLock { get; set; }
		[Ordinal(2)]  [RED("percentValue")] public CFloat PercentValue { get; set; }
		[Ordinal(3)]  [RED("oldPercentValue")] public CFloat OldPercentValue { get; set; }

		public gameuiScannerGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
