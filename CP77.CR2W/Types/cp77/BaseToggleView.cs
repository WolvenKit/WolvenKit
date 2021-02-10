using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BaseToggleView : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("ToggleController")] public wCHandle<inkToggleController> ToggleController { get; set; }
		[Ordinal(1)]  [RED("OldState")] public CEnum<inkEToggleState> OldState { get; set; }

		public BaseToggleView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
