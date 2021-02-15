using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimatedListItemController : inkListItemController
	{
		[Ordinal(16)] [RED("animOutName")] public CName AnimOutName { get; set; }
		[Ordinal(17)] [RED("animPulseName")] public CName AnimPulseName { get; set; }
		[Ordinal(18)] [RED("animTargetHover")] public inkWidgetReference AnimTargetHover { get; set; }
		[Ordinal(19)] [RED("animTargetPulse")] public inkWidgetReference AnimTargetPulse { get; set; }
		[Ordinal(20)] [RED("normalRootOpacity")] public CFloat NormalRootOpacity { get; set; }
		[Ordinal(21)] [RED("hoverRootOpacity")] public CFloat HoverRootOpacity { get; set; }
		[Ordinal(22)] [RED("rootWidget")] public wCHandle<inkCompoundWidget> RootWidget { get; set; }
		[Ordinal(23)] [RED("animTarget_Hover")] public wCHandle<inkWidget> AnimTarget_Hover { get; set; }
		[Ordinal(24)] [RED("animTarget_Pulse")] public wCHandle<inkWidget> AnimTarget_Pulse { get; set; }
		[Ordinal(25)] [RED("animHover")] public CHandle<inkanimDefinition> AnimHover { get; set; }
		[Ordinal(26)] [RED("animPulse")] public CHandle<inkanimDefinition> AnimPulse { get; set; }
		[Ordinal(27)] [RED("animHoverProxy")] public CHandle<inkanimProxy> AnimHoverProxy { get; set; }
		[Ordinal(28)] [RED("animPulseProxy")] public CHandle<inkanimProxy> AnimPulseProxy { get; set; }
		[Ordinal(29)] [RED("animPulseOptions")] public inkanimPlaybackOptions AnimPulseOptions { get; set; }

		public AnimatedListItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
