using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BrowserController : inkWidgetLogicController
	{
		private inkWidgetReference _homeButton;
		private CWeakHandle<LinkController> _homeButtonCoontroller;
		private inkTextWidgetReference _addressText;
		private inkWidgetReference _pageContentRoot;
		private redResourceReferenceScriptToken _spinnerPath;
		private CName _webPageLibraryID;
		private CString _defaultDevicePage;
		private CWeakHandle<BrowserGameController> _gameController;
		private CArray<CWeakHandle<gameJournalInternetPage>> _websiteData;
		private CWeakHandle<gameJournalInternetPage> _currentRequestedPage;
		private CWeakHandle<inkCompoundWidget> _currentPage;
		private CWeakHandle<inkWidget> _spinner;

		[Ordinal(1)] 
		[RED("homeButton")] 
		public inkWidgetReference HomeButton
		{
			get => GetProperty(ref _homeButton);
			set => SetProperty(ref _homeButton, value);
		}

		[Ordinal(2)] 
		[RED("homeButtonCoontroller")] 
		public CWeakHandle<LinkController> HomeButtonCoontroller
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
		public CWeakHandle<BrowserGameController> GameController
		{
			get => GetProperty(ref _gameController);
			set => SetProperty(ref _gameController, value);
		}

		[Ordinal(9)] 
		[RED("websiteData")] 
		public CArray<CWeakHandle<gameJournalInternetPage>> WebsiteData
		{
			get => GetProperty(ref _websiteData);
			set => SetProperty(ref _websiteData, value);
		}

		[Ordinal(10)] 
		[RED("currentRequestedPage")] 
		public CWeakHandle<gameJournalInternetPage> CurrentRequestedPage
		{
			get => GetProperty(ref _currentRequestedPage);
			set => SetProperty(ref _currentRequestedPage, value);
		}

		[Ordinal(11)] 
		[RED("currentPage")] 
		public CWeakHandle<inkCompoundWidget> CurrentPage
		{
			get => GetProperty(ref _currentPage);
			set => SetProperty(ref _currentPage, value);
		}

		[Ordinal(12)] 
		[RED("spinner")] 
		public CWeakHandle<inkWidget> Spinner
		{
			get => GetProperty(ref _spinner);
			set => SetProperty(ref _spinner, value);
		}
	}
}
