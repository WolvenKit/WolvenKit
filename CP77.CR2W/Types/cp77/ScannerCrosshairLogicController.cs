using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ScannerCrosshairLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("projection")] public CHandle<inkScreenProjection> Projection { get; set; }
		[Ordinal(1)]  [RED("rootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }

		public ScannerCrosshairLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
