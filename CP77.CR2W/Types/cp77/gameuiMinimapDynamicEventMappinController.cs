using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiMinimapDynamicEventMappinController : gameuiBaseMinimapMappinController
	{
		[Ordinal(0)]  [RED("pulseEnabled")] public CBool PulseEnabled { get; set; }
		[Ordinal(1)]  [RED("pulseWidget")] public inkWidgetReference PulseWidget { get; set; }
		[Ordinal(2)]  [RED("hideAtDistance")] public CFloat HideAtDistance { get; set; }
		[Ordinal(3)]  [RED("hideInCombat")] public CBool HideInCombat { get; set; }

		public gameuiMinimapDynamicEventMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
