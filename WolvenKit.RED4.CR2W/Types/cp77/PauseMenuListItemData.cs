using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PauseMenuListItemData : ListItemData
	{
		[Ordinal(1)] [RED("eventName")] public CName EventName { get; set; }
		[Ordinal(2)] [RED("action")] public CEnum<PauseMenuAction> Action { get; set; }

		public PauseMenuListItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
