using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioAudioScenesMap : audioAudioMetadata
	{
		[Ordinal(1)] [RED("defaultScene")] public CName DefaultScene { get; set; }
		[Ordinal(2)] [RED("scenesToActivateByQuestEvent")] public CHandle<audioAudioSceneDictionary> ScenesToActivateByQuestEvent { get; set; }

		public audioAudioScenesMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
