using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questShowOverlay_NodeSubType : questITutorial_NodeSubType
	{
		private raRef<inkWidgetLibraryResource> _overlayLibrary;
		private CName _libraryItemName;
		private CBool _visible;
		private CBool _pauseGame;
		private CBool _lockPlayerMovement;
		private CBool _hideOnInput;

		[Ordinal(0)] 
		[RED("overlayLibrary")] 
		public raRef<inkWidgetLibraryResource> OverlayLibrary
		{
			get
			{
				if (_overlayLibrary == null)
				{
					_overlayLibrary = (raRef<inkWidgetLibraryResource>) CR2WTypeManager.Create("raRef:inkWidgetLibraryResource", "overlayLibrary", cr2w, this);
				}
				return _overlayLibrary;
			}
			set
			{
				if (_overlayLibrary == value)
				{
					return;
				}
				_overlayLibrary = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("visible")] 
		public CBool Visible
		{
			get
			{
				if (_visible == null)
				{
					_visible = (CBool) CR2WTypeManager.Create("Bool", "visible", cr2w, this);
				}
				return _visible;
			}
			set
			{
				if (_visible == value)
				{
					return;
				}
				_visible = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("pauseGame")] 
		public CBool PauseGame
		{
			get
			{
				if (_pauseGame == null)
				{
					_pauseGame = (CBool) CR2WTypeManager.Create("Bool", "pauseGame", cr2w, this);
				}
				return _pauseGame;
			}
			set
			{
				if (_pauseGame == value)
				{
					return;
				}
				_pauseGame = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("lockPlayerMovement")] 
		public CBool LockPlayerMovement
		{
			get
			{
				if (_lockPlayerMovement == null)
				{
					_lockPlayerMovement = (CBool) CR2WTypeManager.Create("Bool", "lockPlayerMovement", cr2w, this);
				}
				return _lockPlayerMovement;
			}
			set
			{
				if (_lockPlayerMovement == value)
				{
					return;
				}
				_lockPlayerMovement = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("hideOnInput")] 
		public CBool HideOnInput
		{
			get
			{
				if (_hideOnInput == null)
				{
					_hideOnInput = (CBool) CR2WTypeManager.Create("Bool", "hideOnInput", cr2w, this);
				}
				return _hideOnInput;
			}
			set
			{
				if (_hideOnInput == value)
				{
					return;
				}
				_hideOnInput = value;
				PropertySet(this);
			}
		}

		public questShowOverlay_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
