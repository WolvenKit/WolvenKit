using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class EngagementScreenGameController : gameuiMenuGameController
	{
		[Ordinal(0)]  [RED("backgroundVideo")] public inkVideoWidgetReference BackgroundVideo { get; set; }
		[Ordinal(1)]  [RED("menuEventDispatcher")] public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher { get; set; }
		[Ordinal(2)]  [RED("text")] public inkRichTextBoxWidgetReference Text { get; set; }
		[Ordinal(3)]  [RED("textContainer")] public inkCompoundWidgetReference TextContainer { get; set; }
		[Ordinal(4)]  [RED("textShadow")] public inkRichTextBoxWidgetReference TextShadow { get; set; }

		public EngagementScreenGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
