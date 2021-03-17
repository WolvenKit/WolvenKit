using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudioScenesMap : audioAudioMetadata
	{
		private CName _defaultScene;
		private CHandle<audioAudioSceneDictionary> _scenesToActivateByQuestEvent;

		[Ordinal(1)] 
		[RED("defaultScene")] 
		public CName DefaultScene
		{
			get => GetProperty(ref _defaultScene);
			set => SetProperty(ref _defaultScene, value);
		}

		[Ordinal(2)] 
		[RED("scenesToActivateByQuestEvent")] 
		public CHandle<audioAudioSceneDictionary> ScenesToActivateByQuestEvent
		{
			get => GetProperty(ref _scenesToActivateByQuestEvent);
			set => SetProperty(ref _scenesToActivateByQuestEvent, value);
		}

		public audioAudioScenesMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
