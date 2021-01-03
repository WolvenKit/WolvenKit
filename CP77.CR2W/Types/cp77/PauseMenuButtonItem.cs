using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PauseMenuButtonItem : AnimatedListItemController
	{
		[Ordinal(0)]  [RED("Fluff")] public inkTextWidgetReference Fluff { get; set; }
		[Ordinal(1)]  [RED("animLoop")] public CHandle<inkanimProxy> AnimLoop { get; set; }

		public PauseMenuButtonItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
