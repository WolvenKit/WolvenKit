using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QHackWheelItemChangedEvent : redEvent
	{
		[Ordinal(0)] [RED("commandData")] public CHandle<QuickhackData> CommandData { get; set; }
		[Ordinal(1)] [RED("currentEmpty")] public CBool CurrentEmpty { get; set; }

		public QHackWheelItemChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
