using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkButtonAnimatedController : inkButtonController
	{
		[Ordinal(0)]  [RED("animTargetHover")] public inkWidgetReference AnimTargetHover { get; set; }
		[Ordinal(1)]  [RED("animTargetPulse")] public inkWidgetReference AnimTargetPulse { get; set; }
		[Ordinal(2)]  [RED("normalRootOpacity")] public CFloat NormalRootOpacity { get; set; }
		[Ordinal(3)]  [RED("hoverRootOpacity")] public CFloat HoverRootOpacity { get; set; }
		[Ordinal(4)]  [RED("rootWidget")] public wCHandle<inkCompoundWidget> RootWidget { get; set; }
		[Ordinal(5)]  [RED("animTarget_Hover")] public wCHandle<inkWidget> AnimTarget_Hover { get; set; }
		[Ordinal(6)]  [RED("animTarget_Pulse")] public wCHandle<inkWidget> AnimTarget_Pulse { get; set; }
		[Ordinal(7)]  [RED("animHover")] public CHandle<inkanimDefinition> AnimHover { get; set; }
		[Ordinal(8)]  [RED("animPulse")] public CHandle<inkanimDefinition> AnimPulse { get; set; }
		[Ordinal(9)]  [RED("animHoverProxy")] public CHandle<inkanimProxy> AnimHoverProxy { get; set; }
		[Ordinal(10)]  [RED("animPulseProxy")] public CHandle<inkanimProxy> AnimPulseProxy { get; set; }
		[Ordinal(11)]  [RED("animPulseOptions")] public inkanimPlaybackOptions AnimPulseOptions { get; set; }

		public inkButtonAnimatedController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
