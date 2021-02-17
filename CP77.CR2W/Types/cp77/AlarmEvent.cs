using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AlarmEvent : redEvent
	{
		[Ordinal(0)] [RED("isValid")] public CBool IsValid { get; set; }
		[Ordinal(1)] [RED("ID")] public gameDelayID ID { get; set; }

		public AlarmEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
