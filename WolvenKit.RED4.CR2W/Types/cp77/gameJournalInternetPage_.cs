using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalInternetPage_ : gameJournalEntry
	{
		private CString _address;
		private CArray<gameJournalFactNameValue> _factsToSet;
		private CBool _additionallyFilledFromScripts;
		private raRef<inkWidgetLibraryResource> _widgetFile;
		private CFloat _scale;
		private CArray<CHandle<gameJournalInternetText>> _texts;
		private CArray<CHandle<gameJournalInternetRectangle>> _rectangles;
		private CArray<CHandle<gameJournalInternetImage>> _images;
		private CArray<CHandle<gameJournalInternetVideo>> _videos;

		[Ordinal(1)] 
		[RED("address")] 
		public CString Address
		{
			get
			{
				if (_address == null)
				{
					_address = (CString) CR2WTypeManager.Create("String", "address", cr2w, this);
				}
				return _address;
			}
			set
			{
				if (_address == value)
				{
					return;
				}
				_address = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("factsToSet")] 
		public CArray<gameJournalFactNameValue> FactsToSet
		{
			get
			{
				if (_factsToSet == null)
				{
					_factsToSet = (CArray<gameJournalFactNameValue>) CR2WTypeManager.Create("array:gameJournalFactNameValue", "factsToSet", cr2w, this);
				}
				return _factsToSet;
			}
			set
			{
				if (_factsToSet == value)
				{
					return;
				}
				_factsToSet = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("additionallyFilledFromScripts")] 
		public CBool AdditionallyFilledFromScripts
		{
			get
			{
				if (_additionallyFilledFromScripts == null)
				{
					_additionallyFilledFromScripts = (CBool) CR2WTypeManager.Create("Bool", "additionallyFilledFromScripts", cr2w, this);
				}
				return _additionallyFilledFromScripts;
			}
			set
			{
				if (_additionallyFilledFromScripts == value)
				{
					return;
				}
				_additionallyFilledFromScripts = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("widgetFile")] 
		public raRef<inkWidgetLibraryResource> WidgetFile
		{
			get
			{
				if (_widgetFile == null)
				{
					_widgetFile = (raRef<inkWidgetLibraryResource>) CR2WTypeManager.Create("raRef:inkWidgetLibraryResource", "widgetFile", cr2w, this);
				}
				return _widgetFile;
			}
			set
			{
				if (_widgetFile == value)
				{
					return;
				}
				_widgetFile = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("scale")] 
		public CFloat Scale
		{
			get
			{
				if (_scale == null)
				{
					_scale = (CFloat) CR2WTypeManager.Create("Float", "scale", cr2w, this);
				}
				return _scale;
			}
			set
			{
				if (_scale == value)
				{
					return;
				}
				_scale = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("texts")] 
		public CArray<CHandle<gameJournalInternetText>> Texts
		{
			get
			{
				if (_texts == null)
				{
					_texts = (CArray<CHandle<gameJournalInternetText>>) CR2WTypeManager.Create("array:handle:gameJournalInternetText", "texts", cr2w, this);
				}
				return _texts;
			}
			set
			{
				if (_texts == value)
				{
					return;
				}
				_texts = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("rectangles")] 
		public CArray<CHandle<gameJournalInternetRectangle>> Rectangles
		{
			get
			{
				if (_rectangles == null)
				{
					_rectangles = (CArray<CHandle<gameJournalInternetRectangle>>) CR2WTypeManager.Create("array:handle:gameJournalInternetRectangle", "rectangles", cr2w, this);
				}
				return _rectangles;
			}
			set
			{
				if (_rectangles == value)
				{
					return;
				}
				_rectangles = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("images")] 
		public CArray<CHandle<gameJournalInternetImage>> Images
		{
			get
			{
				if (_images == null)
				{
					_images = (CArray<CHandle<gameJournalInternetImage>>) CR2WTypeManager.Create("array:handle:gameJournalInternetImage", "images", cr2w, this);
				}
				return _images;
			}
			set
			{
				if (_images == value)
				{
					return;
				}
				_images = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("videos")] 
		public CArray<CHandle<gameJournalInternetVideo>> Videos
		{
			get
			{
				if (_videos == null)
				{
					_videos = (CArray<CHandle<gameJournalInternetVideo>>) CR2WTypeManager.Create("array:handle:gameJournalInternetVideo", "videos", cr2w, this);
				}
				return _videos;
			}
			set
			{
				if (_videos == value)
				{
					return;
				}
				_videos = value;
				PropertySet(this);
			}
		}

		public gameJournalInternetPage_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
