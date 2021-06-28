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
			get => GetProperty(ref _homeButton);
			set => SetProperty(ref _homeButton, value);
		}

		[Ordinal(2)] 
		[RED("homeButtonCoontroller")] 
		public CHandle<LinkController> HomeButtonCoontroller
		{
			get => GetProperty(ref _homeButtonCoontroller);
			set => SetProperty(ref _homeButtonCoontroller, value);
		}

		[Ordinal(3)] 
		[RED("addressText")] 
		public inkTextWidgetReference AddressText
		{
			get => GetProperty(ref _addressText);
			set => SetProperty(ref _addressText, value);
		}

		[Ordinal(4)] 
		[RED("pageContentRoot")] 
		public inkWidgetReference PageContentRoot
		{
			get => GetProperty(ref _pageContentRoot);
			set => SetProperty(ref _pageContentRoot, value);
		}

		[Ordinal(5)] 
		[RED("spinnerPath")] 
		public redResourceReferenceScriptToken SpinnerPath
		{
			get => GetProperty(ref _spinnerPath);
			set => SetProperty(ref _spinnerPath, value);
		}

		[Ordinal(6)] 
		[RED("webPageLibraryID")] 
		public CName WebPageLibraryID
		{
			get => GetProperty(ref _webPageLibraryID);
			set => SetProperty(ref _webPageLibraryID, value);
		}

		[Ordinal(7)] 
		[RED("defaultDevicePage")] 
		public CString DefaultDevicePage
		{
			get => GetProperty(ref _defaultDevicePage);
			set => SetProperty(ref _defaultDevicePage, value);
		}

		[Ordinal(8)] 
		[RED("gameController")] 
		public CHandle<BrowserGameController> GameController
		{
			get => GetProperty(ref _gameController);
			set => SetProperty(ref _gameController, value);
		}

		[Ordinal(9)] 
		[RED("websiteData")] 
		public CArray<wCHandle<gameJournalInternetPage>> WebsiteData
		{
			get => GetProperty(ref _websiteData);
			set => SetProperty(ref _websiteData, value);
		}

		[Ordinal(10)] 
		[RED("currentRequestedPage")] 
		public CString CurrentRequestedPage
		{
			get => GetProperty(ref _currentRequestedPage);
			set => SetProperty(ref _currentRequestedPage, value);
		}

		[Ordinal(11)] 
		[RED("currentPage")] 
		public wCHandle<inkCompoundWidget> CurrentPage
		{
			get => GetProperty(ref _currentPage);
			set => SetProperty(ref _currentPage, value);
		}

		[Ordinal(12)] 
		[RED("spinner")] 
		public wCHandle<inkWidget> Spinner
		{
			get => GetProperty(ref _spinner);
			set => SetProperty(ref _spinner, value);
		}

		public BrowserController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
