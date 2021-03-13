using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkButtonAnimatedController : inkButtonController
	{
		[Ordinal(10)] [RED("animTargetHover")] public inkWidgetReference AnimTargetHover { get; set; }
		[Ordinal(11)] [RED("animTargetPulse")] public inkWidgetReference AnimTargetPulse { get; set; }
		[Ordinal(12)] [RED("normalRootOpacity")] public CFloat NormalRootOpacity { get; set; }
		[Ordinal(13)] [RED("hoverRootOpacity")] public CFloat HoverRootOpacity { get; set; }
		[Ordinal(14)] [RED("rootWidget")] public wCHandle<inkCompoundWidget> RootWidget { get; set; }
		[Ordinal(15)] [RED("animTarget_Hover")] public wCHandle<inkWidget> AnimTarget_Hover { get; set; }
		[Ordinal(16)] [RED("animTarget_Pulse")] public wCHandle<inkWidget> AnimTarget_Pulse { get; set; }
		[Ordinal(17)] [RED("animHover")] public CHandle<inkanimDefinition> AnimHover { get; set; }
		[Ordinal(18)] [RED("animPulse")] public CHandle<inkanimDefinition> AnimPulse { get; set; }
		[Ordinal(19)] [RED("animHoverProxy")] public CHandle<inkanimProxy> AnimHoverProxy { get; set; }
		[Ordinal(20)] [RED("animPulseProxy")] public CHandle<inkanimProxy> AnimPulseProxy { get; set; }
		[Ordinal(21)] [RED("animPulseOptions")] public inkanimPlaybackOptions AnimPulseOptions { get; set; }

		public inkButtonAnimatedController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
