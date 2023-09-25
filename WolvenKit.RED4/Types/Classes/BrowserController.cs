using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BrowserController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("homeButton")] 
		public inkWidgetReference HomeButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("homeButtonCoontroller")] 
		public CWeakHandle<LinkController> HomeButtonCoontroller
		{
			get => GetPropertyValue<CWeakHandle<LinkController>>();
			set => SetPropertyValue<CWeakHandle<LinkController>>(value);
		}

		[Ordinal(3)] 
		[RED("addressText")] 
		public inkTextWidgetReference AddressText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("pageContentRoot")] 
		public inkWidgetReference PageContentRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("spinnerContentRoot")] 
		public inkWidgetReference SpinnerContentRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(7)] 
		[RED("spinnerPath")] 
		public redResourceReferenceScriptToken SpinnerPath
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(8)] 
		[RED("webPageLibraryID")] 
		public CName WebPageLibraryID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("defaultDevicePage")] 
		public CString DefaultDevicePage
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(10)] 
		[RED("gameController")] 
		public CWeakHandle<BrowserGameController> GameController
		{
			get => GetPropertyValue<CWeakHandle<BrowserGameController>>();
			set => SetPropertyValue<CWeakHandle<BrowserGameController>>(value);
		}

		[Ordinal(11)] 
		[RED("currentRequestedPage")] 
		public CWeakHandle<gameJournalInternetPage> CurrentRequestedPage
		{
			get => GetPropertyValue<CWeakHandle<gameJournalInternetPage>>();
			set => SetPropertyValue<CWeakHandle<gameJournalInternetPage>>(value);
		}

		[Ordinal(12)] 
		[RED("currentPage")] 
		public CWeakHandle<inkCompoundWidget> CurrentPage
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		[Ordinal(13)] 
		[RED("webPageSpawnRequest")] 
		public CWeakHandle<inkAsyncSpawnRequest> WebPageSpawnRequest
		{
			get => GetPropertyValue<CWeakHandle<inkAsyncSpawnRequest>>();
			set => SetPropertyValue<CWeakHandle<inkAsyncSpawnRequest>>(value);
		}

		public BrowserController()
		{
			HomeButton = new inkWidgetReference();
			AddressText = new inkTextWidgetReference();
			PageContentRoot = new inkWidgetReference();
			SpinnerContentRoot = new inkWidgetReference();
			SpinnerPath = new redResourceReferenceScriptToken();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
