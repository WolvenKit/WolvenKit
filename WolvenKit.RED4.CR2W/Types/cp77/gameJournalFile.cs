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
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(2)] 
		[RED("content")] 
		public LocalizationString Content
		{
			get => GetProperty(ref _content);
			set => SetProperty(ref _content, value);
		}

		[Ordinal(3)] 
		[RED("videoResource")] 
		public raRef<Bink> VideoResource
		{
			get => GetProperty(ref _videoResource);
			set => SetProperty(ref _videoResource, value);
		}

		[Ordinal(4)] 
		[RED("PictureFilename(legacy)")] 
		public CString PictureFilename_legacy_
		{
			get => GetProperty(ref _pictureFilename_legacy_);
			set => SetProperty(ref _pictureFilename_legacy_, value);
		}

		[Ordinal(5)] 
		[RED("pictureTweak")] 
		public TweakDBID PictureTweak
		{
			get => GetProperty(ref _pictureTweak);
			set => SetProperty(ref _pictureTweak, value);
		}

		public gameJournalFile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
