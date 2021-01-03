using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkButtonAnimatedController : inkButtonController
	{
		[Ordinal(0)]  [RED("animHover")] public CHandle<inkanimDefinition> AnimHover { get; set; }
		[Ordinal(1)]  [RED("animHoverProxy")] public CHandle<inkanimProxy> AnimHoverProxy { get; set; }
		[Ordinal(2)]  [RED("animPulse")] public CHandle<inkanimDefinition> AnimPulse { get; set; }
		[Ordinal(3)]  [RED("animPulseOptions")] public inkanimPlaybackOptions AnimPulseOptions { get; set; }
		[Ordinal(4)]  [RED("animPulseProxy")] public CHandle<inkanimProxy> AnimPulseProxy { get; set; }
		[Ordinal(5)]  [RED("animTargetHover")] public inkWidgetReference AnimTargetHover { get; set; }
		[Ordinal(6)]  [RED("animTargetPulse")] public inkWidgetReference AnimTargetPulse { get; set; }
		[Ordinal(7)]  [RED("animTarget_Hover")] public wCHandle<inkWidget> AnimTarget_Hover { get; set; }
		[Ordinal(8)]  [RED("animTarget_Pulse")] public wCHandle<inkWidget> AnimTarget_Pulse { get; set; }
		[Ordinal(9)]  [RED("hoverRootOpacity")] public CFloat HoverRootOpacity { get; set; }
		[Ordinal(10)]  [RED("normalRootOpacity")] public CFloat NormalRootOpacity { get; set; }
		[Ordinal(11)]  [RED("rootWidget")] public wCHandle<inkCompoundWidget> RootWidget { get; set; }

		public inkButtonAnimatedController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
