using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MessagePopupDisplayController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("image")] public inkImageWidgetReference Image { get; set; }
		[Ordinal(1)]  [RED("message")] public inkTextWidgetReference Message { get; set; }
		[Ordinal(2)]  [RED("title")] public inkTextWidgetReference Title { get; set; }

		public MessagePopupDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
