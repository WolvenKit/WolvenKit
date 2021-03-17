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
			get => GetProperty(ref _overlayLibrary);
			set => SetProperty(ref _overlayLibrary, value);
		}

		[Ordinal(1)] 
		[RED("libraryItemName")] 
		public CName LibraryItemName
		{
			get => GetProperty(ref _libraryItemName);
			set => SetProperty(ref _libraryItemName, value);
		}

		[Ordinal(2)] 
		[RED("visible")] 
		public CBool Visible
		{
			get => GetProperty(ref _visible);
			set => SetProperty(ref _visible, value);
		}

		[Ordinal(3)] 
		[RED("pauseGame")] 
		public CBool PauseGame
		{
			get => GetProperty(ref _pauseGame);
			set => SetProperty(ref _pauseGame, value);
		}

		[Ordinal(4)] 
		[RED("lockPlayerMovement")] 
		public CBool LockPlayerMovement
		{
			get => GetProperty(ref _lockPlayerMovement);
			set => SetProperty(ref _lockPlayerMovement, value);
		}

		[Ordinal(5)] 
		[RED("hideOnInput")] 
		public CBool HideOnInput
		{
			get => GetProperty(ref _hideOnInput);
			set => SetProperty(ref _hideOnInput, value);
		}

		public questShowOverlay_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
