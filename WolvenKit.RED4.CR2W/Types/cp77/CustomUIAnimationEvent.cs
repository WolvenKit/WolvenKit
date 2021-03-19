using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CustomUIAnimationEvent : redEvent
	{
		private CName _libraryItemName;
		private CEnum<inkEAnchor> _libraryItemAnchor;
		private CBool _forceRespawnLibraryItem;
		private CName _animationName;
		private CEnum<EInkAnimationPlaybackOption> _playbackOption;
		private CHandle<PlaybackOptionsUpdateData> _animOptionsOverride;
		private entEntityID _ownerID;

		[Ordinal(0)] 
		[RED("libraryItemName")] 
		public CName LibraryItemName
		{
			get => GetProperty(ref _libraryItemName);
			set => SetProperty(ref _libraryItemName, value);
		}

		[Ordinal(1)] 
		[RED("libraryItemAnchor")] 
		public CEnum<inkEAnchor> LibraryItemAnchor
		{
			get => GetProperty(ref _libraryItemAnchor);
			set => SetProperty(ref _libraryItemAnchor, value);
		}

		[Ordinal(2)] 
		[RED("forceRespawnLibraryItem")] 
		public CBool ForceRespawnLibraryItem
		{
			get => GetProperty(ref _forceRespawnLibraryItem);
			set => SetProperty(ref _forceRespawnLibraryItem, value);
		}

		[Ordinal(3)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetProperty(ref _animationName);
			set => SetProperty(ref _animationName, value);
		}

		[Ordinal(4)] 
		[RED("playbackOption")] 
		public CEnum<EInkAnimationPlaybackOption> PlaybackOption
		{
			get => GetProperty(ref _playbackOption);
			set => SetProperty(ref _playbackOption, value);
		}

		[Ordinal(5)] 
		[RED("animOptionsOverride")] 
		public CHandle<PlaybackOptionsUpdateData> AnimOptionsOverride
		{
			get => GetProperty(ref _animOptionsOverride);
			set => SetProperty(ref _animOptionsOverride, value);
		}

		[Ordinal(6)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetProperty(ref _ownerID);
			set => SetProperty(ref _ownerID, value);
		}

		public CustomUIAnimationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
