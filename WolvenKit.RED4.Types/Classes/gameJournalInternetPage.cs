using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalInternetPage : gameJournalEntry
	{
		private CString _address;
		private CArray<gameJournalFactNameValue> _factsToSet;
		private CBool _additionallyFilledFromScripts;
		private CResourceAsyncReference<inkWidgetLibraryResource> _widgetFile;
		private CFloat _scale;
		private CArray<CHandle<gameJournalInternetText>> _texts;
		private CArray<CHandle<gameJournalInternetRectangle>> _rectangles;
		private CArray<CHandle<gameJournalInternetImage>> _images;
		private CArray<CHandle<gameJournalInternetVideo>> _videos;

		[Ordinal(1)] 
		[RED("address")] 
		public CString Address
		{
			get => GetProperty(ref _address);
			set => SetProperty(ref _address, value);
		}

		[Ordinal(2)] 
		[RED("factsToSet")] 
		public CArray<gameJournalFactNameValue> FactsToSet
		{
			get => GetProperty(ref _factsToSet);
			set => SetProperty(ref _factsToSet, value);
		}

		[Ordinal(3)] 
		[RED("additionallyFilledFromScripts")] 
		public CBool AdditionallyFilledFromScripts
		{
			get => GetProperty(ref _additionallyFilledFromScripts);
			set => SetProperty(ref _additionallyFilledFromScripts, value);
		}

		[Ordinal(4)] 
		[RED("widgetFile")] 
		public CResourceAsyncReference<inkWidgetLibraryResource> WidgetFile
		{
			get => GetProperty(ref _widgetFile);
			set => SetProperty(ref _widgetFile, value);
		}

		[Ordinal(5)] 
		[RED("scale")] 
		public CFloat Scale
		{
			get => GetProperty(ref _scale);
			set => SetProperty(ref _scale, value);
		}

		[Ordinal(6)] 
		[RED("texts")] 
		public CArray<CHandle<gameJournalInternetText>> Texts
		{
			get => GetProperty(ref _texts);
			set => SetProperty(ref _texts, value);
		}

		[Ordinal(7)] 
		[RED("rectangles")] 
		public CArray<CHandle<gameJournalInternetRectangle>> Rectangles
		{
			get => GetProperty(ref _rectangles);
			set => SetProperty(ref _rectangles, value);
		}

		[Ordinal(8)] 
		[RED("images")] 
		public CArray<CHandle<gameJournalInternetImage>> Images
		{
			get => GetProperty(ref _images);
			set => SetProperty(ref _images, value);
		}

		[Ordinal(9)] 
		[RED("videos")] 
		public CArray<CHandle<gameJournalInternetVideo>> Videos
		{
			get => GetProperty(ref _videos);
			set => SetProperty(ref _videos, value);
		}

		public gameJournalInternetPage()
		{
			_scale = 1.000000F;
		}
	}
}
