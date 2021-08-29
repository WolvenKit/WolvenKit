using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questShowOverlay_NodeSubType : questITutorial_NodeSubType
	{
		private CResourceAsyncReference<inkWidgetLibraryResource> _overlayLibrary;
		private CName _libraryItemName;
		private CBool _visible;
		private CBool _pauseGame;
		private CBool _lockPlayerMovement;
		private CBool _hideOnInput;

		[Ordinal(0)] 
		[RED("overlayLibrary")] 
		public CResourceAsyncReference<inkWidgetLibraryResource> OverlayLibrary
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
	}
}
