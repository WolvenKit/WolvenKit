using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TerminalInkGameControllerBase : MasterDeviceInkGameControllerBase
	{
		private TweakDBID _layoutID;
		private CName _currentLayoutLibraryID;
		private CWeakHandle<inkWidget> _mainLayout;
		private CArray<gamePersistentID> _currentlyActiveDevices;
		private CWeakHandle<inkVideoWidget> _mainDisplayWidget;
		private CString _terminalTitle;
		private CHandle<redCallbackObject> _onGlitchingStateChangedListener;

		[Ordinal(18)] 
		[RED("layoutID")] 
		public TweakDBID LayoutID
		{
			get => GetProperty(ref _layoutID);
			set => SetProperty(ref _layoutID, value);
		}

		[Ordinal(19)] 
		[RED("currentLayoutLibraryID")] 
		public CName CurrentLayoutLibraryID
		{
			get => GetProperty(ref _currentLayoutLibraryID);
			set => SetProperty(ref _currentLayoutLibraryID, value);
		}

		[Ordinal(20)] 
		[RED("mainLayout")] 
		public CWeakHandle<inkWidget> MainLayout
		{
			get => GetProperty(ref _mainLayout);
			set => SetProperty(ref _mainLayout, value);
		}

		[Ordinal(21)] 
		[RED("currentlyActiveDevices")] 
		public CArray<gamePersistentID> CurrentlyActiveDevices
		{
			get => GetProperty(ref _currentlyActiveDevices);
			set => SetProperty(ref _currentlyActiveDevices, value);
		}

		[Ordinal(22)] 
		[RED("mainDisplayWidget")] 
		public CWeakHandle<inkVideoWidget> MainDisplayWidget
		{
			get => GetProperty(ref _mainDisplayWidget);
			set => SetProperty(ref _mainDisplayWidget, value);
		}

		[Ordinal(23)] 
		[RED("terminalTitle")] 
		public CString TerminalTitle
		{
			get => GetProperty(ref _terminalTitle);
			set => SetProperty(ref _terminalTitle, value);
		}

		[Ordinal(24)] 
		[RED("onGlitchingStateChangedListener")] 
		public CHandle<redCallbackObject> OnGlitchingStateChangedListener
		{
			get => GetProperty(ref _onGlitchingStateChangedListener);
			set => SetProperty(ref _onGlitchingStateChangedListener, value);
		}
	}
}
