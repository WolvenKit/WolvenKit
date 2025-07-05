using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalInternetPage : gameJournalEntry
	{
		[Ordinal(2)] 
		[RED("address")] 
		public CString Address
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("factsToSet")] 
		public CArray<gameJournalFactNameValue> FactsToSet
		{
			get => GetPropertyValue<CArray<gameJournalFactNameValue>>();
			set => SetPropertyValue<CArray<gameJournalFactNameValue>>(value);
		}

		[Ordinal(4)] 
		[RED("additionallyFilledFromScripts")] 
		public CBool AdditionallyFilledFromScripts
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("reloadOnZoomIn")] 
		public CBool ReloadOnZoomIn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("widgetFile")] 
		public CResourceAsyncReference<inkWidgetLibraryResource> WidgetFile
		{
			get => GetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>();
			set => SetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>(value);
		}

		[Ordinal(7)] 
		[RED("scale")] 
		public CFloat Scale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("texts")] 
		public CArray<CHandle<gameJournalInternetText>> Texts
		{
			get => GetPropertyValue<CArray<CHandle<gameJournalInternetText>>>();
			set => SetPropertyValue<CArray<CHandle<gameJournalInternetText>>>(value);
		}

		[Ordinal(9)] 
		[RED("rectangles")] 
		public CArray<CHandle<gameJournalInternetRectangle>> Rectangles
		{
			get => GetPropertyValue<CArray<CHandle<gameJournalInternetRectangle>>>();
			set => SetPropertyValue<CArray<CHandle<gameJournalInternetRectangle>>>(value);
		}

		[Ordinal(10)] 
		[RED("images")] 
		public CArray<CHandle<gameJournalInternetImage>> Images
		{
			get => GetPropertyValue<CArray<CHandle<gameJournalInternetImage>>>();
			set => SetPropertyValue<CArray<CHandle<gameJournalInternetImage>>>(value);
		}

		[Ordinal(11)] 
		[RED("videos")] 
		public CArray<CHandle<gameJournalInternetVideo>> Videos
		{
			get => GetPropertyValue<CArray<CHandle<gameJournalInternetVideo>>>();
			set => SetPropertyValue<CArray<CHandle<gameJournalInternetVideo>>>(value);
		}

		[Ordinal(12)] 
		[RED("canvases")] 
		public CArray<CHandle<gameJournalInternetCanvas>> Canvases
		{
			get => GetPropertyValue<CArray<CHandle<gameJournalInternetCanvas>>>();
			set => SetPropertyValue<CArray<CHandle<gameJournalInternetCanvas>>>(value);
		}

		public gameJournalInternetPage()
		{
			JournalEntryOverrideDataList = new();
			FactsToSet = new();
			ReloadOnZoomIn = true;
			Scale = 1.000000F;
			Texts = new();
			Rectangles = new();
			Images = new();
			Videos = new();
			Canvases = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
