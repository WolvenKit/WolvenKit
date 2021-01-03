using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class BackpackFilterButtonController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("active")] public CBool Active { get; set; }
		[Ordinal(1)]  [RED("filterType")] public CEnum<ItemFilterCategory> FilterType { get; set; }
		[Ordinal(2)]  [RED("hovered")] public CBool Hovered { get; set; }
		[Ordinal(3)]  [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(4)]  [RED("text")] public inkTextWidgetReference Text { get; set; }

		public BackpackFilterButtonController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
