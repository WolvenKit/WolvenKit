using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TarotMainGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("TooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("list")] 
		public inkCompoundWidgetReference List
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(7)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(8)] 
		[RED("TooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetPropertyValue<CWeakHandle<gameuiTooltipsManager>>();
			set => SetPropertyValue<CWeakHandle<gameuiTooltipsManager>>(value);
		}

		[Ordinal(9)] 
		[RED("selectedTarotCard")] 
		public CWeakHandle<tarotCardLogicController> SelectedTarotCard
		{
			get => GetPropertyValue<CWeakHandle<tarotCardLogicController>>();
			set => SetPropertyValue<CWeakHandle<tarotCardLogicController>>(value);
		}

		[Ordinal(10)] 
		[RED("fullscreenPreviewController")] 
		public CWeakHandle<TarotPreviewGameController> FullscreenPreviewController
		{
			get => GetPropertyValue<CWeakHandle<TarotPreviewGameController>>();
			set => SetPropertyValue<CWeakHandle<TarotPreviewGameController>>(value);
		}

		[Ordinal(11)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(12)] 
		[RED("tarotPreviewPopupToken")] 
		public CHandle<inkGameNotificationToken> TarotPreviewPopupToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(13)] 
		[RED("afterCloseRequest")] 
		public CBool AfterCloseRequest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("numberOfCardsInTarotDeck")] 
		public CInt32 NumberOfCardsInTarotDeck
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public TarotMainGameController()
		{
			ButtonHintsManagerRef = new();
			TooltipsManagerRef = new();
			List = new();
			NumberOfCardsInTarotDeck = 22;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
