using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class buffListItemLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(2)] [RED("label")] public inkTextWidgetReference Label { get; set; }

		public buffListItemLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
