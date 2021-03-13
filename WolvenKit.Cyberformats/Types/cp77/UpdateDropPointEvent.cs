using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UpdateDropPointEvent : redEvent
	{
		[Ordinal(0)] [RED("isEnabled")] public CBool IsEnabled { get; set; }

		public UpdateDropPointEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
