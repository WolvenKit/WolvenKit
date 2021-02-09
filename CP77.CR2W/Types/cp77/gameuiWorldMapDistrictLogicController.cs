using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiWorldMapDistrictLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("record")] public wCHandle<gamedataDistrict_Record> Record { get; set; }
		[Ordinal(1)]  [RED("type")] public CEnum<gamedataDistrict> Type { get; set; }
		[Ordinal(2)]  [RED("selected")] public CBool Selected { get; set; }
		[Ordinal(3)]  [RED("outlineWidget")] public inkLinePatternWidgetReference OutlineWidget { get; set; }
		[Ordinal(4)]  [RED("iconWidget")] public inkImageWidgetReference IconWidget { get; set; }
		[Ordinal(5)]  [RED("selectAnim")] public CHandle<inkanimProxy> SelectAnim { get; set; }

		public gameuiWorldMapDistrictLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
