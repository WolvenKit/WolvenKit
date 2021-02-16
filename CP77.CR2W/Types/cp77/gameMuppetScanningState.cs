using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameMuppetScanningState : CVariable
	{
		[Ordinal(0)] [RED("isScanning")] public CBool IsScanning { get; set; }

		public gameMuppetScanningState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
