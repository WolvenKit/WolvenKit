using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PauseMenuButtonItem : AnimatedListItemController
	{
		[Ordinal(30)] [RED("Fluff")] public inkTextWidgetReference Fluff { get; set; }
		[Ordinal(31)] [RED("animLoop")] public CHandle<inkanimProxy> AnimLoop { get; set; }

		public PauseMenuButtonItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
