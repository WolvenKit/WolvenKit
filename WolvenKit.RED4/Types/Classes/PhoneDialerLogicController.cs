using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PhoneDialerLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("tabsContainer")] 
		public inkWidgetReference TabsContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("titleContainer")] 
		public inkWidgetReference TitleContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("titleTextWidget")] 
		public inkTextWidgetReference TitleTextWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("acceptButtonLabel")] 
		public inkTextWidgetReference AcceptButtonLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("action2ButtonLabel")] 
		public inkTextWidgetReference Action2ButtonLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("inputHintsPanel")] 
		public inkWidgetReference InputHintsPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("threadPanel")] 
		public inkWidgetReference ThreadPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("threadList")] 
		public inkWidgetReference ThreadList
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("callsQuestFlag")] 
		public inkWidgetReference CallsQuestFlag
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("arrow")] 
		public inkWidgetReference Arrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("threadTab")] 
		public inkWidgetReference ThreadTab
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("unreadTab")] 
		public inkWidgetReference UnreadTab
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("threadTabLabel")] 
		public inkTextWidgetReference ThreadTabLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("contactsList")] 
		public inkWidgetReference ContactsList
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("avatarImage")] 
		public inkImageWidgetReference AvatarImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("contactAvatarsFluff")] 
		public inkWidgetReference ContactAvatarsFluff
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("scrollArea")] 
		public inkScrollAreaWidgetReference ScrollArea
		{
			get => GetPropertyValue<inkScrollAreaWidgetReference>();
			set => SetPropertyValue<inkScrollAreaWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("scrollControllerWidget")] 
		public inkWidgetReference ScrollControllerWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("acceptButtonWidget")] 
		public inkWidgetReference AcceptButtonWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("action2ButtonWidget")] 
		public inkWidgetReference Action2ButtonWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("showAllButtonWidget")] 
		public inkWidgetReference ShowAllButtonWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("showAllLabel")] 
		public inkTextWidgetReference ShowAllLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("nothingToReadMessageWidget")] 
		public inkWidgetReference NothingToReadMessageWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("scrollBarWidget")] 
		public inkWidgetReference ScrollBarWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("listController")] 
		public CWeakHandle<inkVirtualListController> ListController
		{
			get => GetPropertyValue<CWeakHandle<inkVirtualListController>>();
			set => SetPropertyValue<CWeakHandle<inkVirtualListController>>(value);
		}

		[Ordinal(26)] 
		[RED("dataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> DataSource
		{
			get => GetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>();
			set => SetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>(value);
		}

		[Ordinal(27)] 
		[RED("dataView")] 
		public CHandle<DialerContactDataView> DataView
		{
			get => GetPropertyValue<CHandle<DialerContactDataView>>();
			set => SetPropertyValue<CHandle<DialerContactDataView>>(value);
		}

		[Ordinal(28)] 
		[RED("templateClassifier")] 
		public CHandle<DialerContactTemplateClassifier> TemplateClassifier
		{
			get => GetPropertyValue<CHandle<DialerContactTemplateClassifier>>();
			set => SetPropertyValue<CHandle<DialerContactTemplateClassifier>>(value);
		}

		[Ordinal(29)] 
		[RED("scrollController")] 
		public CWeakHandle<inkScrollController> ScrollController
		{
			get => GetPropertyValue<CWeakHandle<inkScrollController>>();
			set => SetPropertyValue<CWeakHandle<inkScrollController>>(value);
		}

		[Ordinal(30)] 
		[RED("switchAnimProxy")] 
		public CHandle<inkanimProxy> SwitchAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(31)] 
		[RED("transitionAnimProxy")] 
		public CHandle<inkanimProxy> TransitionAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(32)] 
		[RED("horizontalMoveAnimProxy")] 
		public CHandle<inkanimProxy> HorizontalMoveAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(33)] 
		[RED("threadsController")] 
		public CWeakHandle<inkVirtualListController> ThreadsController
		{
			get => GetPropertyValue<CWeakHandle<inkVirtualListController>>();
			set => SetPropertyValue<CWeakHandle<inkVirtualListController>>(value);
		}

		[Ordinal(34)] 
		[RED("dataSourceCache")] 
		public CHandle<inkScriptableDataSourceWrapper> DataSourceCache
		{
			get => GetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>();
			set => SetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>(value);
		}

		[Ordinal(35)] 
		[RED("dataViewCache")] 
		public CHandle<DialerContactDataView> DataViewCache
		{
			get => GetPropertyValue<CHandle<DialerContactDataView>>();
			set => SetPropertyValue<CHandle<DialerContactDataView>>(value);
		}

		[Ordinal(36)] 
		[RED("moveBehindAnimProxy")] 
		public CHandle<inkanimProxy> MoveBehindAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(37)] 
		[RED("hideContactAnimProxy")] 
		public CHandle<inkanimProxy> HideContactAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(38)] 
		[RED("contactIndexCache")] 
		public CUInt32 ContactIndexCache
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(39)] 
		[RED("menuSelectorCtrl")] 
		public CWeakHandle<PhoneDialerSelectionController> MenuSelectorCtrl
		{
			get => GetPropertyValue<CWeakHandle<PhoneDialerSelectionController>>();
			set => SetPropertyValue<CWeakHandle<PhoneDialerSelectionController>>(value);
		}

		[Ordinal(40)] 
		[RED("firstInit")] 
		public CBool FirstInit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(41)] 
		[RED("indexToSelect")] 
		public CUInt32 IndexToSelect
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(42)] 
		[RED("hidingIndex")] 
		public CUInt32 HidingIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(43)] 
		[RED("pulseAnim")] 
		public CHandle<PulseAnimation> PulseAnim
		{
			get => GetPropertyValue<CHandle<PulseAnimation>>();
			set => SetPropertyValue<CHandle<PulseAnimation>>(value);
		}

		[Ordinal(44)] 
		[RED("leftMargin")] 
		public inkMargin LeftMargin
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		[Ordinal(45)] 
		[RED("rightMargin")] 
		public inkMargin RightMargin
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		[Ordinal(46)] 
		[RED("currentTab")] 
		public CEnum<PhoneDialerTabs> CurrentTab
		{
			get => GetPropertyValue<CEnum<PhoneDialerTabs>>();
			set => SetPropertyValue<CEnum<PhoneDialerTabs>>(value);
		}

		[Ordinal(47)] 
		[RED("callingEnabled")] 
		public CBool CallingEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PhoneDialerLogicController()
		{
			TabsContainer = new inkWidgetReference();
			TitleContainer = new inkWidgetReference();
			TitleTextWidget = new inkTextWidgetReference();
			AcceptButtonLabel = new inkTextWidgetReference();
			Action2ButtonLabel = new inkTextWidgetReference();
			InputHintsPanel = new inkWidgetReference();
			ThreadPanel = new inkWidgetReference();
			ThreadList = new inkWidgetReference();
			CallsQuestFlag = new inkWidgetReference();
			Arrow = new inkWidgetReference();
			ThreadTab = new inkWidgetReference();
			UnreadTab = new inkWidgetReference();
			ThreadTabLabel = new inkTextWidgetReference();
			ContactsList = new inkWidgetReference();
			AvatarImage = new inkImageWidgetReference();
			ContactAvatarsFluff = new inkWidgetReference();
			ScrollArea = new inkScrollAreaWidgetReference();
			ScrollControllerWidget = new inkWidgetReference();
			AcceptButtonWidget = new inkWidgetReference();
			Action2ButtonWidget = new inkWidgetReference();
			ShowAllButtonWidget = new inkWidgetReference();
			ShowAllLabel = new inkTextWidgetReference();
			NothingToReadMessageWidget = new inkWidgetReference();
			ScrollBarWidget = new inkWidgetReference();
			LeftMargin = new inkMargin();
			RightMargin = new inkMargin();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
