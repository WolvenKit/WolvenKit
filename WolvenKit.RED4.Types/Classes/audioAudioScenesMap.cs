using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAudioScenesMap : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("defaultScene")] 
		public CName DefaultScene
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("scenesToActivateByQuestEvent")] 
		public CHandle<audioAudioSceneDictionary> ScenesToActivateByQuestEvent
		{
			get => GetPropertyValue<CHandle<audioAudioSceneDictionary>>();
			set => SetPropertyValue<CHandle<audioAudioSceneDictionary>>(value);
		}

		public audioAudioScenesMap()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
