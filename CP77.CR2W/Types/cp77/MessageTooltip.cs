using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MessageTooltip : AGenericTooltipController
	{
		[Ordinal(2)] [RED("Title")] public inkTextWidgetReference Title { get; set; }
		[Ordinal(3)] [RED("Description")] public inkTextWidgetReference Description { get; set; }
		[Ordinal(4)] [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }

		public MessageTooltip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
