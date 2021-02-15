using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ToggleGameplayMappinVisibilityEvent : redEvent
	{
		[Ordinal(0)] [RED("isHidden")] public CBool IsHidden { get; set; }

		public ToggleGameplayMappinVisibilityEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
