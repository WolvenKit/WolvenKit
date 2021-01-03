using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiMinimapDynamicEventMappinController : gameuiBaseMinimapMappinController
	{
		[Ordinal(0)]  [RED("hideAtDistance")] public CFloat HideAtDistance { get; set; }
		[Ordinal(1)]  [RED("hideInCombat")] public CBool HideInCombat { get; set; }
		[Ordinal(2)]  [RED("pulseAnim")] public CHandle<inkanimProxy> PulseAnim { get; set; }
		[Ordinal(3)]  [RED("pulseEnabled")] public CBool PulseEnabled { get; set; }
		[Ordinal(4)]  [RED("pulseWidget")] public inkWidgetReference PulseWidget { get; set; }

		public gameuiMinimapDynamicEventMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
