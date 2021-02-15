using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameaudioSoundComponent : gameaudioSoundComponentBase
	{
		[Ordinal(11)] [RED("subSystems")] public CArray<gameaudioSoundComponentSubSystemWrapper> SubSystems { get; set; }
		[Ordinal(12)] [RED("voEventOverride")] public CName VoEventOverride { get; set; }
		[Ordinal(13)] [RED("minVocalizationRepeatTime")] public CFloat MinVocalizationRepeatTime { get; set; }
		[Ordinal(14)] [RED("streamingDistance")] public CFloat StreamingDistance { get; set; }

		public gameaudioSoundComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
