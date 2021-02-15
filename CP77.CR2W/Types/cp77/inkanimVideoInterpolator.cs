using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkanimVideoInterpolator : inkanimInterpolator
	{
		[Ordinal(7)] [RED("startValue")] public CFloat StartValue { get; set; }
		[Ordinal(8)] [RED("endValue")] public CFloat EndValue { get; set; }
		[Ordinal(9)] [RED("synchronizeToAudio")] public CBool SynchronizeToAudio { get; set; }
		[Ordinal(10)] [RED("allowSkipBackward")] public CBool AllowSkipBackward { get; set; }
		[Ordinal(11)] [RED("audioEvent")] public CName AudioEvent { get; set; }
		[Ordinal(12)] [RED("retriggerAudioOnLoop")] public CBool RetriggerAudioOnLoop { get; set; }

		public inkanimVideoInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
