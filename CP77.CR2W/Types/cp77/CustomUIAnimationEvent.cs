using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CustomUIAnimationEvent : redEvent
	{
		[Ordinal(0)]  [RED("animOptionsOverride")] public CHandle<PlaybackOptionsUpdateData> AnimOptionsOverride { get; set; }
		[Ordinal(1)]  [RED("animationName")] public CName AnimationName { get; set; }
		[Ordinal(2)]  [RED("forceRespawnLibraryItem")] public CBool ForceRespawnLibraryItem { get; set; }
		[Ordinal(3)]  [RED("libraryItemAnchor")] public CEnum<inkEAnchor> LibraryItemAnchor { get; set; }
		[Ordinal(4)]  [RED("libraryItemName")] public CName LibraryItemName { get; set; }
		[Ordinal(5)]  [RED("ownerID")] public entEntityID OwnerID { get; set; }
		[Ordinal(6)]  [RED("playbackOption")] public CEnum<EInkAnimationPlaybackOption> PlaybackOption { get; set; }

		public CustomUIAnimationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
