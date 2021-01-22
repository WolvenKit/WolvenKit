using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InventoryStatItemV2 : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("BackgroundIcon")] public inkImageWidgetReference BackgroundIcon { get; set; }
		[Ordinal(1)]  [RED("Icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(2)]  [RED("IntroPlayed")] public CBool IntroPlayed { get; set; }
		[Ordinal(3)]  [RED("LabelRef")] public inkTextWidgetReference LabelRef { get; set; }
		[Ordinal(4)]  [RED("TextGroup")] public inkWidgetReference TextGroup { get; set; }
		[Ordinal(5)]  [RED("ValueRef")] public inkTextWidgetReference ValueRef { get; set; }

		public InventoryStatItemV2(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
