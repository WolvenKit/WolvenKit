using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BrowserController : inkWidgetLogicController
	{
		private inkWidgetReference _homeButton;
		private CHandle<LinkController> _homeButtonCoontroller;
		private inkTextWidgetReference _addressText;
		private inkWidgetReference _pageContentRoot;
		private redResourceReferenceScriptToken _spinnerPath;
		private CName _webPageLibraryID;
		private CString _defaultDevicePage;
		private CHandle<BrowserGameController> _gameController;
		private CArray<wCHandle<gameJournalInternetPage>> _websiteData;
		private CString _currentRequestedPage;
		private wCHandle<inkCompoundWidget> _currentPage;
		private wCHandle<inkWidget> _spinner;

		[Ordinal(1)] 
		[RED("homeButton")] 
		public inkWidgetReference HomeButton
		{
			get
			{
				if (_homeButton == null)
				{
					_homeButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "homeButton", cr2w, this);
				}
				return _homeButton;
			}
			set
			{
				if (_homeButton == value)
				{
					return;
				}
				_homeButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("homeButtonCoontroller")] 
		public CHandle<LinkController> HomeButtonCoontroller
		{
			get
			{
				if (_homeButtonCoontroller == null)
				{
					_homeButtonCoontroller = (CHandle<LinkController>) CR2WTypeManager.Create("handle:LinkController", "homeButtonCoontroller", cr2w, this);
				}
				return _homeButtonCoontroller;
			}
			set
			{
				if (_homeButtonCoontroller == value)
				{
					return;
				}
				_homeButtonCoontroller = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("addressText")] 
		public inkTextWidgetReference AddressText
		{
			get
			{
				if (_addressText == null)
				{
					_addressText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "addressText", cr2w, this);
				}
				return _addressText;
			}
			set
			{
				if (_addressText == value)
				{
					return;
				}
				_addressText = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("pageContentRoot")] 
		public inkWidgetReference PageContentRoot
		{
			get
			{
				if (_pageContentRoot == null)
				{
					_pageContentRoot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "pageContentRoot", cr2w, this);
				}
				return _pageContentRoot;
			}
			set
			{
				if (_pageContentRoot == value)
				{
					return;
				}
				_pageContentRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("spinnerPath")] 
		public redResourceReferenceScriptToken SpinnerPath
		{
			get
			{
				if (_spinnerPath == null)
				{
					_spinnerPath = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "spinnerPath", cr2w, this);
				}
				return _spinnerPath;
			}
			set
			{
				if (_spinnerPath == value)
				{
					return;
				}
				_spinnerPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("webPageLibraryID")] 
		public CName WebPageLibraryID
		{
			get
			{
				if (_webPageLibraryID == null)
				{
					_webPageLibraryID = (CName) CR2WTypeManager.Create("CName", "webPageLibraryID", cr2w, this);
				}
				return _webPageLibraryID;
			}
			set
			{
				if (_webPageLibraryID == value)
				{
					return;
				}
				_webPageLibraryID = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("defaultDevicePage")] 
		public CString DefaultDevicePage
		{
			get
			{
				if (_defaultDevicePage == null)
				{
					_defaultDevicePage = (CString) CR2WTypeManager.Create("String", "defaultDevicePage", cr2w, this);
				}
				return _defaultDevicePage;
			}
			set
			{
				if (_defaultDevicePage == value)
				{
					return;
				}
				_defaultDevicePage = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("gameController")] 
		public CHandle<BrowserGameController> GameController
		{
			get
			{
				if (_gameController == null)
				{
					_gameController = (CHandle<BrowserGameController>) CR2WTypeManager.Create("handle:BrowserGameController", "gameController", cr2w, this);
				}
				return _gameController;
			}
			set
			{
				if (_gameController == value)
				{
					return;
				}
				_gameController = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("websiteData")] 
		public CArray<wCHandle<gameJournalInternetPage>> WebsiteData
		{
			get
			{
				if (_websiteData == null)
				{
					_websiteData = (CArray<wCHandle<gameJournalInternetPage>>) CR2WTypeManager.Create("array:whandle:gameJournalInternetPage", "websiteData", cr2w, this);
				}
				return _websiteData;
			}
			set
			{
				if (_websiteData == value)
				{
					return;
				}
				_websiteData = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("currentRequestedPage")] 
		public CString CurrentRequestedPage
		{
			get
			{
				if (_currentRequestedPage == null)
				{
					_currentRequestedPage = (CString) CR2WTypeManager.Create("String", "currentRequestedPage", cr2w, this);
				}
				return _currentRequestedPage;
			}
			set
			{
				if (_currentRequestedPage == value)
				{
					return;
				}
				_currentRequestedPage = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("currentPage")] 
		public wCHandle<inkCompoundWidget> CurrentPage
		{
			get
			{
				if (_currentPage == null)
				{
					_currentPage = (wCHandle<inkCompoundWidget>) CR2WTypeManager.Create("whandle:inkCompoundWidget", "currentPage", cr2w, this);
				}
				return _currentPage;
			}
			set
			{
				if (_currentPage == value)
				{
					return;
				}
				_currentPage = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("spinner")] 
		public wCHandle<inkWidget> Spinner
		{
			get
			{
				if (_spinner == null)
				{
					_spinner = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "spinner", cr2w, this);
				}
				return _spinner;
			}
			set
			{
				if (_spinner == value)
				{
					return;
				}
				_spinner = value;
				PropertySet(this);
			}
		}

		public BrowserController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
