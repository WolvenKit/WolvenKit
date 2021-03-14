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
			get
			{
				if (_defaultScene == null)
				{
					_defaultScene = (CName) CR2WTypeManager.Create("CName", "defaultScene", cr2w, this);
				}
				return _defaultScene;
			}
			set
			{
				if (_defaultScene == value)
				{
					return;
				}
				_defaultScene = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("scenesToActivateByQuestEvent")] 
		public CHandle<audioAudioSceneDictionary> ScenesToActivateByQuestEvent
		{
			get
			{
				if (_scenesToActivateByQuestEvent == null)
				{
					_scenesToActivateByQuestEvent = (CHandle<audioAudioSceneDictionary>) CR2WTypeManager.Create("handle:audioAudioSceneDictionary", "scenesToActivateByQuestEvent", cr2w, this);
				}
				return _scenesToActivateByQuestEvent;
			}
			set
			{
				if (_scenesToActivateByQuestEvent == value)
				{
					return;
				}
				_scenesToActivateByQuestEvent = value;
				PropertySet(this);
			}
		}

		public audioAudioScenesMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
