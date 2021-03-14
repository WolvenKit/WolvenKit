using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnDialogLineEvent : scnSceneEvent
	{
		[Ordinal(6)] [RED("screenplayLineId")] public scnscreenplayItemId ScreenplayLineId { get; set; }
		[Ordinal(7)] [RED("voParams")] public scnDialogLineVoParams VoParams { get; set; }
		[Ordinal(8)] [RED("visualStyle")] public CEnum<scnDialogLineVisualStyle> VisualStyle { get; set; }
		[Ordinal(9)] [RED("additionalSpeakers")] public scnAdditionalSpeakers AdditionalSpeakers { get; set; }

		public scnDialogLineEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
