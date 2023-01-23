using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CustomUIAnimationEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("libraryItemName")] 
		public CName LibraryItemName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("libraryItemAnchor")] 
		public CEnum<inkEAnchor> LibraryItemAnchor
		{
			get => GetPropertyValue<CEnum<inkEAnchor>>();
			set => SetPropertyValue<CEnum<inkEAnchor>>(value);
		}

		[Ordinal(2)] 
		[RED("forceRespawnLibraryItem")] 
		public CBool ForceRespawnLibraryItem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("playbackOption")] 
		public CEnum<EInkAnimationPlaybackOption> PlaybackOption
		{
			get => GetPropertyValue<CEnum<EInkAnimationPlaybackOption>>();
			set => SetPropertyValue<CEnum<EInkAnimationPlaybackOption>>(value);
		}

		[Ordinal(5)] 
		[RED("animOptionsOverride")] 
		public CHandle<PlaybackOptionsUpdateData> AnimOptionsOverride
		{
			get => GetPropertyValue<CHandle<PlaybackOptionsUpdateData>>();
			set => SetPropertyValue<CHandle<PlaybackOptionsUpdateData>>(value);
		}

		[Ordinal(6)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public CustomUIAnimationEvent()
		{
			LibraryItemAnchor = Enums.inkEAnchor.Fill;
			OwnerID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
