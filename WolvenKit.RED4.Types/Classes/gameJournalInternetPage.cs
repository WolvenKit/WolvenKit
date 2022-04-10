using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalInternetPage : gameJournalEntry
	{
		[Ordinal(1)] 
		[RED("address")] 
		public CString Address
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("factsToSet")] 
		public CArray<gameJournalFactNameValue> FactsToSet
		{
			get => GetPropertyValue<CArray<gameJournalFactNameValue>>();
			set => SetPropertyValue<CArray<gameJournalFactNameValue>>(value);
		}

		[Ordinal(3)] 
		[RED("additionallyFilledFromScripts")] 
		public CBool AdditionallyFilledFromScripts
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("widgetFile")] 
		public CResourceAsyncReference<inkWidgetLibraryResource> WidgetFile
		{
			get => GetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>();
			set => SetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>(value);
		}

		[Ordinal(5)] 
		[RED("scale")] 
		public CFloat Scale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("texts")] 
		public CArray<CHandle<gameJournalInternetText>> Texts
		{
			get => GetPropertyValue<CArray<CHandle<gameJournalInternetText>>>();
			set => SetPropertyValue<CArray<CHandle<gameJournalInternetText>>>(value);
		}

		[Ordinal(7)] 
		[RED("rectangles")] 
		public CArray<CHandle<gameJournalInternetRectangle>> Rectangles
		{
			get => GetPropertyValue<CArray<CHandle<gameJournalInternetRectangle>>>();
			set => SetPropertyValue<CArray<CHandle<gameJournalInternetRectangle>>>(value);
		}

		[Ordinal(8)] 
		[RED("images")] 
		public CArray<CHandle<gameJournalInternetImage>> Images
		{
			get => GetPropertyValue<CArray<CHandle<gameJournalInternetImage>>>();
			set => SetPropertyValue<CArray<CHandle<gameJournalInternetImage>>>(value);
		}

		[Ordinal(9)] 
		[RED("videos")] 
		public CArray<CHandle<gameJournalInternetVideo>> Videos
		{
			get => GetPropertyValue<CArray<CHandle<gameJournalInternetVideo>>>();
			set => SetPropertyValue<CArray<CHandle<gameJournalInternetVideo>>>(value);
		}

		public gameJournalInternetPage()
		{
			FactsToSet = new();
			Scale = 1.000000F;
			Texts = new();
			Rectangles = new();
			Images = new();
			Videos = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
