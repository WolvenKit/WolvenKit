using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalImageEntry : gameJournalEntry
	{
		private TweakDBID _imageId;
		private TweakDBID _thumbnailImageId;

		[Ordinal(1)] 
		[RED("imageId")] 
		public TweakDBID ImageId
		{
			get => GetProperty(ref _imageId);
			set => SetProperty(ref _imageId, value);
		}

		[Ordinal(2)] 
		[RED("thumbnailImageId")] 
		public TweakDBID ThumbnailImageId
		{
			get => GetProperty(ref _thumbnailImageId);
			set => SetProperty(ref _thumbnailImageId, value);
		}
	}
}
