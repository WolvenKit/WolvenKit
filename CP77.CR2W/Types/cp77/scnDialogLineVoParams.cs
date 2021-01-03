using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnDialogLineVoParams : CVariable
	{
		[Ordinal(0)]  [RED("alwaysUseBrainGender")] public CBool AlwaysUseBrainGender { get; set; }
		[Ordinal(1)]  [RED("customVoEvent")] public CName CustomVoEvent { get; set; }
		[Ordinal(2)]  [RED("disableHeadMovement")] public CBool DisableHeadMovement { get; set; }
		[Ordinal(3)]  [RED("ignoreSpeakerIncapacitation")] public CBool IgnoreSpeakerIncapacitation { get; set; }
		[Ordinal(4)]  [RED("isHolocallSpeaker")] public CBool IsHolocallSpeaker { get; set; }
		[Ordinal(5)]  [RED("voContext")] public CEnum<locVoiceoverContext> VoContext { get; set; }
		[Ordinal(6)]  [RED("voExpression")] public CEnum<locVoiceoverExpression> VoExpression { get; set; }

		public scnDialogLineVoParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
