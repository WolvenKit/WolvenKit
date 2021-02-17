using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CraftingNotificationViewData : gameuiGenericNotificationViewData
	{
		[Ordinal(5)] [RED("canBeMerged")] public CBool CanBeMerged { get; set; }

		public CraftingNotificationViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
