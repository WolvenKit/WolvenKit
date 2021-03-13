using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CustomUIAnimationEvent : redEvent
	{
		[Ordinal(0)] [RED("libraryItemName")] public CName LibraryItemName { get; set; }
		[Ordinal(1)] [RED("libraryItemAnchor")] public CEnum<inkEAnchor> LibraryItemAnchor { get; set; }
		[Ordinal(2)] [RED("forceRespawnLibraryItem")] public CBool ForceRespawnLibraryItem { get; set; }
		[Ordinal(3)] [RED("animationName")] public CName AnimationName { get; set; }
		[Ordinal(4)] [RED("playbackOption")] public CEnum<EInkAnimationPlaybackOption> PlaybackOption { get; set; }
		[Ordinal(5)] [RED("animOptionsOverride")] public CHandle<PlaybackOptionsUpdateData> AnimOptionsOverride { get; set; }
		[Ordinal(6)] [RED("ownerID")] public entEntityID OwnerID { get; set; }

		public CustomUIAnimationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
