using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnDialogLineEvent : scnSceneEvent
	{
		[Ordinal(0)]  [RED("additionalSpeakers")] public scnAdditionalSpeakers AdditionalSpeakers { get; set; }
		[Ordinal(1)]  [RED("screenplayLineId")] public scnscreenplayItemId ScreenplayLineId { get; set; }
		[Ordinal(2)]  [RED("visualStyle")] public CEnum<scnDialogLineVisualStyle> VisualStyle { get; set; }
		[Ordinal(3)]  [RED("voParams")] public scnDialogLineVoParams VoParams { get; set; }

		public scnDialogLineEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
