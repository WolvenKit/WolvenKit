using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class WorldMapLegendController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("initialized")] public CBool Initialized { get; set; }
		[Ordinal(1)]  [RED("list")] public inkCompoundWidgetReference List { get; set; }
		[Ordinal(2)]  [RED("visible")] public CBool Visible { get; set; }

		public WorldMapLegendController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
