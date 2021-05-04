using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalEmail : gameJournalEntry
	{
		private LocalizationString _sender;
		private LocalizationString _addressee;
		private LocalizationString _title;
		private LocalizationString _content;
		private raRef<Bink> _videoResource;
		private TweakDBID _pictureTweak;

		[Ordinal(1)] 
		[RED("sender")] 
		public LocalizationString Sender
		{
			get => GetProperty(ref _sender);
			set => SetProperty(ref _sender, value);
		}

		[Ordinal(2)] 
		[RED("addressee")] 
		public LocalizationString Addressee
		{
			get => GetProperty(ref _addressee);
			set => SetProperty(ref _addressee, value);
		}

		[Ordinal(3)] 
		[RED("title")] 
		public LocalizationString Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(4)] 
		[RED("content")] 
		public LocalizationString Content
		{
			get => GetProperty(ref _content);
			set => SetProperty(ref _content, value);
		}

		[Ordinal(5)] 
		[RED("videoResource")] 
		public raRef<Bink> VideoResource
		{
			get => GetProperty(ref _videoResource);
			set => SetProperty(ref _videoResource, value);
		}

		[Ordinal(6)] 
		[RED("pictureTweak")] 
		public TweakDBID PictureTweak
		{
			get => GetProperty(ref _pictureTweak);
			set => SetProperty(ref _pictureTweak, value);
		}

		public gameJournalEmail(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
