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
		private CHandle<redCallbackObject> _contactOpensBBID;
		private CHandle<inkanimProxy> _switchAnimProxy;
		private CHandle<inkanimProxy> _transitionAnimProxy;
		private CBool _repeatingScrollActionEnabled;
		private CBool _firstInit;

		[Ordinal(9)] 
		[RED("contactsList")] 
		public inkWidgetReference ContactsList
		{
			get => GetProperty(ref _contactsList);
			set => SetProperty(ref _contactsList, value);
		}

		[Ordinal(10)] 
		[RED("avatarImage")] 
		public inkImageWidgetReference AvatarImage
		{
			get => GetProperty(ref _avatarImage);
			set => SetProperty(ref _avatarImage, value);
		}

		[Ordinal(11)] 
		[RED("hintMessenger")] 
		public inkWidgetReference HintMessenger
		{
			get => GetProperty(ref _hintMessenger);
			set => SetProperty(ref _hintMessenger, value);
		}

		[Ordinal(12)] 
		[RED("scrollArea")] 
		public inkScrollAreaWidgetReference ScrollArea
		{
			get => GetProperty(ref _scrollArea);
			set => SetProperty(ref _scrollArea, value);
		}

		[Ordinal(13)] 
		[RED("scrollControllerWidget")] 
		public inkWidgetReference ScrollControllerWidget
		{
			get => GetProperty(ref _scrollControllerWidget);
			set => SetProperty(ref _scrollControllerWidget, value);
		}

		[Ordinal(14)] 
		[RED("journalManager")] 
		public CHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(15)] 
		[RED("phoneSystem")] 
		public wCHandle<PhoneSystem> PhoneSystem
		{
			get => GetProperty(ref _phoneSystem);
			set => SetProperty(ref _phoneSystem, value);
		}

		[Ordinal(16)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetProperty(ref _active);
			set => SetProperty(ref _active, value);
		}

		[Ordinal(17)] 
		[RED("listController")] 
		public wCHandle<inkVirtualListController> ListController
		{
			get => GetProperty(ref _listController);
			set => SetProperty(ref _listController, value);
		}

		[Ordinal(18)] 
		[RED("dataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> DataSource
		{
			get => GetProperty(ref _dataSource);
			set => SetProperty(ref _dataSource, value);
		}

		[Ordinal(19)] 
		[RED("dataView")] 
		public CHandle<DialerContactDataView> DataView
		{
			get => GetProperty(ref _dataView);
			set => SetProperty(ref _dataView, value);
		}

		[Ordinal(20)] 
		[RED("templateClassifier")] 
		public CHandle<DialerContactTemplateClassifier> TemplateClassifier
		{
			get => GetProperty(ref _templateClassifier);
			set => SetProperty(ref _templateClassifier, value);
		}

		[Ordinal(21)] 
		[RED("scrollController")] 
		public wCHandle<inkScrollController> ScrollController
		{
			get => GetProperty(ref _scrollController);
			set => SetProperty(ref _scrollController, value);
		}

		[Ordinal(22)] 
		[RED("soundName")] 
		public CName SoundName
		{
			get => GetProperty(ref _soundName);
			set => SetProperty(ref _soundName, value);
		}

		[Ordinal(23)] 
		[RED("audioPhoneNavigation")] 
		public CName AudioPhoneNavigation
		{
			get => GetProperty(ref _audioPhoneNavigation);
			set => SetProperty(ref _audioPhoneNavigation, value);
		}

		[Ordinal(24)] 
		[RED("phoneBlackboard")] 
		public wCHandle<gameIBlackboard> PhoneBlackboard
		{
			get => GetProperty(ref _phoneBlackboard);
			set => SetProperty(ref _phoneBlackboard, value);
		}

		[Ordinal(25)] 
		[RED("phoneBBDefinition")] 
		public CHandle<UI_ComDeviceDef> PhoneBBDefinition
		{
			get => GetProperty(ref _phoneBBDefinition);
			set => SetProperty(ref _phoneBBDefinition, value);
		}

		[Ordinal(26)] 
		[RED("contactOpensBBID")] 
		public CHandle<redCallbackObject> ContactOpensBBID
		{
			get => GetProperty(ref _contactOpensBBID);
			set => SetProperty(ref _contactOpensBBID, value);
		}

		[Ordinal(27)] 
		[RED("switchAnimProxy")] 
		public CHandle<inkanimProxy> SwitchAnimProxy
		{
			get => GetProperty(ref _switchAnimProxy);
			set => SetProperty(ref _switchAnimProxy, value);
		}

		[Ordinal(28)] 
		[RED("transitionAnimProxy")] 
		public CHandle<inkanimProxy> TransitionAnimProxy
		{
			get => GetProperty(ref _transitionAnimProxy);
			set => SetProperty(ref _transitionAnimProxy, value);
		}

		[Ordinal(29)] 
		[RED("repeatingScrollActionEnabled")] 
		public CBool RepeatingScrollActionEnabled
		{
			get => GetProperty(ref _repeatingScrollActionEnabled);
			set => SetProperty(ref _repeatingScrollActionEnabled, value);
		}

		[Ordinal(30)] 
		[RED("firstInit")] 
		public CBool FirstInit
		{
			get => GetProperty(ref _firstInit);
			set => SetProperty(ref _firstInit, value);
		}

		public PhoneDialerGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
