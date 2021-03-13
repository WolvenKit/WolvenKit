using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleUIAnchorController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("rectangleAnchor")] public inkRectangleWidgetReference RectangleAnchor { get; set; }

		public sampleUIAnchorController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
