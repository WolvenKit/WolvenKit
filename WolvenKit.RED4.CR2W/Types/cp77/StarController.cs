using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StarController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("bountyBadgeWidget")] public inkWidgetReference BountyBadgeWidget { get; set; }

		public StarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
