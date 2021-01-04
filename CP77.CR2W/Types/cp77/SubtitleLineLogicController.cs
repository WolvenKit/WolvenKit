using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SubtitleLineLogicController : BaseSubtitleLineLogicController
	{
		[Ordinal(0)]  [RED("background")] public inkWidgetReference Background { get; set; }
		[Ordinal(1)]  [RED("backgroundSpeaker")] public inkWidgetReference BackgroundSpeaker { get; set; }
		[Ordinal(2)]  [RED("kiroshiAnimationContainer")] public inkWidgetReference KiroshiAnimationContainer { get; set; }
		[Ordinal(3)]  [RED("lineData")] public scnDialogLineData LineData { get; set; }
		[Ordinal(4)]  [RED("motherTongueContainter")] public inkWidgetReference MotherTongueContainter { get; set; }
		[Ordinal(5)]  [RED("radioSpeaker")] public inkTextWidgetReference RadioSpeaker { get; set; }
		[Ordinal(6)]  [RED("radioSubtitle")] public inkTextWidgetReference RadioSubtitle { get; set; }
		[Ordinal(7)]  [RED("speakerNameWidget")] public inkTextWidgetReference SpeakerNameWidget { get; set; }
		[Ordinal(8)]  [RED("subtitleWidget")] public inkTextWidgetReference SubtitleWidget { get; set; }
		[Ordinal(9)]  [RED("targetTextWidgetRef")] public inkTextWidgetReference TargetTextWidgetRef { get; set; }

		public SubtitleLineLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
