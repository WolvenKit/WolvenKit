using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkListItemController : inkButtonController
	{
		[Ordinal(10)] [RED("ToggledOff")] public inkListItemControllerCallback ToggledOff { get; set; }
		[Ordinal(11)] [RED("ToggledOn")] public inkListItemControllerCallback ToggledOn { get; set; }
		[Ordinal(12)] [RED("Selected")] public inkListItemControllerCallback Selected_656 { get; set; }
		[Ordinal(13)] [RED("Deselected")] public inkListItemControllerCallback Deselected { get; set; }
		[Ordinal(14)] [RED("AddedToList")] public inkListItemControllerCallback AddedToList { get; set; }
		[Ordinal(15)] [RED("labelPathRef")] public inkTextWidgetReference LabelPathRef { get; set; }

		public inkListItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
