using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SimpleQuestListItemController : inkVirtualCompoundItemController
	{
		[Ordinal(18)] 
		[RED("title")] 
		public inkTextWidgetReference Title
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("description")] 
		public inkTextWidgetReference Description
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("typeIcon")] 
		public inkImageWidgetReference TypeIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("difficultIcon")] 
		public inkImageWidgetReference DifficultIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("fixerIcon")] 
		public inkImageWidgetReference FixerIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("ep1Icon")] 
		public inkImageWidgetReference Ep1Icon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("toggleAnimatedIndicator")] 
		public inkWidgetReference ToggleAnimatedIndicator
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("hoverIndicator")] 
		public inkWidgetReference HoverIndicator
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("questItemFrame")] 
		public inkWidgetReference QuestItemFrame
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("questItemBg")] 
		public inkWidgetReference QuestItemBg
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("questItemBgButton")] 
		public inkWidgetReference QuestItemBgButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("distanceContainer")] 
		public inkWidgetReference DistanceContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("defaultDistance")] 
		public inkTextWidgetReference DefaultDistance
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("trackedDistance")] 
		public inkTextWidgetReference TrackedDistance
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("isNewMarker")] 
		public inkWidgetReference IsNewMarker
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("toggleMarkAnimation")] 
		public CName ToggleMarkAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(34)] 
		[RED("trackMarkAnimation")] 
		public CName TrackMarkAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(35)] 
		[RED("distanceAnim_toDefault")] 
		public CName DistanceAnim_toDefault
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(36)] 
		[RED("distanceAnim_toHover")] 
		public CName DistanceAnim_toHover
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(37)] 
		[RED("distanceAnim_toTracked")] 
		public CName DistanceAnim_toTracked
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(38)] 
		[RED("distanceAnim_toHover_delay")] 
		public CFloat DistanceAnim_toHover_delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(39)] 
		[RED("pinIcon_toHover")] 
		public CName PinIcon_toHover
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(40)] 
		[RED("pinIcon_toDefault")] 
		public CName PinIcon_toDefault
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(41)] 
		[RED("toggleOnAnimProxy")] 
		public CHandle<inkanimProxy> ToggleOnAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(42)] 
		[RED("toggleOffAnimProxy")] 
		public CHandle<inkanimProxy> ToggleOffAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(43)] 
		[RED("pinIconAnimProxy")] 
		public CHandle<inkanimProxy> PinIconAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(44)] 
		[RED("distanceMarkerAnimProxy")] 
		public CHandle<inkanimProxy> DistanceMarkerAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(45)] 
		[RED("data")] 
		public CHandle<QuestListItemData> Data
		{
			get => GetPropertyValue<CHandle<QuestListItemData>>();
			set => SetPropertyValue<CHandle<QuestListItemData>>(value);
		}

		[Ordinal(46)] 
		[RED("openedQuest")] 
		public CWeakHandle<gameJournalQuest> OpenedQuest
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuest>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuest>>(value);
		}

		[Ordinal(47)] 
		[RED("hovered")] 
		public CBool Hovered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(48)] 
		[RED("toggled")] 
		public CBool Toggled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(49)] 
		[RED("tracked")] 
		public CBool Tracked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(50)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public SimpleQuestListItemController()
		{
			Title = new inkTextWidgetReference();
			Description = new inkTextWidgetReference();
			TypeIcon = new inkImageWidgetReference();
			DifficultIcon = new inkImageWidgetReference();
			FixerIcon = new inkImageWidgetReference();
			Ep1Icon = new inkImageWidgetReference();
			ToggleAnimatedIndicator = new inkWidgetReference();
			HoverIndicator = new inkWidgetReference();
			QuestItemFrame = new inkWidgetReference();
			QuestItemBg = new inkWidgetReference();
			QuestItemBgButton = new inkWidgetReference();
			DistanceContainer = new inkWidgetReference();
			DefaultDistance = new inkTextWidgetReference();
			TrackedDistance = new inkTextWidgetReference();
			IsNewMarker = new inkWidgetReference();
			DistanceAnim_toHover_delay = 0.200000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
