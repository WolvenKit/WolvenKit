using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WorldMapTooltipBaseController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("active")] public CBool Active { get; set; }
		[Ordinal(1)]  [RED("root")] public inkWidgetReference Root { get; set; }
		[Ordinal(2)]  [RED("showHideAnim")] public CHandle<inkanimProxy> ShowHideAnim { get; set; }
		[Ordinal(3)]  [RED("visible")] public CBool Visible { get; set; }

		public WorldMapTooltipBaseController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
