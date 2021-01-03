using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioAudioScenesMap : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("defaultScene")] public CName DefaultScene { get; set; }
		[Ordinal(1)]  [RED("scenesToActivateByQuestEvent")] public CHandle<audioAudioSceneDictionary> ScenesToActivateByQuestEvent { get; set; }

		public audioAudioScenesMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
