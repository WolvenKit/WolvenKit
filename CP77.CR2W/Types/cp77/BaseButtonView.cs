using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BaseButtonView : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("ButtonController")] public wCHandle<inkButtonController> ButtonController { get; set; }

		public BaseButtonView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
