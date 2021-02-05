using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiInputHintManagerGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("hintContainerId")] public CName HintContainerId { get; set; }
		[Ordinal(1)]  [RED("baseGroupContainer")] public inkCompoundWidgetReference BaseGroupContainer { get; set; }
		[Ordinal(2)]  [RED("groupsContainer")] public inkCompoundWidgetReference GroupsContainer { get; set; }
		[Ordinal(3)]  [RED("hintLibRef")] public inkWidgetLibraryReference HintLibRef { get; set; }
		[Ordinal(4)]  [RED("groupLibRef")] public inkWidgetLibraryReference GroupLibRef { get; set; }

		public gameuiInputHintManagerGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
