using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiGlobaltvWidgetGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("overlayContainer")] public inkCompoundWidgetReference OverlayContainer { get; set; }

		public gameuiGlobaltvWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
