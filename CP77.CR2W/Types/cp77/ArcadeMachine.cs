using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ArcadeMachine : InteractiveDevice
	{
		[Ordinal(93)] [RED("isShortGlitchActive")] public CBool IsShortGlitchActive { get; set; }
		[Ordinal(94)] [RED("shortGlitchDelayID")] public gameDelayID ShortGlitchDelayID { get; set; }
		[Ordinal(95)] [RED("currentGame")] public redResourceReferenceScriptToken CurrentGame { get; set; }
		[Ordinal(96)] [RED("currentGameAudio")] public CName CurrentGameAudio { get; set; }
		[Ordinal(97)] [RED("currentGameAudioStop")] public CName CurrentGameAudioStop { get; set; }

		public ArcadeMachine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
