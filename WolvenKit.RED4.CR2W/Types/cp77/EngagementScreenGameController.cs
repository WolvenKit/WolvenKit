using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EngagementScreenGameController : gameuiMenuGameController
	{
		[Ordinal(3)] [RED("backgroundVideo")] public inkVideoWidgetReference BackgroundVideo { get; set; }
		[Ordinal(4)] [RED("text")] public inkRichTextBoxWidgetReference Text { get; set; }
		[Ordinal(5)] [RED("textShadow")] public inkRichTextBoxWidgetReference TextShadow { get; set; }
		[Ordinal(6)] [RED("textContainer")] public inkCompoundWidgetReference TextContainer { get; set; }
		[Ordinal(7)] [RED("menuEventDispatcher")] public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher { get; set; }

		public EngagementScreenGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
