using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class sampleUIPathAndReferenceGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("textWidget")] public inkTextWidgetReference TextWidget { get; set; }
		[Ordinal(1)]  [RED("imageWidgetPath")] public inkWidgetPath ImageWidgetPath { get; set; }
		[Ordinal(2)]  [RED("imageWidget")] public wCHandle<inkImageWidget> ImageWidget { get; set; }
		[Ordinal(3)]  [RED("panelWidget")] public wCHandle<inkBasePanelWidget> PanelWidget { get; set; }

		public sampleUIPathAndReferenceGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
