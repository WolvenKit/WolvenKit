using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalCodexEntry : gameJournalContainerEntry
	{
		private LocalizationString _title;
		private TweakDBID _imageId;
		private TweakDBID _linkImageId;

		[Ordinal(2)] 
		[RED("title")] 
		public LocalizationString Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(3)] 
		[RED("imageId")] 
		public TweakDBID ImageId
		{
			get => GetProperty(ref _imageId);
			set => SetProperty(ref _imageId, value);
		}

		[Ordinal(4)] 
		[RED("linkImageId")] 
		public TweakDBID LinkImageId
		{
			get => GetProperty(ref _linkImageId);
			set => SetProperty(ref _linkImageId, value);
		}

		public gameJournalCodexEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
