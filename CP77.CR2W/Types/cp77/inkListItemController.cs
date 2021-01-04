using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkListItemController : inkButtonController
	{
		[Ordinal(0)]  [RED("AddedToList")] public inkListItemControllerCallback AddedToList { get; set; }
		[Ordinal(1)]  [RED("Deselected")] public inkListItemControllerCallback Deselected { get; set; }
		[Ordinal(2)]  [RED("Selected")] public inkListItemControllerCallback Selected { get; set; }
		[Ordinal(3)]  [RED("ToggledOff")] public inkListItemControllerCallback ToggledOff { get; set; }
		[Ordinal(4)]  [RED("ToggledOn")] public inkListItemControllerCallback ToggledOn { get; set; }
		[Ordinal(5)]  [RED("labelPathRef")] public inkTextWidgetReference LabelPathRef { get; set; }

		public inkListItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
