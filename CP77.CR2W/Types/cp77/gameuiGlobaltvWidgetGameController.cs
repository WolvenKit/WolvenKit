using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiGlobaltvWidgetGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("overlayContainer")] public inkCompoundWidgetReference OverlayContainer { get; set; }

		public gameuiGlobaltvWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
