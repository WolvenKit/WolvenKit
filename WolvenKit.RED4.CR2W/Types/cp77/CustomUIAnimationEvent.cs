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
			get
			{
				if (_libraryItemName == null)
				{
					_libraryItemName = (CName) CR2WTypeManager.Create("CName", "libraryItemName", cr2w, this);
				}
				return _libraryItemName;
			}
			set
			{
				if (_libraryItemName == value)
				{
					return;
				}
				_libraryItemName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("libraryItemAnchor")] 
		public CEnum<inkEAnchor> LibraryItemAnchor
		{
			get
			{
				if (_libraryItemAnchor == null)
				{
					_libraryItemAnchor = (CEnum<inkEAnchor>) CR2WTypeManager.Create("inkEAnchor", "libraryItemAnchor", cr2w, this);
				}
				return _libraryItemAnchor;
			}
			set
			{
				if (_libraryItemAnchor == value)
				{
					return;
				}
				_libraryItemAnchor = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("forceRespawnLibraryItem")] 
		public CBool ForceRespawnLibraryItem
		{
			get
			{
				if (_forceRespawnLibraryItem == null)
				{
					_forceRespawnLibraryItem = (CBool) CR2WTypeManager.Create("Bool", "forceRespawnLibraryItem", cr2w, this);
				}
				return _forceRespawnLibraryItem;
			}
			set
			{
				if (_forceRespawnLibraryItem == value)
				{
					return;
				}
				_forceRespawnLibraryItem = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get
			{
				if (_animationName == null)
				{
					_animationName = (CName) CR2WTypeManager.Create("CName", "animationName", cr2w, this);
				}
				return _animationName;
			}
			set
			{
				if (_animationName == value)
				{
					return;
				}
				_animationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("playbackOption")] 
		public CEnum<EInkAnimationPlaybackOption> PlaybackOption
		{
			get
			{
				if (_playbackOption == null)
				{
					_playbackOption = (CEnum<EInkAnimationPlaybackOption>) CR2WTypeManager.Create("EInkAnimationPlaybackOption", "playbackOption", cr2w, this);
				}
				return _playbackOption;
			}
			set
			{
				if (_playbackOption == value)
				{
					return;
				}
				_playbackOption = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("animOptionsOverride")] 
		public CHandle<PlaybackOptionsUpdateData> AnimOptionsOverride
		{
			get
			{
				if (_animOptionsOverride == null)
				{
					_animOptionsOverride = (CHandle<PlaybackOptionsUpdateData>) CR2WTypeManager.Create("handle:PlaybackOptionsUpdateData", "animOptionsOverride", cr2w, this);
				}
				return _animOptionsOverride;
			}
			set
			{
				if (_animOptionsOverride == value)
				{
					return;
				}
				_animOptionsOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get
			{
				if (_ownerID == null)
				{
					_ownerID = (entEntityID) CR2WTypeManager.Create("entEntityID", "ownerID", cr2w, this);
				}
				return _ownerID;
			}
			set
			{
				if (_ownerID == value)
				{
					return;
				}
				_ownerID = value;
				PropertySet(this);
			}
		}

		public CustomUIAnimationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
