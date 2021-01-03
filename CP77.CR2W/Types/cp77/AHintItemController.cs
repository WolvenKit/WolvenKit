using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AHintItemController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("Icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(1)]  [RED("Root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(2)]  [RED("UnavaliableText")] public inkTextWidgetReference UnavaliableText { get; set; }

		public AHintItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
