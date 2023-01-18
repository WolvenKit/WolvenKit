using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questShowOverlay_NodeSubType : questITutorial_NodeSubType
	{
		[Ordinal(0)] 
		[RED("overlayLibrary")] 
		public CResourceAsyncReference<inkWidgetLibraryResource> OverlayLibrary
		{
			get => GetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>();
			set => SetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>(value);
		}

		[Ordinal(1)] 
		[RED("libraryItemName")] 
		public CName LibraryItemName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("visible")] 
		public CBool Visible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("pauseGame")] 
		public CBool PauseGame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("lockPlayerMovement")] 
		public CBool LockPlayerMovement
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("hideOnInput")] 
		public CBool HideOnInput
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questShowOverlay_NodeSubType()
		{
			LibraryItemName = "Root";
			Visible = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
