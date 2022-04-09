using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalImageEntry : gameJournalEntry
	{
		[Ordinal(1)] 
		[RED("imageId")] 
		public TweakDBID ImageId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("thumbnailImageId")] 
		public TweakDBID ThumbnailImageId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameJournalImageEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
