using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameweaponeventsOwnerAimEvent : redEvent
	{
		[Ordinal(0)] [RED("isAiming")] public CBool IsAiming { get; set; }

		public gameweaponeventsOwnerAimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
