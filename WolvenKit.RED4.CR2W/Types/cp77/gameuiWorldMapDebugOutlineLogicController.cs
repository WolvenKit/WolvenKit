using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiWorldMapDebugOutlineLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("outlineWidget")] public inkShapeWidgetReference OutlineWidget { get; set; }

		public gameuiWorldMapDebugOutlineLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
