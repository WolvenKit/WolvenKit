using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiMinimapDynamicEventMappinController : gameuiBaseMinimapMappinController
	{
		[Ordinal(0)]  [RED("animPlayerTrackedWidget")] public inkWidgetReference AnimPlayerTrackedWidget { get; set; }
		[Ordinal(1)]  [RED("animPlayerAboveBelowWidget")] public inkWidgetReference AnimPlayerAboveBelowWidget { get; set; }
		[Ordinal(2)]  [RED("taggedWidgets")] public CArray<inkWidgetReference> TaggedWidgets { get; set; }
		[Ordinal(3)]  [RED("mappin")] public wCHandle<gamemappinsIMappin> Mappin { get; set; }
		[Ordinal(4)]  [RED("root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(5)]  [RED("aboveWidget")] public wCHandle<inkWidget> AboveWidget { get; set; }
		[Ordinal(6)]  [RED("belowWidget")] public wCHandle<inkWidget> BelowWidget { get; set; }
		[Ordinal(7)]  [RED("pulseEnabled")] public CBool PulseEnabled { get; set; }
		[Ordinal(8)]  [RED("pulseWidget")] public inkWidgetReference PulseWidget { get; set; }
		[Ordinal(9)]  [RED("hideAtDistance")] public CFloat HideAtDistance { get; set; }
		[Ordinal(10)]  [RED("hideInCombat")] public CBool HideInCombat { get; set; }
		[Ordinal(11)]  [RED("pulseAnim")] public CHandle<inkanimProxy> PulseAnim { get; set; }

		public gameuiMinimapDynamicEventMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
