using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiGlobaltvWidgetGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("overlayContainer")] public inkCompoundWidgetReference OverlayContainer { get; set; }

		public gameuiGlobaltvWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
