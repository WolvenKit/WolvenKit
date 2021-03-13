using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiRandomNewsFeedAnimator : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("textWidget")] public inkTextWidgetReference TextWidget { get; set; }
		[Ordinal(2)] [RED("animDuration")] public CFloat AnimDuration { get; set; }

		public gameuiRandomNewsFeedAnimator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
