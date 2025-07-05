using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TerminalInkGameControllerBase : MasterDeviceInkGameControllerBase
	{
		[Ordinal(20)] 
		[RED("layoutID")] 
		public TweakDBID LayoutID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(21)] 
		[RED("currentLayoutLibraryID")] 
		public CName CurrentLayoutLibraryID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(22)] 
		[RED("mainLayout")] 
		public CWeakHandle<inkWidget> MainLayout
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(23)] 
		[RED("currentlyActiveDevices")] 
		public CArray<gamePersistentID> CurrentlyActiveDevices
		{
			get => GetPropertyValue<CArray<gamePersistentID>>();
			set => SetPropertyValue<CArray<gamePersistentID>>(value);
		}

		[Ordinal(24)] 
		[RED("buttonVisibility")] 
		public CBool ButtonVisibility
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("mainDisplayWidget")] 
		public CWeakHandle<inkVideoWidget> MainDisplayWidget
		{
			get => GetPropertyValue<CWeakHandle<inkVideoWidget>>();
			set => SetPropertyValue<CWeakHandle<inkVideoWidget>>(value);
		}

		[Ordinal(26)] 
		[RED("terminalTitle")] 
		public CString TerminalTitle
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(27)] 
		[RED("onGlitchingStateChangedListener")] 
		public CHandle<redCallbackObject> OnGlitchingStateChangedListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public TerminalInkGameControllerBase()
		{
			CurrentlyActiveDevices = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
