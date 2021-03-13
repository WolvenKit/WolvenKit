using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnAudioEvent : scnSceneEvent
	{
		[Ordinal(6)] [RED("performer")] public scnPerformerId Performer { get; set; }
		[Ordinal(7)] [RED("audioEventName")] public CName AudioEventName { get; set; }
		[Ordinal(8)] [RED("ambientUniqueName")] public CName AmbientUniqueName { get; set; }
		[Ordinal(9)] [RED("emitterName")] public CName EmitterName { get; set; }
		[Ordinal(10)] [RED("fastForwardSupport")] public CEnum<scnAudioFastForwardSupport> FastForwardSupport { get; set; }

		public scnAudioEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
