using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SubtitleLineLogicController : BaseSubtitleLineLogicController
	{
		[Ordinal(0)]  [RED("root")] public CHandle<inkWidget> Root { get; set; }
		[Ordinal(1)]  [RED("isKiroshiEnabled")] public CBool IsKiroshiEnabled { get; set; }
		[Ordinal(2)]  [RED("c_tier1_duration")] public CFloat C_tier1_duration { get; set; }
		[Ordinal(3)]  [RED("c_tier2_duration")] public CFloat C_tier2_duration { get; set; }
		[Ordinal(4)]  [RED("speakerNameWidget")] public inkTextWidgetReference SpeakerNameWidget { get; set; }
		[Ordinal(5)]  [RED("subtitleWidget")] public inkTextWidgetReference SubtitleWidget { get; set; }
		[Ordinal(6)]  [RED("radioSpeaker")] public inkTextWidgetReference RadioSpeaker { get; set; }
		[Ordinal(7)]  [RED("radioSubtitle")] public inkTextWidgetReference RadioSubtitle { get; set; }
		[Ordinal(8)]  [RED("background")] public inkWidgetReference Background { get; set; }
		[Ordinal(9)]  [RED("backgroundSpeaker")] public inkWidgetReference BackgroundSpeaker { get; set; }
		[Ordinal(10)]  [RED("kiroshiAnimationContainer")] public inkWidgetReference KiroshiAnimationContainer { get; set; }
		[Ordinal(11)]  [RED("motherTongueContainter")] public inkWidgetReference MotherTongueContainter { get; set; }
		[Ordinal(12)]  [RED("targetTextWidgetRef")] public inkTextWidgetReference TargetTextWidgetRef { get; set; }
		[Ordinal(13)]  [RED("lineData")] public scnDialogLineData LineData { get; set; }

		public SubtitleLineLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
