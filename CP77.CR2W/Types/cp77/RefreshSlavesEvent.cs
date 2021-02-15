using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RefreshSlavesEvent : redEvent
	{
		[Ordinal(0)] [RED("onInitialize")] public CBool OnInitialize { get; set; }

		public RefreshSlavesEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
