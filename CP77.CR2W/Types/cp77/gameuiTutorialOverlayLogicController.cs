using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiTutorialOverlayLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("hideInMenu")] public CBool HideInMenu { get; set; }
		[Ordinal(1)]  [RED("hideOnInput")] public CBool HideOnInput { get; set; }

		public gameuiTutorialOverlayLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
