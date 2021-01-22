using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PauseMenuListItemData : ListItemData
	{
		[Ordinal(0)]  [RED("action")] public CEnum<PauseMenuAction> Action { get; set; }
		[Ordinal(1)]  [RED("eventName")] public CName EventName { get; set; }

		public PauseMenuListItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
