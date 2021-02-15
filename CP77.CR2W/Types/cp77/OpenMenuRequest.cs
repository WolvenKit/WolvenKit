using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class OpenMenuRequest : redEvent
	{
		[Ordinal(0)] [RED("menuName")] public CName MenuName { get; set; }
		[Ordinal(1)] [RED("userData")] public CHandle<IScriptable> UserData { get; set; }
		[Ordinal(2)] [RED("jumpBack")] public CBool JumpBack { get; set; }
		[Ordinal(3)] [RED("eventData")] public MenuData EventData { get; set; }
		[Ordinal(4)] [RED("submenuName")] public CName SubmenuName { get; set; }
		[Ordinal(5)] [RED("isMainMenu")] public CBool IsMainMenu { get; set; }

		public OpenMenuRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
