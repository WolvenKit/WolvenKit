using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SubtitleLineLogicController : BaseSubtitleLineLogicController
	{
		[Ordinal(5)] [RED("speakerNameWidget")] public inkTextWidgetReference SpeakerNameWidget { get; set; }
		[Ordinal(6)] [RED("subtitleWidget")] public inkTextWidgetReference SubtitleWidget { get; set; }
		[Ordinal(7)] [RED("radioSpeaker")] public inkTextWidgetReference RadioSpeaker { get; set; }
		[Ordinal(8)] [RED("radioSubtitle")] public inkTextWidgetReference RadioSubtitle { get; set; }
		[Ordinal(9)] [RED("background")] public inkWidgetReference Background { get; set; }
		[Ordinal(10)] [RED("backgroundSpeaker")] public inkWidgetReference BackgroundSpeaker { get; set; }
		[Ordinal(11)] [RED("kiroshiAnimationContainer")] public inkWidgetReference KiroshiAnimationContainer { get; set; }
		[Ordinal(12)] [RED("motherTongueContainter")] public inkWidgetReference MotherTongueContainter { get; set; }
		[Ordinal(13)] [RED("targetTextWidgetRef")] public inkTextWidgetReference TargetTextWidgetRef { get; set; }
		[Ordinal(14)] [RED("lineData")] public scnDialogLineData LineData { get; set; }

		public SubtitleLineLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
