using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkVideoSequenceEntry : CVariable
	{
		[Ordinal(0)]  [RED("audioEvent")] public CName AudioEvent { get; set; }
		[Ordinal(1)]  [RED("loop")] public CBool Loop { get; set; }
		[Ordinal(2)]  [RED("retriggerAudioOnLoop")] public CBool RetriggerAudioOnLoop { get; set; }
		[Ordinal(3)]  [RED("syncToAudio")] public CBool SyncToAudio { get; set; }
		[Ordinal(4)]  [RED("videoResource")] public raRef<Bink> VideoResource { get; set; }

		public inkVideoSequenceEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
