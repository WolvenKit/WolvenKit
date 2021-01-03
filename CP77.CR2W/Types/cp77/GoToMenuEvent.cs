using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class GoToMenuEvent : redEvent
	{
		[Ordinal(0)]  [RED("menuType")] public CEnum<EComputerMenuType> MenuType { get; set; }
		[Ordinal(1)]  [RED("ownerID")] public entEntityID OwnerID { get; set; }
		[Ordinal(2)]  [RED("wakeUp")] public CBool WakeUp { get; set; }

		public GoToMenuEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
