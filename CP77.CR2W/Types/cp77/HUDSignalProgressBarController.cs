using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HUDSignalProgressBarController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("bar")] public inkWidgetReference Bar { get; set; }
		[Ordinal(10)] [RED("completed")] public inkWidgetReference Completed { get; set; }
		[Ordinal(11)] [RED("signalLost")] public inkWidgetReference SignalLost { get; set; }
		[Ordinal(12)] [RED("percent")] public inkTextWidgetReference Percent { get; set; }
		[Ordinal(13)] [RED("signalBars")] public CArray<inkWidgetReference> SignalBars { get; set; }
		[Ordinal(14)] [RED("rootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(15)] [RED("progressBarBB")] public CHandle<gameIBlackboard> ProgressBarBB { get; set; }
		[Ordinal(16)] [RED("progressBarDef")] public CHandle<UI_HUDSignalProgressBarDef> ProgressBarDef { get; set; }
		[Ordinal(17)] [RED("stateBBID")] public CUInt32 StateBBID { get; set; }
		[Ordinal(18)] [RED("progressBBID")] public CUInt32 ProgressBBID { get; set; }
		[Ordinal(19)] [RED("signalStrengthBBID")] public CUInt32 SignalStrengthBBID { get; set; }
		[Ordinal(20)] [RED("data")] public HUDProgressBarData Data { get; set; }
		[Ordinal(21)] [RED("OutroAnimation")] public CHandle<inkanimProxy> OutroAnimation { get; set; }
		[Ordinal(22)] [RED("SignalLostAnimation")] public CHandle<inkanimProxy> SignalLostAnimation { get; set; }
		[Ordinal(23)] [RED("IntroAnimation")] public CHandle<inkanimProxy> IntroAnimation { get; set; }
		[Ordinal(24)] [RED("alpha_fadein")] public CHandle<inkanimDefinition> Alpha_fadein { get; set; }
		[Ordinal(25)] [RED("AnimProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(26)] [RED("AnimOptions")] public inkanimPlaybackOptions AnimOptions { get; set; }
		[Ordinal(27)] [RED("alphaInterpolator")] public CHandle<inkanimTransparencyInterpolator> AlphaInterpolator { get; set; }
		[Ordinal(28)] [RED("tick")] public CFloat Tick { get; set; }

		public HUDSignalProgressBarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
