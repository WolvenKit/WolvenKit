using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkVideoSequenceEntry : CVariable
	{
		[Ordinal(0)] [RED("videoResource")] public raRef<Bink> VideoResource { get; set; }
		[Ordinal(1)] [RED("audioEvent")] public CName AudioEvent { get; set; }
		[Ordinal(2)] [RED("syncToAudio")] public CBool SyncToAudio { get; set; }
		[Ordinal(3)] [RED("retriggerAudioOnLoop")] public CBool RetriggerAudioOnLoop { get; set; }
		[Ordinal(4)] [RED("loop")] public CBool Loop { get; set; }

		public inkVideoSequenceEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
