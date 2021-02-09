using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GoToMenuEvent : redEvent
	{
		[Ordinal(0)]  [RED("menuType")] public CEnum<EComputerMenuType> MenuType { get; set; }
		[Ordinal(1)]  [RED("wakeUp")] public CBool WakeUp { get; set; }
		[Ordinal(2)]  [RED("ownerID")] public entEntityID OwnerID { get; set; }

		public GoToMenuEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
