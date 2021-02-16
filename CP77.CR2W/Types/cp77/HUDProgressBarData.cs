using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HUDProgressBarData : CVariable
	{
		[Ordinal(0)] [RED("header")] public CString Header { get; set; }
		[Ordinal(1)] [RED("active")] public CBool Active { get; set; }
		[Ordinal(2)] [RED("progress")] public CFloat Progress { get; set; }

		public HUDProgressBarData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
