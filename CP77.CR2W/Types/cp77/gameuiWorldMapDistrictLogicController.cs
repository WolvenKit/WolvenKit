using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiWorldMapDistrictLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("iconWidget")] public inkImageWidgetReference IconWidget { get; set; }
		[Ordinal(1)]  [RED("outlineWidget")] public inkLinePatternWidgetReference OutlineWidget { get; set; }
		[Ordinal(2)]  [RED("record")] public wCHandle<gamedataDistrict_Record> Record { get; set; }
		[Ordinal(3)]  [RED("selectAnim")] public CHandle<inkanimProxy> SelectAnim { get; set; }
		[Ordinal(4)]  [RED("selected")] public CBool Selected { get; set; }
		[Ordinal(5)]  [RED("type")] public CEnum<gamedataDistrict> Type { get; set; }

		public gameuiWorldMapDistrictLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
