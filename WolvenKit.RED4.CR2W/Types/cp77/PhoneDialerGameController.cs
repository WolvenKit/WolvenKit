using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhoneDialerGameController : gameuiHUDGameController
	{
		private inkWidgetReference _contactsList;
		private inkImageWidgetReference _avatarImage;
		private inkWidgetReference _hintMessenger;
		private inkScrollAreaWidgetReference _scrollArea;
		private inkWidgetReference _scrollControllerWidget;
		private CHandle<gameJournalManager> _journalManager;
		private wCHandle<PhoneSystem> _phoneSystem;
		private CBool _active;
		private wCHandle<inkVirtualListController> _listController;
		private CHandle<inkScriptableDataSourceWrapper> _dataSource;
		private CHandle<DialerContactDataView> _dataView;
		private CHandle<DialerContactTemplateClassifier> _templateClassifier;
		private wCHandle<inkScrollController> _scrollController;
		private CName _soundName;
		private CName _audioPhoneNavigation;
		private wCHandle<gameIBlackboard> _phoneBlackboard;
		private CHandle<UI_ComDeviceDef> _phoneBBDefinition;
		private CUInt32 _contactOpensBBID;
		private CHandle<inkanimProxy> _switchAnimProxy;
		private CHandle<inkanimProxy> _transitionAnimProxy;

		[Ordinal(9)] 
		[RED("contactsList")] 
		public inkWidgetReference ContactsList
		{
			get
			{
				if (_contactsList == null)
				{
					_contactsList = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "contactsList", cr2w, this);
				}
				return _contactsList;
			}
			set
			{
				if (_contactsList == value)
				{
					return;
				}
				_contactsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("avatarImage")] 
		public inkImageWidgetReference AvatarImage
		{
			get
			{
				if (_avatarImage == null)
				{
					_avatarImage = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "avatarImage", cr2w, this);
				}
				return _avatarImage;
			}
			set
			{
				if (_avatarImage == value)
				{
					return;
				}
				_avatarImage = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("hintMessenger")] 
		public inkWidgetReference HintMessenger
		{
			get
			{
				if (_hintMessenger == null)
				{
					_hintMessenger = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "hintMessenger", cr2w, this);
				}
				return _hintMessenger;
			}
			set
			{
				if (_hintMessenger == value)
				{
					return;
				}
				_hintMessenger = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("scrollArea")] 
		public inkScrollAreaWidgetReference ScrollArea
		{
			get
			{
				if (_scrollArea == null)
				{
					_scrollArea = (inkScrollAreaWidgetReference) CR2WTypeManager.Create("inkScrollAreaWidgetReference", "scrollArea", cr2w, this);
				}
				return _scrollArea;
			}
			set
			{
				if (_scrollArea == value)
				{
					return;
				}
				_scrollArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("scrollControllerWidget")] 
		public inkWidgetReference ScrollControllerWidget
		{
			get
			{
				if (_scrollControllerWidget == null)
				{
					_scrollControllerWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "scrollControllerWidget", cr2w, this);
				}
				return _scrollControllerWidget;
			}
			set
			{
				if (_scrollControllerWidget == value)
				{
					return;
				}
				_scrollControllerWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("journalManager")] 
		public CHandle<gameJournalManager> JournalManager
		{
			get
			{
				if (_journalManager == null)
				{
					_journalManager = (CHandle<gameJournalManager>) CR2WTypeManager.Create("handle:gameJournalManager", "journalManager", cr2w, this);
				}
				return _journalManager;
			}
			set
			{
				if (_journalManager == value)
				{
					return;
				}
				_journalManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("phoneSystem")] 
		public wCHandle<PhoneSystem> PhoneSystem
		{
			get
			{
				if (_phoneSystem == null)
				{
					_phoneSystem = (wCHandle<PhoneSystem>) CR2WTypeManager.Create("whandle:PhoneSystem", "phoneSystem", cr2w, this);
				}
				return _phoneSystem;
			}
			set
			{
				if (_phoneSystem == value)
				{
					return;
				}
				_phoneSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("active")] 
		public CBool Active
		{
			get
			{
				if (_active == null)
				{
					_active = (CBool) CR2WTypeManager.Create("Bool", "active", cr2w, this);
				}
				return _active;
			}
			set
			{
				if (_active == value)
				{
					return;
				}
				_active = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("listController")] 
		public wCHandle<inkVirtualListController> ListController
		{
			get
			{
				if (_listController == null)
				{
					_listController = (wCHandle<inkVirtualListController>) CR2WTypeManager.Create("whandle:inkVirtualListController", "listController", cr2w, this);
				}
				return _listController;
			}
			set
			{
				if (_listController == value)
				{
					return;
				}
				_listController = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("dataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> DataSource
		{
			get
			{
				if (_dataSource == null)
				{
					_dataSource = (CHandle<inkScriptableDataSourceWrapper>) CR2WTypeManager.Create("handle:inkScriptableDataSourceWrapper", "dataSource", cr2w, this);
				}
				return _dataSource;
			}
			set
			{
				if (_dataSource == value)
				{
					return;
				}
				_dataSource = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("dataView")] 
		public CHandle<DialerContactDataView> DataView
		{
			get
			{
				if (_dataView == null)
				{
					_dataView = (CHandle<DialerContactDataView>) CR2WTypeManager.Create("handle:DialerContactDataView", "dataView", cr2w, this);
				}
				return _dataView;
			}
			set
			{
				if (_dataView == value)
				{
					return;
				}
				_dataView = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("templateClassifier")] 
		public CHandle<DialerContactTemplateClassifier> TemplateClassifier
		{
			get
			{
				if (_templateClassifier == null)
				{
					_templateClassifier = (CHandle<DialerContactTemplateClassifier>) CR2WTypeManager.Create("handle:DialerContactTemplateClassifier", "templateClassifier", cr2w, this);
				}
				return _templateClassifier;
			}
			set
			{
				if (_templateClassifier == value)
				{
					return;
				}
				_templateClassifier = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("scrollController")] 
		public wCHandle<inkScrollController> ScrollController
		{
			get
			{
				if (_scrollController == null)
				{
					_scrollController = (wCHandle<inkScrollController>) CR2WTypeManager.Create("whandle:inkScrollController", "scrollController", cr2w, this);
				}
				return _scrollController;
			}
			set
			{
				if (_scrollController == value)
				{
					return;
				}
				_scrollController = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("soundName")] 
		public CName SoundName
		{
			get
			{
				if (_soundName == null)
				{
					_soundName = (CName) CR2WTypeManager.Create("CName", "soundName", cr2w, this);
				}
				return _soundName;
			}
			set
			{
				if (_soundName == value)
				{
					return;
				}
				_soundName = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("audioPhoneNavigation")] 
		public CName AudioPhoneNavigation
		{
			get
			{
				if (_audioPhoneNavigation == null)
				{
					_audioPhoneNavigation = (CName) CR2WTypeManager.Create("CName", "audioPhoneNavigation", cr2w, this);
				}
				return _audioPhoneNavigation;
			}
			set
			{
				if (_audioPhoneNavigation == value)
				{
					return;
				}
				_audioPhoneNavigation = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("phoneBlackboard")] 
		public wCHandle<gameIBlackboard> PhoneBlackboard
		{
			get
			{
				if (_phoneBlackboard == null)
				{
					_phoneBlackboard = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "phoneBlackboard", cr2w, this);
				}
				return _phoneBlackboard;
			}
			set
			{
				if (_phoneBlackboard == value)
				{
					return;
				}
				_phoneBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("phoneBBDefinition")] 
		public CHandle<UI_ComDeviceDef> PhoneBBDefinition
		{
			get
			{
				if (_phoneBBDefinition == null)
				{
					_phoneBBDefinition = (CHandle<UI_ComDeviceDef>) CR2WTypeManager.Create("handle:UI_ComDeviceDef", "phoneBBDefinition", cr2w, this);
				}
				return _phoneBBDefinition;
			}
			set
			{
				if (_phoneBBDefinition == value)
				{
					return;
				}
				_phoneBBDefinition = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("contactOpensBBID")] 
		public CUInt32 ContactOpensBBID
		{
			get
			{
				if (_contactOpensBBID == null)
				{
					_contactOpensBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "contactOpensBBID", cr2w, this);
				}
				return _contactOpensBBID;
			}
			set
			{
				if (_contactOpensBBID == value)
				{
					return;
				}
				_contactOpensBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("switchAnimProxy")] 
		public CHandle<inkanimProxy> SwitchAnimProxy
		{
			get
			{
				if (_switchAnimProxy == null)
				{
					_switchAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "switchAnimProxy", cr2w, this);
				}
				return _switchAnimProxy;
			}
			set
			{
				if (_switchAnimProxy == value)
				{
					return;
				}
				_switchAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("transitionAnimProxy")] 
		public CHandle<inkanimProxy> TransitionAnimProxy
		{
			get
			{
				if (_transitionAnimProxy == null)
				{
					_transitionAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "transitionAnimProxy", cr2w, this);
				}
				return _transitionAnimProxy;
			}
			set
			{
				if (_transitionAnimProxy == value)
				{
					return;
				}
				_transitionAnimProxy = value;
				PropertySet(this);
			}
		}

		public PhoneDialerGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
