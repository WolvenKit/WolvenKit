using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questRadioStationAnnouncementEventStruct : CVariable
	{
		private raRef<scnSceneResource> _announcementScene;
		private CName _sceneInput;
		private CBool _queueAnnouncement;
		private CName _radioStationName;
		private CBool _blockSignal;
		private CEnum<audioRadioSpeakerType> _speaker;

		[Ordinal(0)] 
		[RED("announcementScene")] 
		public raRef<scnSceneResource> AnnouncementScene
		{
			get
			{
				if (_announcementScene == null)
				{
					_announcementScene = (raRef<scnSceneResource>) CR2WTypeManager.Create("raRef:scnSceneResource", "announcementScene", cr2w, this);
				}
				return _announcementScene;
			}
			set
			{
				if (_announcementScene == value)
				{
					return;
				}
				_announcementScene = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("sceneInput")] 
		public CName SceneInput
		{
			get
			{
				if (_sceneInput == null)
				{
					_sceneInput = (CName) CR2WTypeManager.Create("CName", "sceneInput", cr2w, this);
				}
				return _sceneInput;
			}
			set
			{
				if (_sceneInput == value)
				{
					return;
				}
				_sceneInput = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("queueAnnouncement")] 
		public CBool QueueAnnouncement
		{
			get
			{
				if (_queueAnnouncement == null)
				{
					_queueAnnouncement = (CBool) CR2WTypeManager.Create("Bool", "queueAnnouncement", cr2w, this);
				}
				return _queueAnnouncement;
			}
			set
			{
				if (_queueAnnouncement == value)
				{
					return;
				}
				_queueAnnouncement = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("radioStationName")] 
		public CName RadioStationName
		{
			get
			{
				if (_radioStationName == null)
				{
					_radioStationName = (CName) CR2WTypeManager.Create("CName", "radioStationName", cr2w, this);
				}
				return _radioStationName;
			}
			set
			{
				if (_radioStationName == value)
				{
					return;
				}
				_radioStationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("blockSignal")] 
		public CBool BlockSignal
		{
			get
			{
				if (_blockSignal == null)
				{
					_blockSignal = (CBool) CR2WTypeManager.Create("Bool", "blockSignal", cr2w, this);
				}
				return _blockSignal;
			}
			set
			{
				if (_blockSignal == value)
				{
					return;
				}
				_blockSignal = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("speaker")] 
		public CEnum<audioRadioSpeakerType> Speaker
		{
			get
			{
				if (_speaker == null)
				{
					_speaker = (CEnum<audioRadioSpeakerType>) CR2WTypeManager.Create("audioRadioSpeakerType", "speaker", cr2w, this);
				}
				return _speaker;
			}
			set
			{
				if (_speaker == value)
				{
					return;
				}
				_speaker = value;
				PropertySet(this);
			}
		}

		public questRadioStationAnnouncementEventStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
