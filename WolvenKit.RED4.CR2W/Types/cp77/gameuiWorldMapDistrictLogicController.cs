using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiWorldMapDistrictLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("record")] public wCHandle<gamedataDistrict_Record> Record { get; set; }
		[Ordinal(2)] [RED("type")] public CEnum<gamedataDistrict> Type { get; set; }
		[Ordinal(3)] [RED("selected")] public CBool Selected { get; set; }
		[Ordinal(4)] [RED("outlineWidget")] public inkLinePatternWidgetReference OutlineWidget { get; set; }
		[Ordinal(5)] [RED("iconWidget")] public inkImageWidgetReference IconWidget { get; set; }
		[Ordinal(6)] [RED("selectAnim")] public CHandle<inkanimProxy> SelectAnim { get; set; }

		public gameuiWorldMapDistrictLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
