using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TarotMainGameController : gameuiMenuGameController
	{
		private inkWidgetReference _buttonHintsManagerRef;
		private inkWidgetReference _tooltipsManagerRef;
		private inkCompoundWidgetReference _list;
		private CWeakHandle<gameJournalManager> _journalManager;
		private CWeakHandle<ButtonHints> _buttonHintsController;
		private CWeakHandle<gameuiTooltipsManager> _tooltipsManager;
		private CWeakHandle<tarotCardLogicController> _selectedTarotCard;
		private CWeakHandle<TarotPreviewGameController> _fullscreenPreviewController;
		private CWeakHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private CHandle<inkGameNotificationToken> _tarotPreviewPopupToken;
		private CBool _afterCloseRequest;
		private CInt32 _numberOfCardsInTarotDeck;

		[Ordinal(3)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(4)] 
		[RED("TooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetProperty(ref _tooltipsManagerRef);
			set => SetProperty(ref _tooltipsManagerRef, value);
		}

		[Ordinal(5)] 
		[RED("list")] 
		public inkCompoundWidgetReference List
		{
			get => GetProperty(ref _list);
			set => SetProperty(ref _list, value);
		}

		[Ordinal(6)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(7)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(8)] 
		[RED("TooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}

		[Ordinal(9)] 
		[RED("selectedTarotCard")] 
		public CWeakHandle<tarotCardLogicController> SelectedTarotCard
		{
			get => GetProperty(ref _selectedTarotCard);
			set => SetProperty(ref _selectedTarotCard, value);
		}

		[Ordinal(10)] 
		[RED("fullscreenPreviewController")] 
		public CWeakHandle<TarotPreviewGameController> FullscreenPreviewController
		{
			get => GetProperty(ref _fullscreenPreviewController);
			set => SetProperty(ref _fullscreenPreviewController, value);
		}

		[Ordinal(11)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(12)] 
		[RED("tarotPreviewPopupToken")] 
		public CHandle<inkGameNotificationToken> TarotPreviewPopupToken
		{
			get => GetProperty(ref _tarotPreviewPopupToken);
			set => SetProperty(ref _tarotPreviewPopupToken, value);
		}

		[Ordinal(13)] 
		[RED("afterCloseRequest")] 
		public CBool AfterCloseRequest
		{
			get => GetProperty(ref _afterCloseRequest);
			set => SetProperty(ref _afterCloseRequest, value);
		}

		[Ordinal(14)] 
		[RED("numberOfCardsInTarotDeck")] 
		public CInt32 NumberOfCardsInTarotDeck
		{
			get => GetProperty(ref _numberOfCardsInTarotDeck);
			set => SetProperty(ref _numberOfCardsInTarotDeck, value);
		}
	}
}
