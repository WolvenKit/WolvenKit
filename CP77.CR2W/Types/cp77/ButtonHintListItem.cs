using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ButtonHintListItem : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("inputDisplay")] public inkWidgetReference InputDisplay { get; set; }
		[Ordinal(1)]  [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(2)]  [RED("buttonHint")] public wCHandle<inkInputDisplayController> ButtonHint { get; set; }
		[Ordinal(3)]  [RED("actionName")] public CName ActionName { get; set; }

		public ButtonHintListItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
