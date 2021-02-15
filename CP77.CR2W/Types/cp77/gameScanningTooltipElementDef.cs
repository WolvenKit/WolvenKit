using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameScanningTooltipElementDef : CVariable
	{
		[Ordinal(0)] [RED("recordID")] public TweakDBID RecordID { get; set; }
		[Ordinal(1)] [RED("timePct")] public CFloat TimePct { get; set; }

		public gameScanningTooltipElementDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
