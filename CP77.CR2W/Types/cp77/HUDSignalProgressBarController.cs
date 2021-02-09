using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HUDSignalProgressBarController : gameuiHUDGameController
	{
		[Ordinal(7)]  [RED("bar")] public inkWidgetReference Bar { get; set; }
		[Ordinal(8)]  [RED("completed")] public inkWidgetReference Completed { get; set; }
		[Ordinal(9)]  [RED("signalLost")] public inkWidgetReference SignalLost { get; set; }
		[Ordinal(10)]  [RED("percent")] public inkTextWidgetReference Percent { get; set; }
		[Ordinal(11)]  [RED("signalBars")] public CArray<inkWidgetReference> SignalBars { get; set; }
		[Ordinal(12)]  [RED("rootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(13)]  [RED("progressBarBB")] public CHandle<gameIBlackboard> ProgressBarBB { get; set; }
		[Ordinal(14)]  [RED("progressBarDef")] public CHandle<UI_HUDSignalProgressBarDef> ProgressBarDef { get; set; }
		[Ordinal(15)]  [RED("stateBBID")] public CUInt32 StateBBID { get; set; }
		[Ordinal(16)]  [RED("progressBBID")] public CUInt32 ProgressBBID { get; set; }
		[Ordinal(17)]  [RED("signalStrengthBBID")] public CUInt32 SignalStrengthBBID { get; set; }
		[Ordinal(18)]  [RED("data")] public HUDProgressBarData Data { get; set; }
		[Ordinal(19)]  [RED("OutroAnimation")] public CHandle<inkanimProxy> OutroAnimation { get; set; }
		[Ordinal(20)]  [RED("SignalLostAnimation")] public CHandle<inkanimProxy> SignalLostAnimation { get; set; }
		[Ordinal(21)]  [RED("IntroAnimation")] public CHandle<inkanimProxy> IntroAnimation { get; set; }
		[Ordinal(22)]  [RED("alpha_fadein")] public CHandle<inkanimDefinition> Alpha_fadein { get; set; }
		[Ordinal(23)]  [RED("AnimProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(24)]  [RED("AnimOptions")] public inkanimPlaybackOptions AnimOptions { get; set; }
		[Ordinal(25)]  [RED("alphaInterpolator")] public CHandle<inkanimTransparencyInterpolator> AlphaInterpolator { get; set; }
		[Ordinal(26)]  [RED("tick")] public CFloat Tick { get; set; }

		public HUDSignalProgressBarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
