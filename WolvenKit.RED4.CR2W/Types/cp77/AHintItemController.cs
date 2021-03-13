using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AHintItemController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("Icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(2)] [RED("UnavaliableText")] public inkTextWidgetReference UnavaliableText { get; set; }
		[Ordinal(3)] [RED("Root")] public wCHandle<inkWidget> Root { get; set; }

		public AHintItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
