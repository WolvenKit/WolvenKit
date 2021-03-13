using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TimeSkipPopupCloseData : inkGameNotificationData
	{
		[Ordinal(6)] [RED("timeChanged")] public CBool TimeChanged { get; set; }

		public TimeSkipPopupCloseData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
