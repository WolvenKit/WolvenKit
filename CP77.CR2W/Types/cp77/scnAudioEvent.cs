using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnAudioEvent : scnSceneEvent
	{
		[Ordinal(0)]  [RED("performer")] public scnPerformerId Performer { get; set; }
		[Ordinal(1)]  [RED("audioEventName")] public CName AudioEventName { get; set; }
		[Ordinal(2)]  [RED("ambientUniqueName")] public CName AmbientUniqueName { get; set; }
		[Ordinal(3)]  [RED("emitterName")] public CName EmitterName { get; set; }
		[Ordinal(4)]  [RED("fastForwardSupport")] public CEnum<scnAudioFastForwardSupport> FastForwardSupport { get; set; }

		public scnAudioEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
