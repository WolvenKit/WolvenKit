using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MessagePopupDisplayController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("title")] public inkTextWidgetReference Title { get; set; }
		[Ordinal(2)] [RED("message")] public inkTextWidgetReference Message { get; set; }
		[Ordinal(3)] [RED("image")] public inkImageWidgetReference Image { get; set; }

		public MessagePopupDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
