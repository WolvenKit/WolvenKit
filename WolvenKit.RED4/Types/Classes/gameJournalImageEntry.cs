using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalImageEntry : gameJournalEntry
	{
		[Ordinal(2)] 
		[RED("imageId")] 
		public TweakDBID ImageId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("thumbnailImageId")] 
		public TweakDBID ThumbnailImageId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameJournalImageEntry()
		{
			JournalEntryOverrideDataList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
