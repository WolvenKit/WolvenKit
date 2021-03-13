using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleUIPathAndReferenceGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("textWidget")] public inkTextWidgetReference TextWidget { get; set; }
		[Ordinal(3)] [RED("imageWidgetPath")] public inkWidgetPath ImageWidgetPath { get; set; }
		[Ordinal(4)] [RED("imageWidget")] public wCHandle<inkImageWidget> ImageWidget { get; set; }
		[Ordinal(5)] [RED("panelWidget")] public wCHandle<inkBasePanelWidget> PanelWidget { get; set; }

		public sampleUIPathAndReferenceGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
