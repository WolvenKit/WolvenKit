using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TimeSkipPopupCloseData : inkGameNotificationData
	{
		[Ordinal(6)] [RED("timeChanged")] public CBool TimeChanged { get; set; }

		public TimeSkipPopupCloseData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
