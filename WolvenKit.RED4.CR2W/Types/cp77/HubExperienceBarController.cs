using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HubExperienceBarController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("foregroundContainer")] public inkWidgetReference ForegroundContainer { get; set; }

		public HubExperienceBarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
