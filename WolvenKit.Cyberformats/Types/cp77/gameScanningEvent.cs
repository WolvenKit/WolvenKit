using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameScanningEvent : redEvent
	{
		[Ordinal(0)] [RED("state")] public CEnum<gameScanningState> State { get; set; }

		public gameScanningEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
