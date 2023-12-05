using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PhoneDialerGameController : gameuiNewPhoneRelatedHUDGameController
	{
		[Ordinal(15)] 
		[RED("contactsList")] 
		public inkWidgetReference ContactsList
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("avatarImage")] 
		public inkImageWidgetReference AvatarImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("hintMessenger")] 
		public inkWidgetReference HintMessenger
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("scrollArea")] 
		public inkScrollAreaWidgetReference ScrollArea
		{
			get => GetPropertyValue<inkScrollAreaWidgetReference>();
			set => SetPropertyValue<inkScrollAreaWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("scrollControllerWidget")] 
		public inkWidgetReference ScrollControllerWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("journalManager")] 
		public CHandle<gameJournalManager> JournalManager
		{
			get => GetPropertyValue<CHandle<gameJournalManager>>();
			set => SetPropertyValue<CHandle<gameJournalManager>>(value);
		}

		[Ordinal(21)] 
		[RED("phoneSystem")] 
		public CWeakHandle<PhoneSystem> PhoneSystem
		{
			get => GetPropertyValue<CWeakHandle<PhoneSystem>>();
			set => SetPropertyValue<CWeakHandle<PhoneSystem>>(value);
		}

		[Ordinal(22)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("listController")] 
		public CWeakHandle<inkVirtualListController> ListController
		{
			get => GetPropertyValue<CWeakHandle<inkVirtualListController>>();
			set => SetPropertyValue<CWeakHandle<inkVirtualListController>>(value);
		}

		[Ordinal(24)] 
		[RED("dataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> DataSource
		{
			get => GetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>();
			set => SetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>(value);
		}

		[Ordinal(25)] 
		[RED("dataView")] 
		public CHandle<DialerContactDataView> DataView
		{
			get => GetPropertyValue<CHandle<DialerContactDataView>>();
			set => SetPropertyValue<CHandle<DialerContactDataView>>(value);
		}

		[Ordinal(26)] 
		[RED("templateClassifier")] 
		public CHandle<DialerContactTemplateClassifier> TemplateClassifier
		{
			get => GetPropertyValue<CHandle<DialerContactTemplateClassifier>>();
			set => SetPropertyValue<CHandle<DialerContactTemplateClassifier>>(value);
		}

		[Ordinal(27)] 
		[RED("scrollController")] 
		public CWeakHandle<inkScrollController> ScrollController
		{
			get => GetPropertyValue<CWeakHandle<inkScrollController>>();
			set => SetPropertyValue<CWeakHandle<inkScrollController>>(value);
		}

		[Ordinal(28)] 
		[RED("soundName")] 
		public CName SoundName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(29)] 
		[RED("audioPhoneNavigation")] 
		public CName AudioPhoneNavigation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(30)] 
		[RED("phoneBlackboard")] 
		public CWeakHandle<gameIBlackboard> PhoneBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(31)] 
		[RED("phoneBBDefinition")] 
		public CHandle<UI_ComDeviceDef> PhoneBBDefinition
		{
			get => GetPropertyValue<CHandle<UI_ComDeviceDef>>();
			set => SetPropertyValue<CHandle<UI_ComDeviceDef>>(value);
		}

		[Ordinal(32)] 
		[RED("contactOpensBBID")] 
		public CHandle<redCallbackObject> ContactOpensBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(33)] 
		[RED("switchAnimProxy")] 
		public CHandle<inkanimProxy> SwitchAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(34)] 
		[RED("transitionAnimProxy")] 
		public CHandle<inkanimProxy> TransitionAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(35)] 
		[RED("repeatingScrollActionEnabled")] 
		public CBool RepeatingScrollActionEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(36)] 
		[RED("firstInit")] 
		public CBool FirstInit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PhoneDialerGameController()
		{
			ContactsList = new inkWidgetReference();
			AvatarImage = new inkImageWidgetReference();
			HintMessenger = new inkWidgetReference();
			ScrollArea = new inkScrollAreaWidgetReference();
			ScrollControllerWidget = new inkWidgetReference();
			SoundName = "Phone";
			AudioPhoneNavigation = "ui_phone_navigation";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
