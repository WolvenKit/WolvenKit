using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class StarController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("bountyBadgeWidget")] public inkWidgetReference BountyBadgeWidget { get; set; }

		public StarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
