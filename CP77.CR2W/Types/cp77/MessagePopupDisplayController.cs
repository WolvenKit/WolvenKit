using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MessagePopupDisplayController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("title")] public inkTextWidgetReference Title { get; set; }
		[Ordinal(1)]  [RED("message")] public inkTextWidgetReference Message { get; set; }
		[Ordinal(2)]  [RED("image")] public inkImageWidgetReference Image { get; set; }

		public MessagePopupDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
