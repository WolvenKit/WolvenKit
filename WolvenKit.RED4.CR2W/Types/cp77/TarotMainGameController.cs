using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TarotMainGameController : gameuiMenuGameController
	{
		private inkWidgetReference _buttonHintsManagerRef;
		private inkWidgetReference _tooltipsManagerRef;
		private inkCompoundWidgetReference _list;
		private wCHandle<gameJournalManager> _journalManager;
		private wCHandle<ButtonHints> _buttonHintsController;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;
		private wCHandle<tarotCardLogicController> _selectedTarotCard;
		private CHandle<TarotPreviewGameController> _fullscreenPreviewController;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private CHandle<inkGameNotificationToken> _tarotPreviewPopupToken;
		private CBool _afterCloseRequest;
		private CInt32 _numberOfCardsInTarotDeck;

		[Ordinal(3)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get
			{
				if (_buttonHintsManagerRef == null)
				{
					_buttonHintsManagerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonHintsManagerRef", cr2w, this);
				}
				return _buttonHintsManagerRef;
			}
			set
			{
				if (_buttonHintsManagerRef == value)
				{
					return;
				}
				_buttonHintsManagerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("TooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get
			{
				if (_tooltipsManagerRef == null)
				{
					_tooltipsManagerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "TooltipsManagerRef", cr2w, this);
				}
				return _tooltipsManagerRef;
			}
			set
			{
				if (_tooltipsManagerRef == value)
				{
					return;
				}
				_tooltipsManagerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("list")] 
		public inkCompoundWidgetReference List
		{
			get
			{
				if (_list == null)
				{
					_list = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "list", cr2w, this);
				}
				return _list;
			}
			set
			{
				if (_list == value)
				{
					return;
				}
				_list = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("journalManager")] 
		public wCHandle<gameJournalManager> JournalManager
		{
			get
			{
				if (_journalManager == null)
				{
					_journalManager = (wCHandle<gameJournalManager>) CR2WTypeManager.Create("whandle:gameJournalManager", "journalManager", cr2w, this);
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

		[Ordinal(7)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get
			{
				if (_buttonHintsController == null)
				{
					_buttonHintsController = (wCHandle<ButtonHints>) CR2WTypeManager.Create("whandle:ButtonHints", "buttonHintsController", cr2w, this);
				}
				return _buttonHintsController;
			}
			set
			{
				if (_buttonHintsController == value)
				{
					return;
				}
				_buttonHintsController = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("TooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get
			{
				if (_tooltipsManager == null)
				{
					_tooltipsManager = (wCHandle<gameuiTooltipsManager>) CR2WTypeManager.Create("whandle:gameuiTooltipsManager", "TooltipsManager", cr2w, this);
				}
				return _tooltipsManager;
			}
			set
			{
				if (_tooltipsManager == value)
				{
					return;
				}
				_tooltipsManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("selectedTarotCard")] 
		public wCHandle<tarotCardLogicController> SelectedTarotCard
		{
			get
			{
				if (_selectedTarotCard == null)
				{
					_selectedTarotCard = (wCHandle<tarotCardLogicController>) CR2WTypeManager.Create("whandle:tarotCardLogicController", "selectedTarotCard", cr2w, this);
				}
				return _selectedTarotCard;
			}
			set
			{
				if (_selectedTarotCard == value)
				{
					return;
				}
				_selectedTarotCard = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("fullscreenPreviewController")] 
		public CHandle<TarotPreviewGameController> FullscreenPreviewController
		{
			get
			{
				if (_fullscreenPreviewController == null)
				{
					_fullscreenPreviewController = (CHandle<TarotPreviewGameController>) CR2WTypeManager.Create("handle:TarotPreviewGameController", "fullscreenPreviewController", cr2w, this);
				}
				return _fullscreenPreviewController;
			}
			set
			{
				if (_fullscreenPreviewController == value)
				{
					return;
				}
				_fullscreenPreviewController = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get
			{
				if (_menuEventDispatcher == null)
				{
					_menuEventDispatcher = (wCHandle<inkMenuEventDispatcher>) CR2WTypeManager.Create("whandle:inkMenuEventDispatcher", "menuEventDispatcher", cr2w, this);
				}
				return _menuEventDispatcher;
			}
			set
			{
				if (_menuEventDispatcher == value)
				{
					return;
				}
				_menuEventDispatcher = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("tarotPreviewPopupToken")] 
		public CHandle<inkGameNotificationToken> TarotPreviewPopupToken
		{
			get
			{
				if (_tarotPreviewPopupToken == null)
				{
					_tarotPreviewPopupToken = (CHandle<inkGameNotificationToken>) CR2WTypeManager.Create("handle:inkGameNotificationToken", "tarotPreviewPopupToken", cr2w, this);
				}
				return _tarotPreviewPopupToken;
			}
			set
			{
				if (_tarotPreviewPopupToken == value)
				{
					return;
				}
				_tarotPreviewPopupToken = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("afterCloseRequest")] 
		public CBool AfterCloseRequest
		{
			get
			{
				if (_afterCloseRequest == null)
				{
					_afterCloseRequest = (CBool) CR2WTypeManager.Create("Bool", "afterCloseRequest", cr2w, this);
				}
				return _afterCloseRequest;
			}
			set
			{
				if (_afterCloseRequest == value)
				{
					return;
				}
				_afterCloseRequest = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("numberOfCardsInTarotDeck")] 
		public CInt32 NumberOfCardsInTarotDeck
		{
			get
			{
				if (_numberOfCardsInTarotDeck == null)
				{
					_numberOfCardsInTarotDeck = (CInt32) CR2WTypeManager.Create("Int32", "numberOfCardsInTarotDeck", cr2w, this);
				}
				return _numberOfCardsInTarotDeck;
			}
			set
			{
				if (_numberOfCardsInTarotDeck == value)
				{
					return;
				}
				_numberOfCardsInTarotDeck = value;
				PropertySet(this);
			}
		}

		public TarotMainGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
