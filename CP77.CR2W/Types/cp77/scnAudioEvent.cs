using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnAudioEvent : scnSceneEvent
	{
		[Ordinal(0)]  [RED("ambientUniqueName")] public CName AmbientUniqueName { get; set; }
		[Ordinal(1)]  [RED("audioEventName")] public CName AudioEventName { get; set; }
		[Ordinal(2)]  [RED("emitterName")] public CName EmitterName { get; set; }
		[Ordinal(3)]  [RED("fastForwardSupport")] public CEnum<scnAudioFastForwardSupport> FastForwardSupport { get; set; }
		[Ordinal(4)]  [RED("performer")] public scnPerformerId Performer { get; set; }

		public scnAudioEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
