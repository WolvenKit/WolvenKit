using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalFile : gameJournalEntry
	{
		private LocalizationString _title;
		private LocalizationString _content;
		private raRef<Bink> _videoResource;
		private CString _pictureFilename_legacy_;
		private TweakDBID _pictureTweak;

		[Ordinal(1)] 
		[RED("title")] 
		public LocalizationString Title
		{
			get
			{
				if (_title == null)
				{
					_title = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "title", cr2w, this);
				}
				return _title;
			}
			set
			{
				if (_title == value)
				{
					return;
				}
				_title = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("content")] 
		public LocalizationString Content
		{
			get
			{
				if (_content == null)
				{
					_content = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "content", cr2w, this);
				}
				return _content;
			}
			set
			{
				if (_content == value)
				{
					return;
				}
				_content = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("videoResource")] 
		public raRef<Bink> VideoResource
		{
			get
			{
				if (_videoResource == null)
				{
					_videoResource = (raRef<Bink>) CR2WTypeManager.Create("raRef:Bink", "videoResource", cr2w, this);
				}
				return _videoResource;
			}
			set
			{
				if (_videoResource == value)
				{
					return;
				}
				_videoResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("PictureFilename(legacy)")] 
		public CString PictureFilename_legacy_
		{
			get
			{
				if (_pictureFilename_legacy_ == null)
				{
					_pictureFilename_legacy_ = (CString) CR2WTypeManager.Create("String", "PictureFilename(legacy)", cr2w, this);
				}
				return _pictureFilename_legacy_;
			}
			set
			{
				if (_pictureFilename_legacy_ == value)
				{
					return;
				}
				_pictureFilename_legacy_ = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("pictureTweak")] 
		public TweakDBID PictureTweak
		{
			get
			{
				if (_pictureTweak == null)
				{
					_pictureTweak = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "pictureTweak", cr2w, this);
				}
				return _pictureTweak;
			}
			set
			{
				if (_pictureTweak == value)
				{
					return;
				}
				_pictureTweak = value;
				PropertySet(this);
			}
		}

		public gameJournalFile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
